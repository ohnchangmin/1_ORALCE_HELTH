using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


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
            tel.Text += "1";
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
            tel.Text += "2";
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            tel.Text += "3";
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            tel.Text += "4";
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            tel.Text += "5";
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            tel.Text += "6";
        }

        private void button_WOC11_Click_1(object sender, EventArgs e)
        {
            tel.Text += "7";
        }

    

        private void button_WOC9_Click(object sender, EventArgs e)
        {
            tel.Text += "9";
        }

        private void button_WOC8_Click(object sender, EventArgs e)
        {
            tel.Text += "0";
        }

        private void button_WOC7_Click(object sender, EventArgs e)
        {
            tel.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (getCustomer(tel.Text))
            {

                Form4 showFrom4 = new Form4();
                showFrom4.Show();
                showFrom4.label1.Text = ("000님 안녕하세요\n 000일 남았습니다\n연락처" + tel);
            }

            else
            {
                MessageBox.Show("회원이 아닙니다. 등록 먼저 해주세요", "입장", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool getCustomer(string tel)
        {
            string conStr = "Provider=OraOLEDB.Oracle.1;Data Source=XE;User ID=sqlDB;Password=1234;Unicode=True";
            OleDbConnection conn = new OleDbConnection(conStr);
            string db_tel = "";

            conn.Open();
            using (OleDbCommand command = new OleDbCommand("GetCustomerTel", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                OleDbParameter p_in = new OleDbParameter("p_in", OleDbType.VarWChar,11);
                p_in.Direction = ParameterDirection.Input;
                p_in.Value = tel;

                OleDbParameter p_out = new OleDbParameter("p_out", OleDbType.VarWChar,11);
                p_out.Direction = ParameterDirection.Output;
                p_out.Value = 0;

                command.Parameters.Add(p_in);
                command.Parameters.Add(p_out);

                command.ExecuteNonQuery();
                db_tel = p_out.Value.ToString();

                if (db_tel.Equals(tel))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        

        private void button_WOC10_Click(object sender, EventArgs e)
        {
            tel.Text += "010";
        }

        private void button_WOC67_Click(object sender, EventArgs e)
        {
            tel.Text += "8";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

