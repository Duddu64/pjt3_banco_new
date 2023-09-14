using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Forms;
using Spire.Pdf;
using Spire.Pdf.Graphics;

namespace exemplo_treino
{
    public partial class FormRelatorio : MaterialForm
    {
        string cs = @"server=localhost;" +
                   "uid=root;" +
                   "pwd=;" +
                   "database=academico";
        public FormRelatorio()
        {
            InitializeComponent();
            CarregaImpressora();
        }

        private void MontaRelatorio()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM aluno WHERE 1=1";
            if (materialComboBox1.Text != "")
                sql += " and estado = @estado";
            if (textbox.Text != "")
                sql += "and cidade = @cidade";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            if (materialComboBox1.Text != "")
                sqlAd.SelectCommand.Parameters.AddWithValue("@cidade", textbox.Text);
            if (textbox.Text != "")
                sqlAd.SelectCommand.Parameters.AddWithValue("@cidade", materialComboBox1.Text);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            con.Close();
            PdfDocument doc = new PdfDocument();
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();
            float y = 20;
            PdfBrush brush1 = PdfBrushes.Black;
            PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 16f, FontStyle.Bold));
            PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);
            page.Canvas.DrawString("Relatório de Alunos", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);

            doc.SaveToFile("RelatorioAlunos.pdf");

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarregaImpressora()
        {
            foreach(string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                materialComboBox3.Items.Add(printer);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            MontaRelatorio();
        }
    }
}
