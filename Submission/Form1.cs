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

            PdfWriter.GetInstance(doc, new FileStream(String.Format("C:/{0}.pdf", tb_employeeid.Text), FileMode.Create));
            doc.Open();

            Paragraph p1 = new Paragraph(String.Format("Employee ID: {0}\n   Name: {1}", tb_employeeid.Text,tb_fullname.Text));
            doc.Add(p1);
            doc.Close();
            adobebrowser.src = String.Format("C:/{0}.pdf", tb_employeeid.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
