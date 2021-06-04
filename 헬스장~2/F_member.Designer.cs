
namespace 헬스장프로그램
{
    partial class F_member
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_name = new System.Windows.Forms.TextBox();
            this.t_tel = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.t_period = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.b_finish = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.t_address = new System.Windows.Forms.TextBox();
            this.man = new System.Windows.Forms.RadioButton();
            this.woman = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.t_rocker = new System.Windows.Forms.TextBox();
            this.t_day = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(38, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "성    명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(19, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(38, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "연락처";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15F);
            this.label4.Location = new System.Drawing.Point(38, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "성    별";
            // 
            // t_name
            // 
            this.t_name.Font = new System.Drawing.Font("굴림", 15F);
            this.t_name.Location = new System.Drawing.Point(159, 137);
            this.t_name.Margin = new System.Windows.Forms.Padding(5);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(276, 30);
            this.t_name.TabIndex = 9;
            // 
            // t_tel
            // 
            this.t_tel.Font = new System.Drawing.Font("굴림", 15F);
            this.t_tel.Location = new System.Drawing.Point(159, 208);
            this.t_tel.Margin = new System.Windows.Forms.Padding(5);
            this.t_tel.Name = "t_tel";
            this.t_tel.Size = new System.Drawing.Size(276, 30);
            this.t_tel.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 15F);
            this.button3.Location = new System.Drawing.Point(280, 752);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(435, 152);
            this.button3.TabIndex = 12;
            this.button3.Text = "가입  완료";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // t_period
            // 
            this.t_period.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.t_period.FormattingEnabled = true;
            this.t_period.Items.AddRange(new object[] {
            "1개월",
            "2개월",
            "3개월"});
            this.t_period.Location = new System.Drawing.Point(159, 328);
            this.t_period.Margin = new System.Windows.Forms.Padding(5);
            this.t_period.Name = "t_period";
            this.t_period.Size = new System.Drawing.Size(276, 28);
            this.t_period.TabIndex = 13;
            this.t_period.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "등록 기간";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "라커룸";
            // 
            // b_finish
            // 
            this.b_finish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_finish.Location = new System.Drawing.Point(896, 502);
            this.b_finish.Name = "b_finish";
            this.b_finish.Size = new System.Drawing.Size(152, 101);
            this.b_finish.TabIndex = 18;
            this.b_finish.Text = "가입 완료";
            this.b_finish.UseVisualStyleBackColor = true;
            this.b_finish.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(38, 22);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 46);
            this.button7.TabIndex = 19;
            this.button7.Text = "이전화면";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 60F);
            this.label7.Location = new System.Drawing.Point(225, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(541, 80);
            this.label7.TabIndex = 20;
            this.label7.Text = "신규 회원등록";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "주소";
            // 
            // t_address
            // 
            this.t_address.Location = new System.Drawing.Point(159, 496);
            this.t_address.Name = "t_address";
            this.t_address.Size = new System.Drawing.Size(276, 30);
            this.t_address.TabIndex = 22;
            // 
            // man
            // 
            this.man.AutoSize = true;
            this.man.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.man.Location = new System.Drawing.Point(159, 269);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(67, 24);
            this.man.TabIndex = 24;
            this.man.TabStop = true;
            this.man.Text = "남자";
            this.man.UseVisualStyleBackColor = true;
            this.man.CheckedChanged += new System.EventHandler(this.man_CheckedChanged);
            // 
            // woman
            // 
            this.woman.AutoSize = true;
            this.woman.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.woman.Location = new System.Drawing.Point(251, 271);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(67, 24);
            this.woman.TabIndex = 25;
            this.woman.TabStop = true;
            this.woman.Text = "여자";
            this.woman.UseVisualStyleBackColor = true;
            this.woman.CheckedChanged += new System.EventHandler(this.woman_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "등록일";
            // 
            // t_rocker
            // 
            this.t_rocker.Location = new System.Drawing.Point(159, 426);
            this.t_rocker.Name = "t_rocker";
            this.t_rocker.Size = new System.Drawing.Size(276, 30);
            this.t_rocker.TabIndex = 28;
            // 
            // t_day
            // 
            this.t_day.Location = new System.Drawing.Point(159, 379);
            this.t_day.Name = "t_day";
            this.t_day.Size = new System.Drawing.Size(276, 30);
            this.t_day.TabIndex = 27;
            // 
            // F_member
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 615);
            this.Controls.Add(this.t_rocker);
            this.Controls.Add(this.t_day);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.woman);
            this.Controls.Add(this.man);
            this.Controls.Add(this.t_address);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.b_finish);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t_period);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.t_tel);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("굴림", 15F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "F_member";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.TextBox t_tel;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox t_period;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_finish;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox t_address;
        private System.Windows.Forms.RadioButton man;
        private System.Windows.Forms.RadioButton woman;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox t_rocker;
        private System.Windows.Forms.TextBox t_day;
    }
}