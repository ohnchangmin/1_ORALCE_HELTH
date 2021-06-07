using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 헬스장프로그램
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.Show();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "1";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            label3.Text = DateTime.Now.ToString("tt h:mm:ss");
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.Show();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "2";
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "3";
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "4";
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "5";
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "6";
        }

        private void button_WOC11_Click_1(object sender, EventArgs e)
        {
            bt_cheak.Text += "7";
        }

        private void button_WOC10_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "8";
        }

        private void button_WOC9_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "9";
        }

        private void button_WOC8_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "0";
        }

        private void button_WOC7_Click(object sender, EventArgs e)
        {
            bt_cheak.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String tel = Convert.ToString(bt_cheak.Text);
            Form4 showFrom4 = new Form4();
            showFrom4.Show();
            showFrom4.label1.Text = ("000님 안녕하세요\n 000일 남았습니다\n연락처" + tel);
        }
    }
}
