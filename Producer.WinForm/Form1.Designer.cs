namespace Producer.WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTransactions = new System.Windows.Forms.GroupBox();
            this.grpPublish = new System.Windows.Forms.GroupBox();
            this.txtPublishRoutingKey = new System.Windows.Forms.TextBox();
            this.txtPublishRepeat = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPublishMsg = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPublishExchangeName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpBinding = new System.Windows.Forms.GroupBox();
            this.grpArgument = new System.Windows.Forms.GroupBox();
            this.txtArgumentValue = new System.Windows.Forms.TextBox();
            this.txtXMatchType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddArgument = new System.Windows.Forms.Button();
            this.txtArgumentName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBindingQueue = new System.Windows.Forms.Button();
            this.txtBindingExchangeType = new System.Windows.Forms.ComboBox();
            this.txtBindingRoutingKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpDeclareExchange = new System.Windows.Forms.GroupBox();
            this.txtDeclareExchangeType = new System.Windows.Forms.ComboBox();
            this.btnDeclareExchange = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeclareExchangeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpDeclareQueue = new System.Windows.Forms.GroupBox();
            this.btnDeclareQueue = new System.Windows.Forms.Button();
            this.txtDeclareQueueName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPublishArgumentValue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPublishAddArgument = new System.Windows.Forms.Button();
            this.txtPublishArgumentName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grpConnection.SuspendLayout();
            this.grpTransactions.SuspendLayout();
            this.grpPublish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPublishRepeat)).BeginInit();
            this.grpBinding.SuspendLayout();
            this.grpArgument.SuspendLayout();
            this.grpDeclareExchange.SuspendLayout();
            this.grpDeclareQueue.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.txtConnectionString);
            this.grpConnection.Controls.Add(this.btnConnect);
            this.grpConnection.Controls.Add(this.label1);
            this.grpConnection.Location = new System.Drawing.Point(12, 12);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(679, 74);
            this.grpConnection.TabIndex = 1;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "Connection";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(127, 28);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(437, 20);
            this.txtConnectionString.TabIndex = 2;
            this.txtConnectionString.Text = "amqp://localhost:5672";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(570, 26);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // grpTransactions
            // 
            this.grpTransactions.Controls.Add(this.grpPublish);
            this.grpTransactions.Controls.Add(this.grpBinding);
            this.grpTransactions.Controls.Add(this.grpDeclareExchange);
            this.grpTransactions.Controls.Add(this.grpDeclareQueue);
            this.grpTransactions.Location = new System.Drawing.Point(12, 92);
            this.grpTransactions.Name = "grpTransactions";
            this.grpTransactions.Size = new System.Drawing.Size(679, 437);
            this.grpTransactions.TabIndex = 2;
            this.grpTransactions.TabStop = false;
            this.grpTransactions.Text = "Transactions";
            // 
            // grpPublish
            // 
            this.grpPublish.Controls.Add(this.label14);
            this.grpPublish.Controls.Add(this.txtPublishArgumentValue);
            this.grpPublish.Controls.Add(this.txtPublishRoutingKey);
            this.grpPublish.Controls.Add(this.label13);
            this.grpPublish.Controls.Add(this.txtPublishRepeat);
            this.grpPublish.Controls.Add(this.btnPublishAddArgument);
            this.grpPublish.Controls.Add(this.label9);
            this.grpPublish.Controls.Add(this.txtPublishArgumentName);
            this.grpPublish.Controls.Add(this.label8);
            this.grpPublish.Controls.Add(this.txtPublishMsg);
            this.grpPublish.Controls.Add(this.btnPublish);
            this.grpPublish.Controls.Add(this.label7);
            this.grpPublish.Controls.Add(this.txtPublishExchangeName);
            this.grpPublish.Controls.Add(this.label6);
            this.grpPublish.Location = new System.Drawing.Point(6, 141);
            this.grpPublish.Name = "grpPublish";
            this.grpPublish.Size = new System.Drawing.Size(439, 286);
            this.grpPublish.TabIndex = 3;
            this.grpPublish.TabStop = false;
            this.grpPublish.Text = "Publish";
            // 
            // txtPublishRoutingKey
            // 
            this.txtPublishRoutingKey.Location = new System.Drawing.Point(116, 53);
            this.txtPublishRoutingKey.Name = "txtPublishRoutingKey";
            this.txtPublishRoutingKey.Size = new System.Drawing.Size(138, 20);
            this.txtPublishRoutingKey.TabIndex = 19;
            // 
            // txtPublishRepeat
            // 
            this.txtPublishRepeat.Location = new System.Drawing.Point(116, 180);
            this.txtPublishRepeat.Name = "txtPublishRepeat";
            this.txtPublishRepeat.Size = new System.Drawing.Size(138, 20);
            this.txtPublishRepeat.TabIndex = 18;
            this.txtPublishRepeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Repeat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Msg";
            // 
            // txtPublishMsg
            // 
            this.txtPublishMsg.Location = new System.Drawing.Point(65, 79);
            this.txtPublishMsg.Multiline = true;
            this.txtPublishMsg.Name = "txtPublishMsg";
            this.txtPublishMsg.Size = new System.Drawing.Size(189, 90);
            this.txtPublishMsg.TabIndex = 14;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(285, 257);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(138, 23);
            this.btnPublish.TabIndex = 9;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.BtnPublish_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Exchange Name";
            // 
            // txtPublishExchangeName
            // 
            this.txtPublishExchangeName.Location = new System.Drawing.Point(116, 24);
            this.txtPublishExchangeName.Name = "txtPublishExchangeName";
            this.txtPublishExchangeName.Size = new System.Drawing.Size(138, 20);
            this.txtPublishExchangeName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Routing Key";
            // 
            // grpBinding
            // 
            this.grpBinding.Controls.Add(this.grpArgument);
            this.grpBinding.Controls.Add(this.label10);
            this.grpBinding.Controls.Add(this.btnBindingQueue);
            this.grpBinding.Controls.Add(this.txtBindingExchangeType);
            this.grpBinding.Controls.Add(this.txtBindingRoutingKey);
            this.grpBinding.Controls.Add(this.label4);
            this.grpBinding.Location = new System.Drawing.Point(445, 19);
            this.grpBinding.Name = "grpBinding";
            this.grpBinding.Size = new System.Drawing.Size(228, 273);
            this.grpBinding.TabIndex = 2;
            this.grpBinding.TabStop = false;
            this.grpBinding.Text = "Binding";
            // 
            // grpArgument
            // 
            this.grpArgument.Controls.Add(this.txtArgumentValue);
            this.grpArgument.Controls.Add(this.txtXMatchType);
            this.grpArgument.Controls.Add(this.label12);
            this.grpArgument.Controls.Add(this.btnAddArgument);
            this.grpArgument.Controls.Add(this.txtArgumentName);
            this.grpArgument.Controls.Add(this.label11);
            this.grpArgument.Location = new System.Drawing.Point(6, 91);
            this.grpArgument.Name = "grpArgument";
            this.grpArgument.Size = new System.Drawing.Size(216, 126);
            this.grpArgument.TabIndex = 28;
            this.grpArgument.TabStop = false;
            this.grpArgument.Text = "Argument";
            this.grpArgument.Visible = false;
            // 
            // txtArgumentValue
            // 
            this.txtArgumentValue.Location = new System.Drawing.Point(119, 19);
            this.txtArgumentValue.Name = "txtArgumentValue";
            this.txtArgumentValue.Size = new System.Drawing.Size(74, 20);
            this.txtArgumentValue.TabIndex = 27;
            // 
            // txtXMatchType
            // 
            this.txtXMatchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtXMatchType.FormattingEnabled = true;
            this.txtXMatchType.Items.AddRange(new object[] {
            "any",
            "all"});
            this.txtXMatchType.Location = new System.Drawing.Point(92, 87);
            this.txtXMatchType.Name = "txtXMatchType";
            this.txtXMatchType.Size = new System.Drawing.Size(101, 21);
            this.txtXMatchType.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = ":";
            // 
            // btnAddArgument
            // 
            this.btnAddArgument.Location = new System.Drawing.Point(41, 55);
            this.btnAddArgument.Name = "btnAddArgument";
            this.btnAddArgument.Size = new System.Drawing.Size(141, 23);
            this.btnAddArgument.TabIndex = 21;
            this.btnAddArgument.Text = "Add Argument";
            this.btnAddArgument.UseVisualStyleBackColor = true;
            this.btnAddArgument.Click += new System.EventHandler(this.BtnAddArgument_Click);
            // 
            // txtArgumentName
            // 
            this.txtArgumentName.Location = new System.Drawing.Point(23, 19);
            this.txtArgumentName.Name = "txtArgumentName";
            this.txtArgumentName.Size = new System.Drawing.Size(74, 20);
            this.txtArgumentName.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "x-match";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Type";
            // 
            // btnBindingQueue
            // 
            this.btnBindingQueue.Location = new System.Drawing.Point(15, 232);
            this.btnBindingQueue.Name = "btnBindingQueue";
            this.btnBindingQueue.Size = new System.Drawing.Size(204, 23);
            this.btnBindingQueue.TabIndex = 4;
            this.btnBindingQueue.Text = "Binding Queue";
            this.btnBindingQueue.UseVisualStyleBackColor = true;
            this.btnBindingQueue.Click += new System.EventHandler(this.BtnBindingQueue_Click);
            // 
            // txtBindingExchangeType
            // 
            this.txtBindingExchangeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBindingExchangeType.FormattingEnabled = true;
            this.txtBindingExchangeType.Items.AddRange(new object[] {
            "topic",
            "headers",
            "direct",
            "fanout"});
            this.txtBindingExchangeType.Location = new System.Drawing.Point(84, 58);
            this.txtBindingExchangeType.Name = "txtBindingExchangeType";
            this.txtBindingExchangeType.Size = new System.Drawing.Size(138, 21);
            this.txtBindingExchangeType.TabIndex = 9;
            this.txtBindingExchangeType.SelectedIndexChanged += new System.EventHandler(this.TxtBindingExchangeType_SelectedIndexChanged);
            // 
            // txtBindingRoutingKey
            // 
            this.txtBindingRoutingKey.Location = new System.Drawing.Point(86, 27);
            this.txtBindingRoutingKey.Name = "txtBindingRoutingKey";
            this.txtBindingRoutingKey.Size = new System.Drawing.Size(138, 20);
            this.txtBindingRoutingKey.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Routing Key";
            // 
            // grpDeclareExchange
            // 
            this.grpDeclareExchange.Controls.Add(this.txtDeclareExchangeType);
            this.grpDeclareExchange.Controls.Add(this.btnDeclareExchange);
            this.grpDeclareExchange.Controls.Add(this.label5);
            this.grpDeclareExchange.Controls.Add(this.txtDeclareExchangeName);
            this.grpDeclareExchange.Controls.Add(this.label3);
            this.grpDeclareExchange.Location = new System.Drawing.Point(229, 19);
            this.grpDeclareExchange.Name = "grpDeclareExchange";
            this.grpDeclareExchange.Size = new System.Drawing.Size(200, 116);
            this.grpDeclareExchange.TabIndex = 1;
            this.grpDeclareExchange.TabStop = false;
            this.grpDeclareExchange.Text = "Declare Exchange";
            // 
            // txtDeclareExchangeType
            // 
            this.txtDeclareExchangeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDeclareExchangeType.FormattingEnabled = true;
            this.txtDeclareExchangeType.Items.AddRange(new object[] {
            "topic",
            "headers",
            "direct",
            "fanout"});
            this.txtDeclareExchangeType.Location = new System.Drawing.Point(56, 48);
            this.txtDeclareExchangeType.Name = "txtDeclareExchangeType";
            this.txtDeclareExchangeType.Size = new System.Drawing.Size(138, 21);
            this.txtDeclareExchangeType.TabIndex = 1;
            // 
            // btnDeclareExchange
            // 
            this.btnDeclareExchange.Location = new System.Drawing.Point(56, 75);
            this.btnDeclareExchange.Name = "btnDeclareExchange";
            this.btnDeclareExchange.Size = new System.Drawing.Size(138, 23);
            this.btnDeclareExchange.TabIndex = 4;
            this.btnDeclareExchange.Text = "Declare";
            this.btnDeclareExchange.UseVisualStyleBackColor = true;
            this.btnDeclareExchange.Click += new System.EventHandler(this.BtnDeclareExchange_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type";
            // 
            // txtDeclareExchangeName
            // 
            this.txtDeclareExchangeName.Location = new System.Drawing.Point(56, 23);
            this.txtDeclareExchangeName.Name = "txtDeclareExchangeName";
            this.txtDeclareExchangeName.Size = new System.Drawing.Size(138, 20);
            this.txtDeclareExchangeName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // grpDeclareQueue
            // 
            this.grpDeclareQueue.Controls.Add(this.btnDeclareQueue);
            this.grpDeclareQueue.Controls.Add(this.txtDeclareQueueName);
            this.grpDeclareQueue.Controls.Add(this.label2);
            this.grpDeclareQueue.Location = new System.Drawing.Point(6, 19);
            this.grpDeclareQueue.Name = "grpDeclareQueue";
            this.grpDeclareQueue.Size = new System.Drawing.Size(200, 116);
            this.grpDeclareQueue.TabIndex = 0;
            this.grpDeclareQueue.TabStop = false;
            this.grpDeclareQueue.Text = "Declare Queue";
            // 
            // btnDeclareQueue
            // 
            this.btnDeclareQueue.Location = new System.Drawing.Point(46, 56);
            this.btnDeclareQueue.Name = "btnDeclareQueue";
            this.btnDeclareQueue.Size = new System.Drawing.Size(138, 23);
            this.btnDeclareQueue.TabIndex = 3;
            this.btnDeclareQueue.Text = "Declare";
            this.btnDeclareQueue.UseVisualStyleBackColor = true;
            this.btnDeclareQueue.Click += new System.EventHandler(this.BtnDeclareQueue_Click);
            // 
            // txtDeclareQueueName
            // 
            this.txtDeclareQueueName.Location = new System.Drawing.Point(46, 30);
            this.txtDeclareQueueName.Name = "txtDeclareQueueName";
            this.txtDeclareQueueName.Size = new System.Drawing.Size(138, 20);
            this.txtDeclareQueueName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // txtPublishArgumentValue
            // 
            this.txtPublishArgumentValue.Location = new System.Drawing.Point(180, 206);
            this.txtPublishArgumentValue.Name = "txtPublishArgumentValue";
            this.txtPublishArgumentValue.Size = new System.Drawing.Size(74, 20);
            this.txtPublishArgumentValue.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(164, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = ":";
            // 
            // btnPublishAddArgument
            // 
            this.btnPublishAddArgument.Location = new System.Drawing.Point(102, 242);
            this.btnPublishAddArgument.Name = "btnPublishAddArgument";
            this.btnPublishAddArgument.Size = new System.Drawing.Size(141, 23);
            this.btnPublishAddArgument.TabIndex = 28;
            this.btnPublishAddArgument.Text = "Add Argument";
            this.btnPublishAddArgument.UseVisualStyleBackColor = true;
            this.btnPublishAddArgument.Click += new System.EventHandler(this.BtnPublishAddArgument_Click);
            // 
            // txtPublishArgumentName
            // 
            this.txtPublishArgumentName.Location = new System.Drawing.Point(84, 206);
            this.txtPublishArgumentName.Name = "txtPublishArgumentName";
            this.txtPublishArgumentName.Size = new System.Drawing.Size(74, 20);
            this.txtPublishArgumentName.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Argument";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 531);
            this.Controls.Add(this.grpTransactions);
            this.Controls.Add(this.grpConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            this.grpTransactions.ResumeLayout(false);
            this.grpPublish.ResumeLayout(false);
            this.grpPublish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPublishRepeat)).EndInit();
            this.grpBinding.ResumeLayout(false);
            this.grpBinding.PerformLayout();
            this.grpArgument.ResumeLayout(false);
            this.grpArgument.PerformLayout();
            this.grpDeclareExchange.ResumeLayout(false);
            this.grpDeclareExchange.PerformLayout();
            this.grpDeclareQueue.ResumeLayout(false);
            this.grpDeclareQueue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.GroupBox grpTransactions;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPublish;
        private System.Windows.Forms.GroupBox grpBinding;
        private System.Windows.Forms.Button btnBindingQueue;
        private System.Windows.Forms.TextBox txtBindingRoutingKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpDeclareExchange;
        private System.Windows.Forms.TextBox txtDeclareExchangeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpDeclareQueue;
        private System.Windows.Forms.Button btnDeclareQueue;
        private System.Windows.Forms.TextBox txtDeclareQueueName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeclareExchange;
        private System.Windows.Forms.ComboBox txtDeclareExchangeType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPublishExchangeName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtPublishRepeat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPublishMsg;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.TextBox txtPublishRoutingKey;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtBindingExchangeType;
        private System.Windows.Forms.Button btnAddArgument;
        private System.Windows.Forms.GroupBox grpArgument;
        private System.Windows.Forms.TextBox txtArgumentValue;
        private System.Windows.Forms.ComboBox txtXMatchType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtArgumentName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPublishArgumentValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnPublishAddArgument;
        private System.Windows.Forms.TextBox txtPublishArgumentName;
    }
}

