using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Forms;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using Spire.Pdf;

namespace exemplo_treino
{
    public partial class FormRelatorioProfessor : MaterialForm
    {
        string cs = @"server=localhost;" +
                   "uid=root;" +
                   "pwd=;" +
                   "database=academico";
        PdfDocument doc = new PdfDocument();
        public FormRelatorioProfessor()
        {
            InitializeComponent();
            CarregaImpressora();
        }

        private void MontaRelatorio()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM professor WHERE 1=1";

            if (materialComboBox1.Text != "")
                sql += " and estado = @estado";


            if (textbox.Text != "")
                sql += " and cidade = @cidade";


            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            if (textbox.Text != "")
                sqlAd.SelectCommand.Parameters.AddWithValue("@cidade", textbox.Text);
            if (materialComboBox1.Text != "")
                sqlAd.SelectCommand.Parameters.AddWithValue("@estado", materialComboBox1.Text);

            var dt = new DataTable();
            sqlAd.Fill(dt);
            
            con.Close();
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();
            int y = 20;
            PdfBrush brush1 = PdfBrushes.Black;
            PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 16f, FontStyle.Bold));
            PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);
            page.Canvas.DrawString("Relatório de Professores", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);

            PdfTable table = new PdfTable();
            table.Style.CellPadding = 2;
            table.Style.BorderPen = new PdfPen(brush1, 0.75f);
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;
            table.Style.ShowHeader = true;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.DarkOrange;
            table.DataSource = dt;
            foreach (PdfColumn col in table.Columns)
            {
                col.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }
            table.Draw(page, new Point(0, y + 30));

            doc.SaveToFile("RelatorioProfessores.pdf");

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarregaImpressora()
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                materialComboBox3.Items.Add(printer);
            }
        }

        private void SendToPrinter()
        {

            doc.PrintSettings.PrinterName = materialComboBox3.Text;
            doc.PrintSettings.Copies = 1;
            doc.Print();

        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            if (materialComboBox3.Text == "")
            {
                MessageBox.Show("Selecione alguma impressora !!!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MontaRelatorio();
                SendToPrinter();
            }
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            MontaRelatorio();
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"RelatorioProfessores.pdf")
            {
                UseShellExecute = true,
            };

            p.Start();
        }
    }
}
