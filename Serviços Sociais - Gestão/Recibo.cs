using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Serviços_Sociais___Gestão
{
    public partial class Recibo : Form
    {
        public Recibo()
        {
            InitializeComponent();
        }

        private void sóciosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sóciosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

        }

        private void Recibo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Comparticipacoes'. Você pode movê-la ou removê-la conforme necessário.
            this.comparticipacoesTableAdapter.Fill(this.servicos_SociaisDataSet.Comparticipacoes);
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Sócios'. Você pode movê-la ou removê-la conforme necessário.
            this.sóciosTableAdapter.Fill(this.servicos_SociaisDataSet.Sócios);
        }

        public void PreencherDadosSocio(string nomeSocio, int idSocio, string data, string serv, string nib, string referencia)
        {
            lbNome.Text = nomeSocio;
            lbNS.Text = idSocio.ToString();
            lbData.Text = data.ToString();
            lbNIB.Text = nib;
            lbMesAno.Text = referencia;
            lbServ.Text = serv;
        }

        public void PreencherComparticipacoes(DataTable registrosTransferencia)
        {
            comparticipacoesDataGridView.DataSource = registrosTransferencia;

            double totalMontante = 0;
            foreach (DataRow row in registrosTransferencia.Rows)
            {
                totalMontante += Convert.ToDouble(row["MontanteSocial"]);
            }

            txtValorTotal.Text = totalMontante.ToString("C");
        }

        private void ExportToPDF(string filePath)
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4); // Create a new PDF document

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);
                    document.Open();

                    // Capturar o formulário como imagem
                    Bitmap bitmap = CapturarFormulario();

                    // Converter a imagem para um formato que iTextSharp entende (iTextSharp.text.Image)
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(ms.ToArray());
                        pdfImage.ScaleToFit(document.PageSize.Width - 20, document.PageSize.Height - 20); // Ajusta o tamanho para caber na página
                        pdfImage.Alignment = iTextSharp.text.Element.ALIGN_CENTER;

                        document.Add(pdfImage);
                    }

                    document.Close();
                    MessageBox.Show("Recibo exportado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar PDF: " + ex.Message);
            }
        }

        public Bitmap CapturarFormulario()
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, this.Width, this.Height)); // Usar System.Drawing.Rectangle
            return bitmap;
        }

        private void btExportarPDF_Click(object sender, EventArgs e)
        {
            btExportarPDF.Visible = false;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.FileName = $"Recibo_{lbNS.Text}.pdf"; // Use ID for filename

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToPDF(filePath);
            }

            this.Close();
        }
    }
}
