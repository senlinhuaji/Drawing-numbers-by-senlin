using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 抽号数.NET_4._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string get_random_num(int s, int e)
        {
            Random Ra = new Random();
            int num = Ra.Next(s, e);
            return num.ToString();
        }

        public int start_num;
        public int end_num;

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public int flag = 0;

        private async void button1_Click(object sender, EventArgs e)
        {
            if (start_num > end_num)
            {
                MessageBox.Show("minimal must be smaller than maximum");
                return;
            }
            else
            {
                if (flag == 0) button1.Text = "停!";
                else button1.Text = "抽!";
                flag = flag ^ 1;
                int wait_time = 20;
                while (Convert.ToBoolean(flag))
                {
                    await Task.Delay(wait_time);
                    num.Text = get_random_num(start_num, end_num);
                }
                //label5.Text = " ";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(input_start.Text, out int num))
            {
                if (num > 32768)
                {
                    MessageBox.Show("input is too large");
                }
                else start_num = num;
            }
            else if (!string.IsNullOrEmpty(input_start.Text))
            {
                MessageBox.Show("input must be an integer");
            }
            //MessageBox.Show(Convert.ToString(start_num));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(input_end.Text, out int num))
            {
                if (num > 32768)
                {
                    MessageBox.Show("input is too large");
                }
                else end_num = num;
            }
            else if (!string.IsNullOrEmpty(input_end.Text))
            {
                MessageBox.Show("input must be an integer");
            }
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
