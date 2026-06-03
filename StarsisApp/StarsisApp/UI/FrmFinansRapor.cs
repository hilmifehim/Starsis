using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace StarsisApp.UI
{
    public partial class FrmFinansRapor : Form
    {
        public FrmFinansRapor()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(60, 99, 130); // RGB
            this.lblFinansRaporu.BackColor = Color.FromArgb(60, 99, 130); // RGB
        }
        void RaporGetir()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM vw_FinansRaporuDetay", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRapor.DataSource = dt;
            }
        }

        private void FrmFinansRapor_Load(object sender, EventArgs e)
        {
            RaporGetir();
        }

        private void picboxGuncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM vw_FinansRaporu", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRapor.DataSource = dt;
            }
        }

        private void picboxExceleAktar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Dosyası (.csv)|.csv";
            sfd.FileName = "FinansRaporu.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    // Başlıklar
                    for (int i = 0; i < dgvRapor.Columns.Count; i++)
                    {
                        sw.Write(dgvRapor.Columns[i].HeaderText);
                        if (i < dgvRapor.Columns.Count - 1)
                            sw.Write(";");
                    }
                    sw.WriteLine();

                    // Satırlar
                    foreach (DataGridViewRow row in dgvRapor.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < dgvRapor.Columns.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value?.ToString());
                                if (i < dgvRapor.Columns.Count - 1)
                                    sw.Write(";");
                            }
                            sw.WriteLine();
                        }
                    }
                }

                MessageBox.Show("Excel dosyası oluşturuldu");
            }
        }

        private void picboxPdfeDonustur_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Dosyası (.pdf)|.pdf";
            sfd.FileName = "FinansRaporu.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                doc.Open();

                // Başlık
                Paragraph baslik = new Paragraph(
                    "FİNANS RAPORU\n\n",
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)
                );
                baslik.Alignment = Element.ALIGN_CENTER;
                doc.Add(baslik);

                // Tablo
                PdfPTable table = new PdfPTable(dgvRapor.Columns.Count);
                table.WidthPercentage = 100;

                // Kolon başlıkları
                foreach (DataGridViewColumn col in dgvRapor.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    table.AddCell(cell);
                }

                // Satırlar
                foreach (DataGridViewRow row in dgvRapor.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(cell.Value?.ToString());
                        }
                    }
                }

                doc.Add(table);
                doc.Close();

                MessageBox.Show("PDF başarıyla oluşturuldu");
            }
        }

        private void picboxAnaMenuDon_Click(object sender, EventArgs e)
        {
            FrmFinansSecim frmFinansSecim = new FrmFinansSecim();
            frmFinansSecim.Show();
            this.Hide();
        }
    }
}
