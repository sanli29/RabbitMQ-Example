using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RabbitMQ.Client;
using Newtonsoft.Json;
using System.Collections;

namespace Producer.WinForm
{
    public partial class Form1 : Form
    {
        private IConnection connection;
        private IModel _channel;
        private IModel channel => _channel ?? (_channel = CreateChannel());

        private IDictionary<string, object> _argumentDictionary;

        private IDictionary<string, object> argumentDictionary => _argumentDictionary ?? (_argumentDictionary = CreateDictionary());

        private IDictionary<string, object> CreateDictionary()
        {
            return new Dictionary<string, object>();
        }

        private IDictionary<string, object> _argumentPublishDictionary;

        private IDictionary<string, object> argumentPublishDictionary => _argumentPublishDictionary ?? (_argumentPublishDictionary = CreatePublishDictionary());

        private IDictionary<string, object> CreatePublishDictionary()
        {
            return new Dictionary<string, object>();
        }

        public Form1()
        {
            InitializeComponent();
        }
        private IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                Uri = new Uri(txtConnectionString.Text, UriKind.RelativeOrAbsolute)
            };

            return factory.CreateConnection();
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            connection = GetConnection();
            MessageBox.Show(" Bağlandı ");
        }
        private IModel CreateChannel()
        {
            return connection.CreateModel();
        }
        private void BtnDeclareExchange_Click(object sender, EventArgs e)
        {
            channel.ExchangeDeclare(txtDeclareExchangeName.Text,txtDeclareExchangeType.Text);
        }

        private void BtnDeclareQueue_Click(object sender, EventArgs e)
        {
            channel.QueueDeclare(txtDeclareQueueName.Text,false,false,false);
        }

        private void BtnBindingQueue_Click(object sender, EventArgs e)
        {
            if (txtBindingExchangeType.Text == "headers")
            {
                argumentDictionary.Add("x-match", txtXMatchType.Text);
                channel.QueueBind(txtDeclareQueueName.Text, txtDeclareExchangeName.Text, txtBindingRoutingKey.Text, argumentDictionary);
            }
            else
            {
                channel.QueueBind(txtDeclareQueueName.Text, txtDeclareExchangeName.Text, txtBindingRoutingKey.Text);
            }
            
        }

        private void WriteDateToExchange(string exchangeName,string routingKey,IBasicProperties properties,object data)
        {
            var dataArr = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)); 
            channel.BasicPublish(exchangeName,routingKey, properties, dataArr);
        }
        private void BtnPublish_Click(object sender, EventArgs e)
        {
            IBasicProperties properties = null;

            if (argumentPublishDictionary.Count != 0)
            {
                properties = channel.CreateBasicProperties();
                properties.Persistent = false;
                properties.Headers = argumentPublishDictionary;
            }
            

            var message = txtPublishMsg.Text;
            for (int i = 0; i < txtPublishRepeat.Value; i++)
            {
                message = $"[{i + 1}] - {txtPublishMsg.Text}";
                WriteDateToExchange(txtDeclareExchangeName.Text, txtPublishRoutingKey.Text, properties, txtPublishMsg.Text);
            }           
        }

        private void BtnAddArgument_Click(object sender, EventArgs e)
        {
            argumentDictionary.Add(txtArgumentName.Text, txtArgumentValue.Text);
        }

        private void TxtBindingExchangeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtBindingExchangeType.Text == "headers")
            {
                grpArgument.Visible = true;
            }
            else
            {
                grpArgument.Visible = false;
            }
        }

        private void BtnPublishAddArgument_Click(object sender, EventArgs e)
        {
            argumentPublishDictionary.Add(txtPublishArgumentName.Text, txtPublishArgumentValue.Text);
        }
    }
}
