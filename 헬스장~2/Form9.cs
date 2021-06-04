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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("축하드립니다", "환영");
            Application.OpenForms["Form3"].Close();
            this.Visible = false;
            Form1 showForm1 = new Form1();

            

            showForm1.Show();
                        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
