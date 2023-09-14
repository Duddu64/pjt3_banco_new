using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Forms;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using System.Drawing.Printing;
using System.Reflection.Metadata;

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
            if (textbox.Text != "")
                sqlAd.SelectCommand.Parameters.AddWithValue("@cidade", textbox.Text);
            if (materialComboBox1.Text != "")
                sqlAd.SelectCommand.Parameters.AddWithValue("@estado", materialComboBox1.Text);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            con.Close();
            PdfDocument doc = new PdfDocument();
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();
            int y = 20;
            PdfBrush brush1 = PdfBrushes.Black;
            PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 16f, FontStyle.Bold));
            PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);
            page.Canvas.DrawString("Relatório de Alunos", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);

            PdfTable table = new PdfTable();
            table.Style.CellPadding = 2;
            table.Style.BorderPen = new PdfPen(brush1, 0.75f);
            table.Style.HeaderStyle.StringFormat= new PdfStringFormat(PdfTextAlignment.Center);
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;
            table.Style.ShowHeader=true;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.DarkOrange;
            table.DataSource = dt;
            foreach(PdfColumn col in table.Columns)
            {
                col.StringFormat=new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }
            table.Draw(page, new Point(0, y+30));

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

        private void SendToPrinter()
        {
            
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            MontaRelatorio();
            SendToPrinter();

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            MontaRelatorio();
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"RelatorioAlunos.pdf")
            {
                UseShellExecute = true,    
            };

            p.Start();
        }
    }
}
