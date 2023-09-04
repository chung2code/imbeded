using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
       
    {
        private SerialPort serialport = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.comboBox1.Items[this.comboBox1.SelectedIndex].ToString()+" CONN");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 ON CLICKED");
            this.textBox2.Text="LED_01 ON SUCCESS";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 OFF CLICKED");
            this.textBox2.Text="LED_01 OFF SUCCESS";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 ON CLICKED");
            this.textBox2.Text="LED_02 ON SUCCESS";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 OFF CLICKED");
            this.textBox2.Text="LED_02 OFF SUCCESS";
        }

        private void connection_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Connection Clicked..");
            String port_Name = null;
            try
            {
                if (this.comboBox1.SelectedIndex > -1)
                {
                    port_Name = this.comboBox1.Items[this.comboBox1.SelectedIndex].ToString();
                    Console.WriteLine("Selected Port :" + port_Name);

                    //Serial Port 연결
                    this.serialport.PortName = port_Name;
                    this.serialport.BaudRate = 9600;
                    this.serialport.DataBits = 8;
                    this.serialport.StopBits = System.IO.Ports.StopBits.One;
                    this.serialport.Parity = System.IO.Ports.Parity.None;
                    this.serialport.Open();
                    Console.Write("Connection Success!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection ERROR : " + ex);
                this.serialport.Close();
            }
        }

        private void connection_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Connection Clicked..");
            String port_Name = null;
            try
            {
                if (this.comboBox1.SelectedIndex > -1)
                {
                    port_Name = this.comboBox1.Items[this.comboBox1.SelectedIndex].ToString();
                    Console.WriteLine("Selected Port :" + port_Name);

                    //Serial Port 연결
                    this.serialport.PortName = port_Name;
                    this.serialport.BaudRate = 9600;
                    this.serialport.DataBits = 8;
                    this.serialport.StopBits = System.IO.Ports.StopBits.One;
                    this.serialport.Parity = System.IO.Ports.Parity.None;
                    this.serialport.Open();
                    Console.Write("Connection Success!");
                    //--------------
                    //추가!
                    //--------------
                    this.serialport.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection ERROR : " + ex);
                this.serialport.Close();
            }
        }
        //--------------
        //추가
        //--------------
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String recvData = this.serialport.ReadExisting();
            Console.WriteLine(recvData);
            // UI 업데이트를 안전하게 하기 위해 Control.Invoke 사용
            this.Invoke
            (
                (MethodInvoker)delegate { this.textBox1.AppendText(recvData + "\r\n"); }
            );
            Thread.Sleep(1000); // 10ms   //데이터 잘림막기
            ;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
