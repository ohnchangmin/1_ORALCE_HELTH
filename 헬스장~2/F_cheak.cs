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
    public partial class F_cheak : Form
    {
        public F_cheak()
        {
            InitializeComponent();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F_member showForm3 = new F_member();
            showForm3.Show();
        }

        private void b_cheak_Click(object sender, EventArgs e)
        {
            MessageBox.Show("축하드립니다.", "환영");
            this.Visible = false;
            F_main Fmain = new F_main();
            Fmain.Show();
        }
    }
}
