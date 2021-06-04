using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace 헬스장프로그램
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 showForm3 = new Form3();
            showForm3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
  
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 showForm6 = new Form6();
            showForm6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 showForm7 = new Form7();
            showForm7.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 showForm3 = new Form3();
            showForm3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 showForm6 = new Form6();
            showForm6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form8 showForm8 = new Form8();
            showForm8.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("점검중 입니다","요류");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("점검중 입니다", "요류");
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("점검중 입니다", "요류");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
   
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 showForm7 = new Form7();
            showForm7.Show();
        }
    }
}
