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
    public partial class Form8 : Form
    {
        public Form8()
        {   
            InitializeComponent();

            pictureBox1.BackColor = Color.Transparent;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.Show();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("tt h:mm:ss");
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.Show();
        }

        private void insert_date(string query)
        {
            string conStr = "Data Source=XE; User ID=HEALTH; Password=1234;";
            OracleConnection conn = new OracleConnection(conStr);
            conn.Open();
            OracleCommand comm = new OracleCommand(query, conn);
            comm.CommandType = CommandType.Text;

            comm.ExecuteNonQuery();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || tel.Text == "" || during.Text == "")
            {
                MessageBox.Show("값을 제대로 입력해주세요.", "기간연장", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "UPDATE CUSTOMER SET DURING = DURING + " + during.Text + " WHERE NAME = '" + name.Text + "'AND TEL = '" + tel.Text + "'";
                insert_date(query);
                MessageBox.Show("정상적으로 연장되었습니다.", "기간연장", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
