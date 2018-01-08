namespace 大作业客户端
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientIPBox = new System.Windows.Forms.TextBox();
            this.clientPortBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serverIPBox = new System.Windows.Forms.TextBox();
            this.serverPortBox = new System.Windows.Forms.TextBox();
            this.clientLog = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.expressBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clientStart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.clientStat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户端IP：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "服务器IP：";
            // 
            // clientIPBox
            // 
            this.clientIPBox.Location = new System.Drawing.Point(89, 16);
            this.clientIPBox.Name = "clientIPBox";
            this.clientIPBox.Size = new System.Drawing.Size(149, 21);
            this.clientIPBox.TabIndex = 2;
            this.clientIPBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clientPortBox
            // 
            this.clientPortBox.Location = new System.Drawing.Point(330, 16);
            this.clientPortBox.Name = "clientPortBox";
            this.clientPortBox.Size = new System.Drawing.Size(124, 21);
            this.clientPortBox.TabIndex = 3;
            this.clientPortBox.TextChanged += new System.EventHandler(this.clientPortBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "端口号：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "端口号：";
            // 
            // serverIPBox
            // 
            this.serverIPBox.Location = new System.Drawing.Point(89, 51);
            this.serverIPBox.Name = "serverIPBox";
            this.serverIPBox.Size = new System.Drawing.Size(149, 21);
            this.serverIPBox.TabIndex = 6;
            this.serverIPBox.TextChanged += new System.EventHandler(this.serverIPBox_TextChanged);
            // 
            // serverPortBox
            // 
            this.serverPortBox.Location = new System.Drawing.Point(330, 51);
            this.serverPortBox.Name = "serverPortBox";
            this.serverPortBox.Size = new System.Drawing.Size(124, 21);
            this.serverPortBox.TabIndex = 7;
            this.serverPortBox.TextChanged += new System.EventHandler(this.serverPortBox_TextChanged);
            // 
            // clientLog
            // 
            this.clientLog.Location = new System.Drawing.Point(28, 204);
            this.clientLog.Name = "clientLog";
            this.clientLog.ReadOnly = true;
            this.clientLog.Size = new System.Drawing.Size(426, 331);
            this.clientLog.TabIndex = 8;
            this.clientLog.Text = "";
            this.clientLog.TextChanged += new System.EventHandler(this.clientLog_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "客户端日志：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "算术表达式：";
            // 
            // expressBox
            // 
            this.expressBox.Location = new System.Drawing.Point(111, 93);
            this.expressBox.Name = "expressBox";
            this.expressBox.Size = new System.Drawing.Size(343, 21);
            this.expressBox.TabIndex = 11;
            this.expressBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientStart
            // 
            this.clientStart.Location = new System.Drawing.Point(30, 131);
            this.clientStart.Name = "clientStart";
            this.clientStart.Size = new System.Drawing.Size(75, 23);
            this.clientStart.TabIndex = 13;
            this.clientStart.Text = "开启客户端";
            this.clientStart.UseVisualStyleBackColor = true;
            this.clientStart.Click += new System.EventHandler(this.clientStart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "客户端状态：";
            // 
            // clientStat
            // 
            this.clientStat.AutoSize = true;
            this.clientStat.Location = new System.Drawing.Point(188, 136);
            this.clientStat.Name = "clientStat";
            this.clientStat.Size = new System.Drawing.Size(29, 12);
            this.clientStat.TabIndex = 15;
            this.clientStat.Text = "关机";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.clientStat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clientStart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.expressBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clientLog);
            this.Controls.Add(this.serverPortBox);
            this.Controls.Add(this.serverIPBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientPortBox);
            this.Controls.Add(this.clientIPBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientIPBox;
        private System.Windows.Forms.TextBox clientPortBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverIPBox;
        private System.Windows.Forms.TextBox serverPortBox;
        private System.Windows.Forms.RichTextBox clientLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox expressBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clientStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label clientStat;
    }
}

