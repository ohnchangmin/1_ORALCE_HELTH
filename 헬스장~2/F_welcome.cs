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
    public partial class F_welcome : Form
    {
        public F_welcome()
        {
            InitializeComponent();
        }

        private void button_WOC11_Click(object sender, EventArgs e)
        {
            bt_cheak.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_main showForm1 = new F_main();
            showForm1.Show();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            bt_cheak.Text += "0";
        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {

            
        }

        private void b_cheak_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label3.Text = DateTime.Now.ToString("tt h:mm:ss");
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
