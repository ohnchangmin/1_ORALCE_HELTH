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


        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 showForm7 = new Form7();
            showForm7.Show();
        }



        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 showForm3 = new Form3();
            showForm3.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 showForm3 = new Form3();
            showForm3.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 showForm3 = new Form3();
            showForm3.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("점검중 입니다", "요류");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("점검중 입니다", "요류");
        }

        private void label16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("점검중 입니다", "요류");
        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form8 showForm8 = new Form8();
            showForm8.Show();
        }



        private void label21_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form8 showForm8 = new Form8();
            showForm8.Show();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form8 showForm8 = new Form8();
            showForm8.Show();
        }



        private void label7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 showForm6 = new Form6();
            showForm6.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 showForm6 = new Form6();
            showForm6.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 showForm6 = new Form6();
            showForm6.Show();
        }

        private void pictureBox5_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("점검중 입니다", "요류");
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form8 showForm8 = new Form8();
            showForm8.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 showForm6 = new Form6();
            showForm6.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 showForm3 = new Form3();
            showForm3.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 showForm7 = new Form7();
            showForm7.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 showForm7 = new Form7();
            showForm7.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 showForm7 = new Form7();
            showForm7.Show();
        }

        private void pictureBox4_Click_2(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 showForm7 = new Form7();
            showForm7.Show();
        }
    }
}
