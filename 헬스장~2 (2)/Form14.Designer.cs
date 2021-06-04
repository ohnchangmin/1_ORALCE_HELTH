
namespace 헬스장프로그램
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_name = new System.Windows.Forms.TextBox();
            this.t_tel = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.t_period = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.t_address = new System.Windows.Forms.TextBox();
            this.man = new System.Windows.Forms.RadioButton();
            this.woman = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.t_rocker = new System.Windows.Forms.TextBox();
            this.t_day = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(238, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "이        름";
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
            this.label3.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(239, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "연  락  처";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(238, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "성        별";
            // 
            // t_name
            // 
            this.t_name.Font = new System.Drawing.Font("굴림", 15F);
            this.t_name.Location = new System.Drawing.Point(350, 127);
            this.t_name.Margin = new System.Windows.Forms.Padding(5);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(198, 30);
            this.t_name.TabIndex = 9;
            // 
            // t_tel
            // 
            this.t_tel.Font = new System.Drawing.Font("굴림", 15F);
            this.t_tel.Location = new System.Drawing.Point(350, 170);
            this.t_tel.Margin = new System.Windows.Forms.Padding(5);
            this.t_tel.Name = "t_tel";
            this.t_tel.Size = new System.Drawing.Size(198, 30);
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
            // t_period
            // 
            this.t_period.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.t_period.FormattingEnabled = true;
            this.t_period.Items.AddRange(new object[] {
            "1개월",
            "2개월",
            "3개월"});
            this.t_period.Location = new System.Drawing.Point(350, 302);
            this.t_period.Margin = new System.Windows.Forms.Padding(5);
            this.t_period.Name = "t_period";
            this.t_period.Size = new System.Drawing.Size(198, 28);
            this.t_period.TabIndex = 13;
            this.t_period.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(237, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "등록 기간";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(239, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "락  커  룸";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(238, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "주        소";
            // 
            // t_address
            // 
            this.t_address.Location = new System.Drawing.Point(350, 380);
            this.t_address.Name = "t_address";
            this.t_address.Size = new System.Drawing.Size(198, 30);
            this.t_address.TabIndex = 22;
            // 
            // man
            // 
            this.man.AutoSize = true;
            this.man.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.man.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.man.Location = new System.Drawing.Point(355, 219);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(64, 25);
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
            this.woman.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.woman.Location = new System.Drawing.Point(447, 219);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(64, 25);
            this.woman.TabIndex = 25;
            this.woman.TabStop = true;
            this.woman.Text = "여자";
            this.woman.UseVisualStyleBackColor = true;
            this.woman.CheckedChanged += new System.EventHandler(this.woman_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(240, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "등  록  일";
            // 
            // t_rocker
            // 
            this.t_rocker.Location = new System.Drawing.Point(350, 339);
            this.t_rocker.Name = "t_rocker";
            this.t_rocker.Size = new System.Drawing.Size(198, 30);
            this.t_rocker.TabIndex = 28;
            // 
            // t_day
            // 
            this.t_day.Location = new System.Drawing.Point(350, 262);
            this.t_day.Name = "t_day";
            this.t_day.Size = new System.Drawing.Size(198, 30);
            this.t_day.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(930, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "tt 00:00:00";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label17.Font = new System.Drawing.Font("나눔고딕", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.Tomato;
            this.label17.Location = new System.Drawing.Point(620, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(234, 26);
            this.label17.TabIndex = 44;
            this.label17.Text = "NEW REGISTRATION";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label18.Font = new System.Drawing.Font("나눔고딕", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.Tomato;
            this.label18.Location = new System.Drawing.Point(671, 122);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(194, 50);
            this.label18.TabIndex = 43;
            this.label18.Text = "신규 등록";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label19.Font = new System.Drawing.Font("나눔고딕", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.Tomato;
            this.label19.Location = new System.Drawing.Point(610, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 55);
            this.label19.TabIndex = 42;
            this.label19.Text = "01";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::헬스장프로그램.Properties.Resources.홈으로_아이콘4_더작은거_;
            this.pictureBox2.Location = new System.Drawing.Point(23, 533);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 56);
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(507, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 48);
            this.button1.TabIndex = 48;
            this.button1.Text = "입력완료";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 615);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.t_rocker);
            this.Controls.Add(this.t_day);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.woman);
            this.Controls.Add(this.man);
            this.Controls.Add(this.t_address);
            this.Controls.Add(this.label8);
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
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.TextBox t_tel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox t_period;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox t_address;
        private System.Windows.Forms.RadioButton man;
        private System.Windows.Forms.RadioButton woman;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox t_rocker;
        private System.Windows.Forms.TextBox t_day;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}