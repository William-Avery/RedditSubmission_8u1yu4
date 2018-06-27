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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.b_generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_employeeid = new System.Windows.Forms.TextBox();
            this.tb_fullname = new System.Windows.Forms.TextBox();
            this.tb_companyemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_supemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.adobebrowser = new AxAcroPDFLib.AxAcroPDF();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtb_header = new System.Windows.Forms.RichTextBox();
            this.rtb_body = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adobebrowser)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_generate
            // 
            this.b_generate.Location = new System.Drawing.Point(6, 133);
            this.b_generate.Name = "b_generate";
            this.b_generate.Size = new System.Drawing.Size(87, 25);
            this.b_generate.TabIndex = 0;
            this.b_generate.Text = "Preview";
            this.b_generate.UseVisualStyleBackColor = true;
            this.b_generate.Click += new System.EventHandler(this.b_generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company Email:";
            // 
            // tb_employeeid
            // 
            this.tb_employeeid.Location = new System.Drawing.Point(108, 21);
            this.tb_employeeid.Name = "tb_employeeid";
            this.tb_employeeid.Size = new System.Drawing.Size(158, 22);
            this.tb_employeeid.TabIndex = 3;
            // 
            // tb_fullname
            // 
            this.tb_fullname.Location = new System.Drawing.Point(108, 49);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(158, 22);
            this.tb_fullname.TabIndex = 4;
            // 
            // tb_companyemail
            // 
            this.tb_companyemail.Location = new System.Drawing.Point(108, 77);
            this.tb_companyemail.Name = "tb_companyemail";
            this.tb_companyemail.Size = new System.Drawing.Size(158, 22);
            this.tb_companyemail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Full Name:";
            // 
            // tb_supemail
            // 
            this.tb_supemail.Location = new System.Drawing.Point(108, 105);
            this.tb_supemail.Name = "tb_supemail";
            this.tb_supemail.Size = new System.Drawing.Size(158, 22);
            this.tb_supemail.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Supervisor Email:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Email";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // adobebrowser
            // 
            this.adobebrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adobebrowser.Enabled = true;
            this.adobebrowser.Location = new System.Drawing.Point(0, 0);
            this.adobebrowser.Name = "adobebrowser";
            this.adobebrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("adobebrowser.OcxState")));
            this.adobebrowser.Size = new System.Drawing.Size(752, 632);
            this.adobebrowser.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.b_generate);
            this.groupBox2.Controls.Add(this.tb_employeeid);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_supemail);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_fullname);
            this.groupBox2.Controls.Add(this.tb_companyemail);
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 171);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Creation:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rtb_body);
            this.groupBox3.Location = new System.Drawing.Point(3, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 287);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Body:";
            // 
            // rtb_header
            // 
            this.rtb_header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_header.Location = new System.Drawing.Point(3, 18);
            this.rtb_header.Name = "rtb_header";
            this.rtb_header.Size = new System.Drawing.Size(363, 130);
            this.rtb_header.TabIndex = 1;
            this.rtb_header.Text = "Employee ID: {0}\nName: {1}\nCompany Email: {2}";
            // 
            // rtb_body
            // 
            this.rtb_body.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_body.Location = new System.Drawing.Point(3, 18);
            this.rtb_body.Name = "rtb_body";
            this.rtb_body.Size = new System.Drawing.Size(366, 266);
            this.rtb_body.TabIndex = 2;
            this.rtb_body.Text = "\nDear {1},\n\nPlease sign this letter and return in to michael at once!\n\n\nSign Here" +
    ": x_____________________\n\nThank you,\n\nTimmy Turner";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rtb_header);
            this.groupBox1.Location = new System.Drawing.Point(3, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 151);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 632);
            this.splitter1.TabIndex = 18;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.adobebrowser);
            this.splitContainer1.Size = new System.Drawing.Size(1134, 632);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "{0}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "{1}";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "{2}";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 632);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adobebrowser)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
        private AxAcroPDFLib.AxAcroPDF adobebrowser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtb_header;
        private System.Windows.Forms.RichTextBox rtb_body;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

