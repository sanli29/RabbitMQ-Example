using System;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace Consume.ConsoleApp
{
    class Program
    {
        private static string connectionString = "amqp://localhost:5672";
        private static string queueName = "headers_deneme_2";

        private static IConnection connection;
        private static IModel _channel;
        private static IModel channel => _channel ?? (_channel = CreateChannel());
        private static IModel CreateChannel()
        {
            return connection.CreateModel();
        }
        private static IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                Uri = new Uri(connectionString, UriKind.RelativeOrAbsolute)
            };

            return factory.CreateConnection();
        }

        static void Main(string[] args)
        {
            connection = GetConnection();
            channel.QueueDeclare(queueName, exclusive: false,autoDelete:false);
            var consumeEvent = new EventingBasicConsumer(channel);
            consumeEvent.Received += (ch, e) =>
            {
                var byteArr = e.Body.ToArray();
                var bodyStr = Encoding.UTF8.GetString(byteArr);
                Console.WriteLine($"Received Data: {bodyStr}");
            };
            channel.BasicConsume(queueName, true, consumeEvent);
            Console.WriteLine($"{queueName} listening ... \n\n");
            Console.ReadLine();

        }
    }
}
