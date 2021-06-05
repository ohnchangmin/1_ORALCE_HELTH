
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
            this.label2 = new System.Windows.Forms.Label();
            this.t_name = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.t_period = new System.Windows.Forms.ComboBox();
            this.t_address = new System.Windows.Forms.TextBox();
            this.man = new System.Windows.Forms.RadioButton();
            this.woman = new System.Windows.Forms.RadioButton();
            this.t_rocker = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // t_name
            // 
            this.t_name.Font = new System.Drawing.Font("굴림", 15F);
            this.t_name.Location = new System.Drawing.Point(309, 141);
            this.t_name.Margin = new System.Windows.Forms.Padding(5);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(170, 30);
            this.t_name.TabIndex = 9;
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
            this.t_period.Location = new System.Drawing.Point(309, 318);
            this.t_period.Margin = new System.Windows.Forms.Padding(5);
            this.t_period.Name = "t_period";
            this.t_period.Size = new System.Drawing.Size(276, 28);
            this.t_period.TabIndex = 13;
            this.t_period.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // t_address
            // 
            this.t_address.Location = new System.Drawing.Point(309, 414);
            this.t_address.Name = "t_address";
            this.t_address.Size = new System.Drawing.Size(276, 30);
            this.t_address.TabIndex = 22;
            // 
            // man
            // 
            this.man.AutoSize = true;
            this.man.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.man.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.man.Location = new System.Drawing.Point(313, 225);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(62, 27);
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
            this.woman.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.woman.Location = new System.Drawing.Point(405, 225);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(62, 27);
            this.woman.TabIndex = 25;
            this.woman.TabStop = true;
            this.woman.Text = "여자";
            this.woman.UseVisualStyleBackColor = true;
            this.woman.CheckedChanged += new System.EventHandler(this.woman_CheckedChanged);
            // 
            // t_rocker
            // 
            this.t_rocker.Location = new System.Drawing.Point(309, 364);
            this.t_rocker.Name = "t_rocker";
            this.t_rocker.Size = new System.Drawing.Size(276, 30);
            this.t_rocker.TabIndex = 28;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(309, 269);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 30);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Tomato;
            this.label17.Location = new System.Drawing.Point(645, 211);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(212, 25);
            this.label17.TabIndex = 44;
            this.label17.Text = "NEW REGISTRATION";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Tomato;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label18.Location = new System.Drawing.Point(692, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(179, 52);
            this.label18.TabIndex = 43;
            this.label18.Text = "신규 등록";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Tomato;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label19.Location = new System.Drawing.Point(632, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 52);
            this.label19.TabIndex = 42;
            this.label19.Text = "01";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::헬스장프로그램.Properties.Resources.홈으로_아이콘4_더작은거_;
            this.pictureBox1.Location = new System.Drawing.Point(23, 522);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 81);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(215, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 24);
            this.label11.TabIndex = 47;
            this.label11.Text = "이       름";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Tomato;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("굴림", 15F);
            this.button4.Location = new System.Drawing.Point(678, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 57);
            this.button4.TabIndex = 48;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(718, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 33);
            this.label1.TabIndex = 49;
            this.label1.Text = "신규 등록";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox1.Location = new System.Drawing.Point(309, 182);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 30);
            this.textBox1.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(216, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "연  락  처";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(215, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "성       별";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(216, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 53;
            this.label4.Text = "등록 기간";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(216, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 54;
            this.label5.Text = "등  록  일";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(215, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 24);
            this.label9.TabIndex = 55;
            this.label9.Text = "락  커  룸";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(215, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 24);
            this.label12.TabIndex = 56;
            this.label12.Text = "주       소";
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 615);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.t_rocker);
            this.Controls.Add(this.woman);
            this.Controls.Add(this.man);
            this.Controls.Add(this.t_address);
            this.Controls.Add(this.t_period);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("굴림", 15F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox t_period;
        private System.Windows.Forms.TextBox t_address;
        private System.Windows.Forms.RadioButton man;
        private System.Windows.Forms.RadioButton woman;
        private System.Windows.Forms.TextBox t_rocker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
    }
}