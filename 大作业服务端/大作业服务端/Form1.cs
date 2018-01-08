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

namespace 大作业服务端
{
    public partial class Form1 : Form
    {
        string serverIP = "127.0.0.1";
        string serverPort = "5500";
        double result;
        private UdpClient udpClient;
        Thread MyThread;
        bool threadStat = false;//线程状态


        public Form1()
        {
            InitializeComponent();
            serverPortBox.Text = serverPort;
            serverIPBox.Text = serverIP;
            MyThread = new Thread(new ThreadStart(ReceiveData));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.CheckForIllegalCrossThreadCalls = false;
        }

        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            serverLog.SelectionStart = serverLog.TextLength;
            serverLog.Focus();
        }

        public void ReceiveData()
        {
            while (true)
            {
                IPEndPoint udpPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5500);
                udpClient = new UdpClient(udpPoint);
                //IPEndPoint senderPoint = new IPEndPoint(IPAddress.Parse("14.55.36.2"), 0);
                IPEndPoint senderPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] recvData = udpClient.Receive(ref senderPoint);
                
                try
                {
                    result = Parse(Encoding.Default.GetString(recvData));  
                }
                catch (Exception)
                {
                   
                }
                byte[] sendData = Encoding.Default.GetBytes(result.ToString());
                IPEndPoint sendPoint = new IPEndPoint(senderPoint.Address, senderPoint.Port);
                serverLog.Text = serverLog.Text + DateTime.Now.ToString() + " 来自：" + senderPoint.Address + ":" + senderPoint.Port + " " + Encoding.Default.GetString(recvData) + "\r\n";
                serverLog.Text = serverLog.Text + DateTime.Now.ToString() + " 结果：" + result + "\r\n";
                udpClient.Send(sendData, sendData.Length, sendPoint);
                udpClient.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MyThread.IsBackground = true;
            if (threadStat == false)
            {
                threadStat = true;
               try{
                   MyThread.Start();
                   serverStat.Text = "运行中";
                   startServer.Text = "关闭服务";
            }catch(Exception )
                 {
                     MyThread.Resume();
                     serverStat.Text = "运行中";
                     startServer.Text = "关闭服务";
              }
               
            }
            else {
                threadStat = false;
                MyThread.Suspend();
                serverStat.Text = "关机";
                startServer.Text = "开启服务";
            }
            
        }

       
        private void serverPortBox_TextChanged(object sender, EventArgs e)
        {
            serverPort = serverPortBox.Text;
        }

        private void serverIPBox_TextChanged(object sender, EventArgs e)
        {
            serverIP = serverIPBox.Text;
        }

        //中缀转后缀表达式算法
        public static string InfixToPostfix(string expression)
        {
            Stack<char> operators = new Stack<char>();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];
                if (char.IsWhiteSpace(ch)) continue;
                switch (ch)
                {
                    case '+':
                    case '-':
                        while (operators.Count > 0)
                        {
                            char c = operators.Pop();   //pop Operator
                            if (c == '(')
                            {
                                operators.Push(c);      //push Operator
                                break;
                            }
                            else
                            {
                                result.Append(c);
                            }
                        }
                        operators.Push(ch);
                        result.Append(" ");
                        break;
                    case '*':
                    case '/':
                        while (operators.Count > 0)
                        {
                            char c = operators.Pop();
                            if (c == '(')
                            {
                                operators.Push(c);
                                break;
                            }
                            else
                            {
                                if (c == '+' || c == '-')
                                {
                                    operators.Push(c);
                                    break;
                                }
                                else
                                {
                                    result.Append(c);
                                }
                            }
                        }
                        operators.Push(ch);
                        result.Append(" ");
                        break;
                    case '(':
                        operators.Push(ch);
                        break;
                    case ')':
                        while (operators.Count > 0)
                        {
                            char c = operators.Pop();
                            if (c == '(')
                            {
                                break;
                            }
                            else
                            {
                                result.Append(c);
                            }
                        }
                        break;
                    default:
                        result.Append(ch);
                        break;
                }
            }
            while (operators.Count > 0)
            {
                result.Append(operators.Pop()); //pop All Operator
            }
            return result.ToString();
        }

        //后缀表达式求值算法（调用了中缀转后缀算法）
        public static double Parse(string expression)
        {
            string postfixExpression = InfixToPostfix(expression);
            Stack<double> results = new Stack<double>();
            double x, y;
            for (int i = 0; i < postfixExpression.Length; i++)
            {
                char ch = postfixExpression[i];
                if (char.IsWhiteSpace(ch)) continue;
                switch (ch)
                {
                    case '+':
                        y = results.Pop();
                        x = results.Pop();
                        results.Push(x + y);
                        break;
                    case '-':
                        y = results.Pop();
                        x = results.Pop();
                        results.Push(x - y);
                        break;
                    case '*':
                        y = results.Pop();
                        x = results.Pop();
                        results.Push(x * y);
                        break;
                    case '/':
                        y = results.Pop();
                        x = results.Pop();
                        results.Push(x / y);
                        break;
                    default:
                        int pos = i;
                        StringBuilder operand = new StringBuilder();
                        do
                        {
                            operand.Append(postfixExpression[pos]);
                            pos++;
                        } while (char.IsDigit(postfixExpression[pos]) || postfixExpression[pos] == '.');
                        i = --pos;
                        results.Push(double.Parse(operand.ToString()));
                        break;
                }
            }
            return results.Peek();
        }
    }
}
