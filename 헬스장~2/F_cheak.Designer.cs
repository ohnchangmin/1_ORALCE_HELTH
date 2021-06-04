
namespace 헬스장프로그램
{
    partial class F_cheak
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
            this.b_cheak = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_cheak
            // 
            this.b_cheak.Location = new System.Drawing.Point(99, 316);
            this.b_cheak.Name = "b_cheak";
            this.b_cheak.Size = new System.Drawing.Size(122, 52);
            this.b_cheak.TabIndex = 0;
            this.b_cheak.Text = "확인";
            this.b_cheak.UseVisualStyleBackColor = true;
            this.b_cheak.Click += new System.EventHandler(this.b_cheak_Click);
            // 
            // b_close
            // 
            this.b_close.Location = new System.Drawing.Point(282, 316);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(122, 52);
            this.b_close.TabIndex = 0;
            this.b_close.Text = "취소";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // F_cheak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.b_cheak);
            this.Name = "F_cheak";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_cheak;
        private System.Windows.Forms.Button b_close;
        public System.Windows.Forms.Label label1;
    }
}