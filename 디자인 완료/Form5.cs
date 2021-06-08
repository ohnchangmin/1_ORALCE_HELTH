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
    public partial class Form5 : Form
    {
        int i;
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i == 1) { MessageBox.Show("문자 발송", "전송"); }
            else { MessageBox.Show("조회할 이름을 선택해주세요", "오류"); }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();
            i = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.Show();
        }
    }
}
