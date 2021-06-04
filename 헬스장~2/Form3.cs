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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private string gender;
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            String name = Convert.ToString(t_name.Text);
            String address = Convert.ToString(t_address.Text);
            String tel = Convert.ToString(t_tel.Text);
            String period = Convert.ToString(t_period.Text);
            String day = Convert.ToString(t_day.Text);
            String rocker = Convert.ToString(t_rocker.Text);

            Form9 showFrom9 = new Form9();
            showFrom9.Show();

            showFrom9.label1.Text = ("이름: " + name + "\n" +
                                     "성별: " + gender + "\n" +
                                     "주소: " + address + "\n" +
                                     "연락처: " + tel + "\n" +
                                     "등록 기간: " + period + "\n" +
                                     "등록일: " + day + "\n" +
                                     "락커룸: " + rocker + "\n");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void man_CheckedChanged(object sender, EventArgs e)
        {
            gender = "남자";
        }

        private void woman_CheckedChanged(object sender, EventArgs e)
        {
            gender = "여자";
        }
    }
}
