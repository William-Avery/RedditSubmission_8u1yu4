namespace Submission
{
    partial class Form1
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
            this.b_generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_employeeid = new System.Windows.Forms.TextBox();
            this.tb_fullname = new System.Windows.Forms.TextBox();
            this.tb_companyemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_supemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_generate
            // 
            this.b_generate.Location = new System.Drawing.Point(110, 138);
            this.b_generate.Name = "b_generate";
            this.b_generate.Size = new System.Drawing.Size(87, 25);
            this.b_generate.TabIndex = 0;
            this.b_generate.Text = "Generate";
            this.b_generate.UseVisualStyleBackColor = true;
            this.b_generate.Click += new System.EventHandler(this.b_generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company Email:";
            // 
            // tb_employeeid
            // 
            this.tb_employeeid.Location = new System.Drawing.Point(110, 9);
            this.tb_employeeid.Name = "tb_employeeid";
            this.tb_employeeid.Size = new System.Drawing.Size(171, 22);
            this.tb_employeeid.TabIndex = 3;
            // 
            // tb_fullname
            // 
            this.tb_fullname.Location = new System.Drawing.Point(110, 37);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(171, 22);
            this.tb_fullname.TabIndex = 4;
            // 
            // tb_companyemail
            // 
            this.tb_companyemail.Location = new System.Drawing.Point(110, 65);
            this.tb_companyemail.Name = "tb_companyemail";
            this.tb_companyemail.Size = new System.Drawing.Size(171, 22);
            this.tb_companyemail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Full Name:";
            // 
            // tb_supemail
            // 
            this.tb_supemail.Location = new System.Drawing.Point(110, 93);
            this.tb_supemail.Name = "tb_supemail";
            this.tb_supemail.Size = new System.Drawing.Size(171, 22);
            this.tb_supemail.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Supervisor Email:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 175);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_supemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_companyemail);
            this.Controls.Add(this.tb_fullname);
            this.Controls.Add(this.tb_employeeid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_generate);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_employeeid;
        private System.Windows.Forms.TextBox tb_fullname;
        private System.Windows.Forms.TextBox tb_companyemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_supemail;
        private System.Windows.Forms.Label label4;
    }
}

