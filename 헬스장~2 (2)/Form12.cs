using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace 헬스장프로그램
{
    public partial class Form7 : Form
    {
        OracleConnection conn;
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("tt h:mm:ss");
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void grid(string query)
        {
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter(query, conn);
            da.Fill(ds, "CUSTOMER");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "CUSTOMER";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (name.Text != null && tel.Text != null)
            {
                string query = "SELECT * FROM CUSTOMER WHERE NAME = '" + name + "' AND TEL = '" + tel + "';";
                grid(query);
            }

            else if (name.Text != null && tel.Text == null)
            {
                string query = "SELECT * FROM CUSTOMER WHERE NAME = '" + name + "';";
                grid(query);
            }

            else if (name.Text == null && tel.Text != null)
            {
                string query = "SELECT * FROM CUSTOMER WHERE TEL = '" + tel + "';";
            }

            else
            {
                MessageBox.Show("조회할 회원을 입력하세요.", "회원조회", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
