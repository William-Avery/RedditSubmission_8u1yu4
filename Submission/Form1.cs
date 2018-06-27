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
        public Form1()
        {
            InitializeComponent();
        }

        private void b_generate_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            PdfWriter.GetInstance(doc, new FileStream(String.Format("C:/{0}.pdf", tb_employeeid.Text), FileMode.Create));
            doc.Open();

            Paragraph p1 = new Paragraph(String.Format("Employee ID: {0}",tb_employeeid.Text));
            doc.Add(p1);
            doc.Close();
            MessageBox.Show("");


        }
    }
}
