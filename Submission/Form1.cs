using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Submission
{
    public partial class Form1 : Form
    {

        [System.Runtime.InteropServices.DllImport("shell32.dll")]
        private static extern long ShellExecute(Int32 hWnd, string lpOperation,
                                    string lpFile, string lpParameters,
                                        string lpDirectory, long nShowCmd);

        public Form1()
        {
            InitializeComponent();
        }

        private void b_generate_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            string path = String.Format("C:/{0}.pdf", tb_employeeid.Text);
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open();

            Paragraph p1 = new Paragraph(String.Format(rtb_header.Text, tb_employeeid.Text,tb_fullname.Text,tb_companyemail.Text));

            Paragraph p2 = new Paragraph(String.Format(rtb_body.Text, tb_employeeid.Text, tb_fullname.Text, tb_companyemail.Text));
            doc.Add(p1);
            doc.Add(p2);
            doc.Close();
            adobebrowser.src = path;

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = String.Format("C:/{0}.pdf", tb_employeeid.Text);
            if (File.Exists(path))
            {

                File.Delete(path);
            }
        }
    }
}
