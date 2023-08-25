using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
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

       
    }
}
