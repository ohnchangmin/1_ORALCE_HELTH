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
    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
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
            string conStr = "Data Source=XE; User ID=HEALTH; Password=1234;";
            OracleConnection conn = new OracleConnection(conStr);
            conn.Open();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter(query, conn);
            da.Fill(ds);

           dataGridView1.DataSource = ds.Tables[0];
    
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (name.Text != "" && tel.Text != "")
            {
                string query = "SELECT * FROM CUSTOMER WHERE NAME = '" + name.Text + "' AND TEL = '" + tel.Text + "'";
                grid(query);
            }

            else if (name.Text != "" && tel.Text == "")
            {
                string query = "SELECT * FROM CUSTOMER WHERE NAME = '" + name.Text + "'";
                grid(query);
            }

            else if (name.Text == "" && tel.Text != "")
            {

                string query = "SELECT * FROM CUSTOMER WHERE TEL = '" + tel.Text + "'";
                grid(query);
            }

            else
            {
                MessageBox.Show("조회할 회원을 입력하세요.", "회원조회", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM V_INBODY WHERE NAME = '" + name.Text + "'AND TEL = '" + tel.Text + "'";
            grid(query);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM V_INBODY";
            grid(query);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
