namespace 大作业服务端
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
            this.labelStat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serverIPBox = new System.Windows.Forms.TextBox();
            this.serverPortBox = new System.Windows.Forms.TextBox();
            this.startServer = new System.Windows.Forms.Button();
            this.serverStat = new System.Windows.Forms.Label();
            this.serverLog = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Location = new System.Drawing.Point(166, 286);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(77, 12);
            this.labelStat.TabIndex = 0;
            this.labelStat.Text = "服务器状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "服务器IP：";
            // 
            // serverIPBox
            // 
            this.serverIPBox.Location = new System.Drawing.Point(94, 12);
            this.serverIPBox.Name = "serverIPBox";
            this.serverIPBox.Size = new System.Drawing.Size(149, 21);
            this.serverIPBox.TabIndex = 3;
            this.serverIPBox.TextChanged += new System.EventHandler(this.serverIPBox_TextChanged);
            // 
            // serverPortBox
            // 
            this.serverPortBox.Location = new System.Drawing.Point(323, 12);
            this.serverPortBox.Name = "serverPortBox";
            this.serverPortBox.Size = new System.Drawing.Size(131, 21);
            this.serverPortBox.TabIndex = 4;
            this.serverPortBox.TextChanged += new System.EventHandler(this.serverPortBox_TextChanged);
            // 
            // startServer
            // 
            this.startServer.Location = new System.Drawing.Point(34, 281);
            this.startServer.Name = "startServer";
            this.startServer.Size = new System.Drawing.Size(75, 23);
            this.startServer.TabIndex = 5;
            this.startServer.Text = "开启服务";
            this.startServer.UseVisualStyleBackColor = true;
            this.startServer.Click += new System.EventHandler(this.button1_Click);
            // 
            // serverStat
            // 
            this.serverStat.AutoSize = true;
            this.serverStat.Location = new System.Drawing.Point(249, 286);
            this.serverStat.Name = "serverStat";
            this.serverStat.Size = new System.Drawing.Size(29, 12);
            this.serverStat.TabIndex = 6;
            this.serverStat.Text = "关机";
            // 
            // serverLog
            // 
            this.serverLog.Location = new System.Drawing.Point(34, 74);
            this.serverLog.Name = "serverLog";
            this.serverLog.ReadOnly = true;
            this.serverLog.Size = new System.Drawing.Size(420, 201);
            this.serverLog.TabIndex = 7;
            this.serverLog.Text = "";
            this.serverLog.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "服务器日志：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.serverLog);
            this.Controls.Add(this.serverStat);
            this.Controls.Add(this.startServer);
            this.Controls.Add(this.serverPortBox);
            this.Controls.Add(this.serverIPBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelStat);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverIPBox;
        private System.Windows.Forms.TextBox serverPortBox;
        private System.Windows.Forms.Button startServer;
        private System.Windows.Forms.Label serverStat;
        private System.Windows.Forms.RichTextBox serverLog;
        private System.Windows.Forms.Label label5;
    }
}

