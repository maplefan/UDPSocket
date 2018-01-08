using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace 大作业客户端
{
    public partial class Form1 : Form
    {
        bool client = false;
        private UdpClient udpClient;
        string sendMsg = " ";//发送的数据
        string serverIP = "127.0.0.1";//服务器IP地址
        string serverPort = "5500";//服务器端口号
        string clientIP = "127.0.0.1";//客户端IP地址
        string clientPort = "7700";//客户端端口号
        Thread MyThread;
        IPEndPoint udpPoint;
        IPEndPoint targetPoint;
        private int count = 1;
        double sendNum = 0;
        double recvNum = 0;

        public Form1()
        {
            Form1.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            clientIPBox.Text = clientIP;
            serverIPBox.Text = serverIP;
            clientPortBox.Text = clientPort;
            serverPortBox.Text = serverPort;
       
            
             udpPoint = new IPEndPoint(IPAddress.Parse(clientIP), int.Parse(clientPort));
             targetPoint = new IPEndPoint(IPAddress.Parse(serverIP), int.Parse(serverPort));
             MyThread = new Thread(new ThreadStart(ReceiveData));
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            sendMsg = expressBox.Text;
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clientIP = clientIPBox.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void clientPortBox_TextChanged(object sender, EventArgs e)
        {
            clientPort = clientPortBox.Text;
        }

        private void serverIPBox_TextChanged(object sender, EventArgs e)
        {
            serverIP = serverIPBox.Text;
        }

        private void serverPortBox_TextChanged(object sender, EventArgs e)
        {
            serverPort = serverPortBox.Text;
        }

        private void clientLog_TextChanged(object sender, EventArgs e)
        {
            clientLog.SelectionStart = clientLog.TextLength;
            clientLog.Focus();
        }


        public void ReceiveData()
        {
            udpClient = new UdpClient(udpPoint);
            while (true)//udpClient.Client.Available > 0
            {
                try
                {
                    byte[] recvData = udpClient.Receive(ref targetPoint);
                    recvNum++;
                    clientLog.Text = clientLog.Text + DateTime.Now.ToString() + " 结果：" + Encoding.Default.GetString(recvData) + "\r\n";
                }
                catch (Exception)
                {

                }
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recvNum = 0;
            try
            {
                sendNum = count;
            }
            catch (Exception)
            {
              
            }
            
            if (client == true)
            {
                
                   // count--;
                IPEndPoint targetPoint = new IPEndPoint(IPAddress.Parse(serverIP), int.Parse(serverPort));
                byte[] sendData = Encoding.Default.GetBytes(sendMsg);
                udpClient.Send(sendData, sendData.Length, targetPoint);
                clientLog.Text = clientLog.Text + DateTime.Now.ToString() + " 发往：" + targetPoint.Address + ":" + targetPoint.Port + " " + Encoding.Default.GetString(sendData) + "\r\n";
                //udpClient.Close(); "\r\n"
              
                
               
            }
        }

        private void clientStart_Click(object sender, EventArgs e)
        {
            if (client == false)
            {
                try {
                    MyThread.Start();
                }
                catch (Exception)
                {
                    MyThread.Resume();
                }
                clientStart.Text = "关闭客户端";
                client = true;
                clientStat.Text = "运行中";
            }
            else {
                MyThread.Suspend();
                clientStart.Text = "开启客户端";
                client = false;
                clientStat.Text = "关机";
            }
        }

        private void sendCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void getLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
