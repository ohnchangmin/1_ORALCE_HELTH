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

namespace 헬스장프로그램
{
    public partial class Form3 : Form
    {
        private string gender;
        public Form3()
        {
            InitializeComponent();
        }


        private void man_CheckedChanged(object sender, EventArgs e)
        {
            gender = "남자";
        }

        private void woman_CheckedChanged(object sender, EventArgs e)
        {
            gender = "여자";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToString("tt h:mm:ss");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
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





        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(name.Text == "" || tel.Text == "" || address.Text == "" || gender == "" || rocker.Text == "" || dateTimePicker1.Text == "" || period.Text == "")
            {
                MessageBox.Show("데이터를 모두 입력해주세요.", "회원등록", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (gender == "남자")
                {
                    string query = "INSERT INTO CUSTOMER VALUES('" + name.Text + "', '" + tel.Text + "', '남', '" + address.Text + "', " + rocker.Text + ", TO_DATE('" + dateTimePicker1.Text + "', 'YYYY-MM-DD'), NULL, " + period.Text + ")";
                    insert_date(query);
                    MessageBox.Show("정상적으로 등록되었습니다.", "회원등록", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (gender == "여자")
                {
                    string query = "INSERT INTO CUSTOMER VALUES('" + name.Text + "', '" + tel.Text + "', '여', '" + address.Text + "', " + rocker.Text + ", TO_DATE('" + dateTimePicker1.Text + "', 'YYYY-MM-DD'), NULL, " + period.Text + ")";
                    insert_date(query);
                    MessageBox.Show("정상적으로 등록되었습니다.", "회원등록", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
           
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                rocker.Enabled = false;
                rocker.Text = "NULL";

            }
            else
            {
                rocker.Enabled = true;
            }
        }
    }
}
