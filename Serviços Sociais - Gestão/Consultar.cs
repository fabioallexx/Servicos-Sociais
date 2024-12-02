using Org.BouncyCastle.Pqc.Crypto.Lms;
using Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serviços_Sociais___Gestão
{
    public partial class Consultar : Form
    {
        Form form;
        private const int tamanhoIban = 26;
        private const int tamanhoSwift = 9;
        private const int tamanhoValor = 10;
        private DataTable sociosTable;
        private int linha = -1;
        private string IDSocioAtual;
        private double totalAnualCache = 0;
        private Dictionary<int, double> totalAnualPorAno = new Dictionary<int, double>();

        string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

        public Consultar(Form f)
        {
            InitializeComponent();
            CarregarDados();
            form = f;
            sociosTable = servicos_SociaisDataSet.Sócios.Copy();
        }

        private void LimparCampos()
        {
            txtDadosS.Text = "";
            txtDadosDN.Text = "";
            txtDadosEC.Text = "";
            txtDadosMor.Text = "";
            txtDadosCP.Text = "";
            txtDadosTel.Text = "";
            txtDadosSS.Text = "";
            txtDadosNSS.Text = "";
            txtDadosNISS.Text = "";
            txtDadosIBAN.Text = "";
            txtDadosBIC.Text = "";
            txtDadosNIF.Text = "";
            txtDadosFunc.Text = "";
            txtDadosServ.Text = "";
            txtDadosNC.Text = "";
            txtDadosND.Text = "";
        }

        private void CarregarDados()
        {
            comparticipacoesTableAdapter.Fill(servicos_SociaisDataSet.Comparticipacoes);
            sóciosTableAdapter.Fill(servicos_SociaisDataSet.Sócios);
            MessageBox.Show($"Total de comparticipações carregadas: {servicos_SociaisDataSet.Comparticipacoes.Rows.Count}");
        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                FileName = "dados.txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportarTxT(filePath);
            }
        }

        private void ExportarTxT(string filePath)
        {
            if (cbDadosMes.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum mês selecionado para exportação!", "Atenção");
                return;
            }

            int mesIndex = cbDadosMes.SelectedIndex + 1;
            int anoAtual = dateTimePickerAno.Value.Year;

            DateTime inicioData = new DateTime(anoAtual, mesIndex, 1);
            DateTime fimData = inicioData.AddMonths(1);

            string filtro = $"Data >= #{inicioData.ToString("MM/dd/yyyy")}# AND Data < #{fimData.ToString("MM/dd/yyyy")}# AND Pagamento = 'Transferência'";

            var montantesPorSocio = new Dictionary<string, (string Nome, string Iban, string Swift, decimal TotalMontante)>();

            foreach (DataRow row in servicos_SociaisDataSet.Comparticipacoes.Select(filtro))
            {
                string idSocio = row["IDSocio"].ToString();

                DataRow socioRow = servicos_SociaisDataSet.Sócios.Select($"IDSocio = '{idSocio}'").FirstOrDefault();
                if (socioRow != null)
                {
                    string nome = socioRow["Nome"].ToString();
                    string iban = socioRow["IBAN"].ToString();
                    string swift = socioRow["BIC"].ToString();
                    decimal montante = Convert.ToDecimal(row["MontanteSocial"]);

                    if (montantesPorSocio.ContainsKey(idSocio))
                    {
                        var existingEntry = montantesPorSocio[idSocio];
                        montantesPorSocio[idSocio] = (existingEntry.Nome, existingEntry.Iban, existingEntry.Swift, existingEntry.TotalMontante + montante);
                    }
                    else
                    {
                        montantesPorSocio[idSocio] = (nome, iban, swift, montante);
                    }
                }
            }

            if (montantesPorSocio.Count == 0)
            {
                MessageBox.Show("Nenhuma comparticipação encontrada para o mês e ano selecionados com pagamento por transferência.", "Informação");
                return;
            }

            var montantesOrdenados = montantesPorSocio.Values
                .OrderBy(s => s.Iban)
                .ThenBy(s => s.Swift)
                .ToList();

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"{"IBAN".PadRight(tamanhoIban)}{"SWIFT".PadRight(tamanhoSwift)}{"MONTANTE".PadRight(tamanhoValor)}{"NOME"}");
                writer.WriteLine();

                foreach (var item in montantesOrdenados)
                {
                    string montanteFormatado = $"{item.TotalMontante:F2}".PadRight(tamanhoValor);
                    writer.WriteLine($"{item.Iban.PadRight(tamanhoIban)}{item.Swift.PadRight(tamanhoSwift)}{montanteFormatado}{item.Nome}");
                    writer.WriteLine();
                }
            }

            MessageBox.Show("Arquivo salvo com sucesso!");
        }

        private void sóciosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sóciosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'servicos_Sociais_InativosDataSet.SóciosInativos'. Você pode movê-la ou removê-la conforme necessário.
            this.sóciosInativosTableAdapter.Fill(this.servicos_Sociais_InativosDataSet.SóciosInativos);
            // TODO: esta linha de código carrega dados na tabela 'servicos_Sociais_InativosDataSet.DescendentesInativos'. Você pode movê-la ou removê-la conforme necessário.
            this.descendentesInativosTableAdapter.Fill(this.servicos_Sociais_InativosDataSet.DescendentesInativos);
            // TODO: esta linha de código carrega dados na tabela 'servicos_Sociais_InativosDataSet.ConjugeInativo'. Você pode movê-la ou removê-la conforme necessário.
            this.conjugeInativoTableAdapter.Fill(this.servicos_Sociais_InativosDataSet.ConjugeInativo);
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Serviço'. Você pode movê-la ou removê-la conforme necessário.
            this.serviçoTableAdapter.Fill(this.servicos_SociaisDataSet.Serviço);
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.EstadoCivil'. Você pode movê-la ou removê-la conforme necessário.
            this.estadoCivilTableAdapter.Fill(this.servicos_SociaisDataSet.EstadoCivil);
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.SistemaSaude'. Você pode movê-la ou removê-la conforme necessário.
            this.sistemaSaudeTableAdapter.Fill(this.servicos_SociaisDataSet.SistemaSaude);
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Comparticipacoes'. Você pode movê-la ou removê-la conforme necessário.
            this.comparticipacoesTableAdapter.Fill(this.servicos_SociaisDataSet.Comparticipacoes);
            this.assistenciasTableAdapter.Fill(this.servicos_SociaisDataSet.Assistencias);
            this.descendentesTableAdapter.Fill(this.servicos_SociaisDataSet.Descendentes);
            this.conjugeTableAdapter.Fill(this.servicos_SociaisDataSet.Conjuge);
            this.comparticipacoesTableAdapter.Fill(this.servicos_SociaisDataSet.Comparticipacoes);
            this.sóciosTableAdapter.Fill(this.servicos_SociaisDataSet.Sócios);

            comparticipacoesDataGridView.DataSource = null;

            cbPesqN.DataSource = sociosTable;
            cbPesqN.DisplayMember = "Nome";
            cbPesqN.ValueMember = "Nome";
            cbPesqN.SelectedIndex = -1;

            cbPesqNIF.DataSource = sociosTable;
            cbPesqNIF.DisplayMember = "NIF";
            cbPesqNIF.ValueMember = "NIF";
            cbPesqNIF.SelectedIndex = -1;

            cbPesqID.DataSource = sociosTable;
            cbPesqID.DisplayMember = "IDSocio";
            cbPesqID.ValueMember = "IDSocio";
            cbPesqID.SelectedIndex = -1;

            for (int i = 0; i <= 11; i++)
            {
                cbDadosMes.Items.Add(meses[i]);
            }

            dateTimePickerAno.Format = DateTimePickerFormat.Custom;
            dateTimePickerAno.CustomFormat = "yyyy";

            dateTimePickerAno.ShowUpDown = true;

            cbDadosServ.DataSource = serviçoBindingSource;
            cbDadosServ.DisplayMember = "Serviço";
            cbDadosServ.ValueMember = "Serviço";
            cbDadosServ.SelectedIndex = -1;

            cbDadosEC.DataSource = estadoCivilBindingSource;
            cbDadosEC.DisplayMember = "EstadoCivil";
            cbDadosEC.ValueMember = "EstadoCivil";
            cbDadosEC.SelectedIndex = -1;

            cbDadosSS.DataSource = sistemaSaudeBindingSource;
            cbDadosSS.DisplayMember = "SistemaSaude";
            cbDadosSS.ValueMember = "SistemaSaude";
            cbDadosSS.SelectedIndex = -1;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            form.Controls["panel1"].Controls.Clear();
            form.Controls["panel1"].Visible = false;
            form.Controls["btRegistar"].Visible = true;
            form.Controls["btRegComp"].Visible = true;
            form.Controls["btConsultar"].Visible = true;
            form.Controls["pbLogo"].Visible = true;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                sóciosBindingSource.RemoveFilter();
                string filtro = "";
                bool filtroN = !string.IsNullOrEmpty(cbPesqN.Text);
                bool filtroNIF = !string.IsNullOrEmpty(cbPesqNIF.Text);
                bool filtroID = !string.IsNullOrEmpty(cbPesqID.Text);

                if (filtroID)
                {
                    filtro = $"IDSocio = '{cbPesqID.Text.Trim()}'";
                }
                else if (filtroN)
                {
                    filtro = $"Nome LIKE '%{cbPesqN.Text.Trim()}%'";
                }
                else if (filtroNIF)
                {
                    filtro = $"NIF LIKE '%{cbPesqNIF.Text.Trim()}%'";
                }

                if (string.IsNullOrEmpty(filtro))
                {
                    MessageBox.Show("Insira pelo menos um critério de pesquisa!", "Informação");
                    return;
                }

                sóciosBindingSource.Filter = filtro;

                if (sóciosBindingSource.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Informação");
                    LimparCampos();
                    return;
                }

                DataRowView rowView = (DataRowView)sóciosBindingSource.Current;
                PreencherCampos(rowView);

                IDSocioAtual = rowView["IDSocio"].ToString();
                MessageBox.Show($"ID do Sócio: {IDSocioAtual}");

                comparticipacoesBindingSource.Filter = $"IDSocio = '{IDSocioAtual}'";

                cbDadosMes.SelectedIndex = -1;

                CalcularTotalAnual();
                MostrarTudo();
                btAtualizar.Visible = true;
                btRecibo.Visible = true;
                btAdicionarDesc.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Informação");
            }
        }

        private void PreencherCampos(DataRowView rowView)
        {
            DataRow row = rowView.Row;
            txtDadosS.Text = row["Nome"].ToString();
            txtDadosDN.Text = row["DNasc"].ToString();
            txtDadosEC.Text = row["EstadoCivil"].ToString();
            txtDadosMor.Text = row["Morada"].ToString();
            txtDadosCP.Text = row["CodPostal"].ToString();
            txtDadosTel.Text = row["Telefone"].ToString();
            txtDadosSS.Text = row["SistemaSaude"].ToString();
            txtDadosNSS.Text = row["NSS"].ToString();
            txtDadosNISS.Text = row["NISS"].ToString();
            txtDadosIBAN.Text = row["IBAN"].ToString();
            txtDadosBIC.Text = row["BIC"].ToString();
            txtDadosNIF.Text = row["NIF"].ToString();
            txtDadosFunc.Text = row["NFunc"].ToString();
            txtDadosServ.Text = row["Serviço"].ToString();

            string idSocio = row["IDSocio"].ToString();
            var conjRow = servicos_SociaisDataSet.Conjuge.Select($"IDSocio = '{idSocio}'").FirstOrDefault();
            var descRow = servicos_SociaisDataSet.Descendentes.Select($"IDSocio = '{idSocio}'").FirstOrDefault();

            if (conjRow != null)
            {
                txtDadosNC.Text = conjRow["Nome"].ToString();
                txtDadosDNC.Text = conjRow["DNasc"].ToString();
                txtDadosADSEC.Text = conjRow["ADSE"].ToString();
            }
            else
            {
                txtDadosNC.Text = "Nenhum cônjuge encontrado";
            }

            if (descRow != null)
            {
                txtDadosND.Text = descRow["Nome"].ToString();
                txtDadosDND.Text = descRow["DNasc"].ToString();
                txtDadosADSED.Text = descRow["ADSE"].ToString();
            }
            else
            {
                txtDadosND.Text = "Nenhum descendente encontrado";
            }
        }

        private List<DataRow> descendentesList = new List<DataRow>();
        private int currentDescendenteIndex = -1;

        private void btDadosSeg_Click(object sender, EventArgs e)
        {
            DataRowView rowView = (DataRowView)sóciosBindingSource.Current;
            DataRow row = rowView.Row;
            string idSocio = row["IDSocio"].ToString();

            descendentesBindingSource.Filter = $"IDSocio = '{idSocio}'";
            descendentesList.Clear();

            foreach (DataRowView dv in descendentesBindingSource)
            {
                descendentesList.Add(dv.Row);
            }

            if (descendentesList.Count > 0)
            {
                currentDescendenteIndex++;

                if (currentDescendenteIndex < descendentesList.Count)
                {
                    MostrarDescendente(currentDescendenteIndex);
                }

                btAnterior.Visible = currentDescendenteIndex > 0;
                btDadosSeg.Visible = currentDescendenteIndex < descendentesList.Count - 1;
            }
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            if (currentDescendenteIndex > 0)
            {
                currentDescendenteIndex--;
                MostrarDescendente(currentDescendenteIndex);
            }

            btAnterior.Visible = currentDescendenteIndex > 0;
            btDadosSeg.Visible = currentDescendenteIndex < descendentesList.Count - 1;
        }

        private void MostrarDescendente(int index)
        {
            if (index >= 0 && index < descendentesList.Count)
            {
                DataRow rowDesc = descendentesList[index];

                txtDadosND.Text = rowDesc["Nome"].ToString();
                txtDadosDND.Text = rowDesc["DNasc"].ToString();
                txtDadosADSED.Text = rowDesc["ADSE"].ToString();
            }

            btAnterior.Visible = index > 0;
            btDadosSeg.Visible = index < descendentesList.Count - 1;
        }

        private void CalcularTotalAnual()
        {
            if (!string.IsNullOrEmpty(IDSocioAtual))
            {
                int anoSelecionado = dateTimePickerAno.Value.Year;

                if (totalAnualPorAno.ContainsKey(anoSelecionado))
                {
                    totalAnualCache = totalAnualPorAno[anoSelecionado];
                    txtTA.Text = totalAnualCache > 0 ? totalAnualCache.ToString("C") : "0 €";
                    return;
                }

                DateTime inicioAno = new DateTime(anoSelecionado, 1, 1);
                DateTime fimAno = new DateTime(anoSelecionado + 1, 1, 1);

                double totalAno = 0;

                foreach (DataRow row in servicos_SociaisDataSet.Comparticipacoes.Rows)
                {
                    if (row["IDSocio"].ToString() == IDSocioAtual)
                    {
                        DateTime data = Convert.ToDateTime(row["Data"]);
                        if (data >= inicioAno && data < fimAno)
                        {
                            if (double.TryParse(row["MontanteSocial"].ToString(), out double montante))
                            {
                                totalAno += montante;
                            }
                        }
                    }
                }

                totalAnualPorAno[anoSelecionado] = totalAno;
                totalAnualCache = totalAno;

                txtTA.Text = totalAnualCache > 0 ? totalAnualCache.ToString("C") : "0 €";
            }
            else
            {
                txtTA.Text = "0 €";
            }
        }

        private void CalcularTotalMensal()
        {
            if (!string.IsNullOrEmpty(IDSocioAtual))
            {
                if (cbDadosMes.SelectedIndex != -1)
                {
                    int mesSelecionado = cbDadosMes.SelectedIndex + 1;
                    int anoSelecionado = dateTimePickerAno.Value.Year;

                    DateTime inicioMes = new DateTime(anoSelecionado, mesSelecionado, 1);
                    DateTime fimMes = inicioMes.AddMonths(1);

                    var filteredRows = servicos_SociaisDataSet.Comparticipacoes.AsEnumerable()
                    .Where(row =>
                        row.Field<int>("IDSocio").ToString() == IDSocioAtual &&
                        row.Field<int>("IDSocio") == int.Parse(IDSocioAtual) &&
                        row.Field<DateTime>("Data") >= inicioMes &&
                        row.Field<DateTime>("Data") < fimMes)
                    .ToList();

                    if (filteredRows.Any())
                    {
                        comparticipacoesBindingSource.DataSource = filteredRows.CopyToDataTable();
                        comparticipacoesDataGridView.DataSource = comparticipacoesBindingSource;
                        comparticipacoesDataGridView.Refresh();

                        double totalMes = filteredRows.Sum(row => row.Field<double>("MontanteSocial"));
                        txtTM.Text = totalMes.ToString("C");
                    }
                    else
                    {
                        comparticipacoesBindingSource.DataSource = null;
                        comparticipacoesDataGridView.DataSource = null;
                        txtTM.Text = "0 €";
                    }
                }
                else
                {
                    comparticipacoesBindingSource.DataSource = null;
                    comparticipacoesDataGridView.DataSource = null;
                    txtTM.Text = "0 €";
                }
            }
            else
            {
                comparticipacoesBindingSource.DataSource = null;
                comparticipacoesDataGridView.DataSource = null;
                txtTM.Text = "0 €";
            }
        }

        private void AtualizarValores()
        {
            if (string.IsNullOrEmpty(IDSocioAtual))
            {
                MessageBox.Show("Nenhum sócio selecionado!", "Atenção");
                return;
            }

            CalcularTotalMensal();
            CalcularTotalAnual();

            FiltrarComparticipacoes();
        }

        private void FiltrarComparticipacoes()
        {
            if (!string.IsNullOrEmpty(IDSocioAtual) && cbDadosMes.SelectedIndex != -1)
            {
                int mesSelecionado = cbDadosMes.SelectedIndex + 1;
                int anoSelecionado = dateTimePickerAno.Value.Year;

                DateTime inicioMes = new DateTime(anoSelecionado, mesSelecionado, 1);
                DateTime fimMes = inicioMes.AddMonths(1);

                string filtro = $"Data >= #{inicioMes:MM/dd/yyyy}# AND Data < #{fimMes:MM/dd/yyyy}# AND IDSocio = '{IDSocioAtual}'";
                comparticipacoesBindingSource.Filter = filtro;

                comparticipacoesDataGridView.DataSource = comparticipacoesBindingSource;
                comparticipacoesDataGridView.Refresh();
            }
            else
            {
                comparticipacoesBindingSource.DataSource = null;
                comparticipacoesDataGridView.DataSource = null;
            }
        }

        private void cbDadosMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotalMensal();
            FiltrarComparticipacoes();
            CalcularTotalAnual();

            btRecibo.Enabled = true;
        }

        private void comparticipacoesDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                linha = e.RowIndex;
                DataGridViewRow linhaSel = comparticipacoesDataGridView.Rows[e.RowIndex];
            }
        }

        private void dateTimePickerAno_ValueChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void btRecibo_Click(object sender, EventArgs e)
        {
            string nomeSocio = cbPesqN.Text;
            int idSocio = Convert.ToInt32(cbPesqID.Text);
            DateTime data = DateTime.Now;
            string dataForm = data.ToString("dd/MM/yyyy");
            string serv = txtDadosServ.Text;
            string nib = txtDadosIBAN.Text.Remove(0, 3);
            string referencia = data.ToString("MMMM/yyyy", new System.Globalization.CultureInfo("pt-PT"));

            Recibo recibo = new Recibo();

            recibo.PreencherDadosSocio(nomeSocio, idSocio, dataForm, serv, nib, referencia);

            if (cbDadosMes.SelectedIndex != -1)
            {
                int mesSelecionado = cbDadosMes.SelectedIndex + 1;
                int anoSelecionado = dateTimePickerAno.Value.Year;

                DateTime inicioMes = new DateTime(anoSelecionado, mesSelecionado, 1);
                DateTime fimMes = inicioMes.AddMonths(1);

                var registrosTransferencia = servicos_SociaisDataSet.Comparticipacoes
                    .AsEnumerable()
                    .Where(row =>
                        row.Field<int>("IDSocio") == idSocio &&
                        row.Field<string>("Pagamento") == "Transferência" &&
                        row.Field<DateTime>("Data") >= inicioMes &&
                        row.Field<DateTime>("Data") < fimMes);

                if (!registrosTransferencia.Any())
                {
                    MessageBox.Show("Não há comparticipações para o mês selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    recibo.Close();
                    return;
                }

                var dataTableTransferencia = registrosTransferencia.CopyToDataTable();
                recibo.PreencherComparticipacoes(dataTableTransferencia);
            }

            recibo.ShowDialog();
        }

        private void btAdicionarDesc_Click(object sender, EventArgs e)
        {
            int IDSocio = Convert.ToInt32(cbPesqID.Text);

            RegDesc registar = new RegDesc(IDSocio, form)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            form.Controls["panel1"].Controls.Clear();
            form.Controls["panel1"].Controls.Add(registar);
            registar.Show();
        }

        private void Swift()
        {
            if (txtDadosIBAN.Text.StartsWith("PT500035"))
            {
                txtDadosBIC.Text = "CGDIPTPL";
            }
            else if (txtDadosIBAN.Text.StartsWith("PT500032"))
            {
                txtDadosBIC.Text = "BCOMPTPL";
            }
            else if (txtDadosIBAN.Text.StartsWith("PT500023"))
            {
                txtDadosBIC.Text = "ACTVPTPL";
            }
            else if (txtDadosIBAN.Text.StartsWith("PT500018"))
            {
                txtDadosBIC.Text = "TOTAPTPL";
            }
            else if (txtDadosIBAN.Text.StartsWith("PT500019"))
            {
                txtDadosBIC.Text = "BBVAPTPL";
            }
            else if (txtDadosIBAN.Text.StartsWith("PT500010"))
            {
                txtDadosBIC.Text = "BBPIPTPL";
            }
            else if (txtDadosIBAN.Text.StartsWith("PT500193"))
            {
                txtDadosBIC.Text = "CTTVPTPL";
            }
            else if (txtDadosIBAN.Text.StartsWith("PT500048"))
            {
                txtDadosBIC.Text = "BFIAPTPL";
            }
            else if (txtDadosIBAN.Text.StartsWith("PT500033"))
            {
                txtDadosBIC.Text = "BCOMPTPL";
            }
            else if (txtDadosIBAN.Text.StartsWith("PT500007"))
            {
                txtDadosBIC.Text = "BESCPTPL";
            }
            else if (txtDadosIBAN.Text.StartsWith("PT500269"))
            {
                txtDadosBIC.Text = "BKBKPTPL";
            }
            else if (txtDadosIBAN.Text.StartsWith("PT500079"))
            {
                txtDadosBIC.Text = "BPNPPTPL";
            }
            else if (txtDadosIBAN.Text.StartsWith("PT500046"))
            {
                txtDadosBIC.Text = "CRBNPTPL";
            }
            else if (txtDadosIBAN.Text.StartsWith("PT500036"))
            {
                txtDadosBIC.Text = "MPIOPTPL";
            }
            else if (txtDadosIBAN.Text.StartsWith("PT500063"))
            {
                txtDadosBIC.Text = "BNFIPTPL";
            }
        }

        private void AtualizarSocio()
        {
            txtDadosS.Enabled = true;
            txtDadosEC.Enabled = true;
            txtDadosMor.Enabled = true;
            txtDadosCP.Enabled = true;
            txtDadosTel.Enabled = true;
            txtDadosSS.Enabled = true;
            txtDadosNSS.Enabled = true;
            txtDadosIBAN.Enabled = true;
            txtDadosNC.Enabled = true;
            txtDadosDNC.Enabled = true;
            txtDadosADSEC.Enabled = true;
            cbDadosServ.Visible = true;
            cbDadosEC.Visible = true;
            cbDadosSS.Visible = true;
            dtpC.Visible = true;

            btRecibo.Visible = false;
            btExportar.Visible = false;
            gbComp.Visible = false;
            gbDadosDesc.Visible = false;
            txtDadosDN.Visible = false;
            txtDadosNISS.Visible = false;
            txtDadosNIF.Visible = false;
            txtDadosServ.Visible = false;
            txtDadosDNC.Visible = false;
        }

        private void MostrarTudo()
        {
            txtDadosS.Enabled = false;
            txtDadosEC.Enabled = false;
            txtDadosMor.Enabled = false;
            txtDadosCP.Enabled = false;
            txtDadosTel.Enabled = false;
            txtDadosSS.Enabled = false;
            txtDadosNSS.Enabled = false;
            txtDadosIBAN.Enabled = false;
            txtDadosNC.Enabled = false;
            txtDadosDNC.Enabled = false;
            txtDadosADSEC.Enabled = false;
            cbDadosServ.Visible = false;
            cbDadosEC.Visible = false;
            cbDadosSS.Visible = false;
            dtpC.Visible = false;

            btRecibo.Visible = true;
            btExportar.Visible = true;
            gbComp.Visible = true;
            gbDadosC.Visible = true;
            gbDadosDesc.Visible = true;
            txtDadosDN.Visible = true;
            txtDadosNISS.Visible = true;
            txtDadosNIF.Visible = true;
            txtDadosServ.Visible = true;
            txtDadosDNC.Visible = true;
        }

        static string FormatarNome(string nomeCompleto)
        {
            string[] partesNome = nomeCompleto.Split(' ');

            for (int i = 0; i < partesNome.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(partesNome[i]))
                {
                    partesNome[i] = char.ToUpper(partesNome[i][0]) + partesNome[i].Substring(1).ToLower();
                }
            }

            return string.Join(" ", partesNome);
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarSocio();
            btAtualizar.Visible = false;
            btConfirmar.Visible = true;
            rbSim.Visible = true;
            rbNao.Visible = true;
            lblSit.Visible = true;

            if(txtDadosNC.Text == "Nenhum cônjuge encontrado")
            {
                gbDadosC.Visible = false;
            }
            else
            {
                
            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                this.sóciosTableAdapter.Fill(this.servicos_SociaisDataSet.Sócios);
                this.conjugeTableAdapter.Fill(this.servicos_SociaisDataSet.Conjuge);

                Swift();

                int id = Convert.ToInt32(cbPesqID.Text);

                string nome = txtDadosS.Text;
                string nomeForm = FormatarNome(nome);
                string ec = cbDadosEC.SelectedValue?.ToString();
                string morada = txtDadosMor.Text;
                string cp = txtDadosCP.Text;
                string tel = txtDadosTel.Text;
                string ss = cbDadosSS.SelectedValue?.ToString();
                string nSS = txtDadosNSS.Text;
                string iban = txtDadosIBAN.Text;
                string swift = txtDadosBIC.Text;
                string serv = cbDadosServ.SelectedValue?.ToString();
                DateTime dataInat = DateTime.Now;
                string motivo = txtMotivo.Text;
                bool sit;

                string nomeC = txtDadosNC.Text;
                string nomeCForm = FormatarNome(nomeC);
                string nSSC = txtDadosADSEC.Text;
                DateTime dnc = dtpC.Value;

                string nomeD = txtDadosND.Text;
                string nomeDForm = FormatarNome(nomeD);
                string nSSD = txtDadosADSED.Text;

                if (!string.IsNullOrEmpty(txtDadosS.Text) &&
                    !string.IsNullOrEmpty(ec) &&
                    !string.IsNullOrEmpty(txtDadosMor.Text) &&
                    !string.IsNullOrEmpty(txtDadosCP.Text) &&
                    !string.IsNullOrEmpty(txtDadosTel.Text) &&
                    !string.IsNullOrEmpty(ss) &&
                    !string.IsNullOrEmpty(txtDadosNSS.Text) &&
                    !string.IsNullOrEmpty(txtDadosIBAN.Text) &&
                    !string.IsNullOrEmpty(txtDadosBIC.Text) &&
                    !string.IsNullOrEmpty(serv))
                {
                    if (Regex.IsMatch(nomeForm, @"^[A-Za-zÀ-ú\s]+$"))
                    {
                        if (Regex.IsMatch(txtDadosCP.Text, @"^\d{4}-\d{3}$"))
                        {
                            if (Regex.IsMatch(txtDadosTel.Text, @"^(91|92|93|96)\d{7}$"))
                            {
                                if (Regex.IsMatch(txtDadosIBAN.Text, @"^PT50\d{21}$"))
                                {
                                    if (Regex.IsMatch(nomeCForm, @"^[A-Za-zÀ-ú\s]+$"))
                                    {
                                        if (cbDadosEC.SelectedValue.ToString() == "Casado")
                                        {
                                            bool temConjuge = VerificarConjuge(id);

                                            if (!temConjuge)
                                            {
                                                RegConj registar = new RegConj(form)
                                                {
                                                    TopLevel = false,
                                                    FormBorderStyle = FormBorderStyle.None,
                                                    Dock = DockStyle.Fill
                                                };

                                                form.Controls["panel1"].Controls.Clear();
                                                form.Controls["panel1"].Controls.Add(registar);
                                                registar.Show();
                                            }
                                            else
                                            {
                                                MessageBox.Show("O sócio já possui um cônjuge registrado.");
                                            }

                                            if (rbSim.Checked == true)
                                            {
                                                if(txtMotivo.Text != "" && txtMotivo.Visible == true)
                                                {
                                                    sit = false;

                                                    this.sóciosTableAdapter.UpdateInativo(nomeForm, ec, sit, dataInat, ss, iban, swift, cp, morada, tel, serv, nSS, motivo, id);
                                                    this.Validate();
                                                    this.sóciosBindingSource.EndEdit();
                                                    this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

                                                    DataRow socioAtivo = this.servicos_SociaisDataSet.Sócios.FindByIDSocio(id);
                                                    if (socioAtivo != null)
                                                    {
                                                        DataRow socioInativo = this.servicos_Sociais_InativosDataSet.SóciosInativos.NewRow();
                                                        socioInativo["Situacao"] = sit;
                                                        socioInativo["DataInatividade"] = dataInat;
                                                        socioInativo["MotivoInativo"] = motivo;

                                                        socioInativo["IDSocio"] = socioAtivo["IDSocio"];
                                                        socioInativo["Nome"] = socioAtivo["Nome"];
                                                        socioInativo["DNasc"] = socioAtivo["DNasc"];
                                                        socioInativo["EstadoCivil"] = socioAtivo["EstadoCivil"];
                                                        socioInativo["DataAdmissao"] = socioAtivo["DataAdmissao"];
                                                        //socioInativo["Situacao"] = socioAtivo["Situacao"];
                                                        //socioInativo["DataInatividade"] = socioAtivo["DataInatividade"];
                                                        socioInativo["SistemaSaude"] = socioAtivo["SistemaSaude"];
                                                        socioInativo["NISS"] = socioAtivo["NISS"];
                                                        socioInativo["IBAN"] = socioAtivo["IBAN"];
                                                        socioInativo["BIC"] = socioAtivo["BIC"];
                                                        socioInativo["NIF"] = socioAtivo["NIF"];
                                                        socioInativo["CodPostal"] = socioAtivo["CodPostal"];
                                                        socioInativo["Morada"] = socioAtivo["Morada"];
                                                        socioInativo["Telefone"] = socioAtivo["Telefone"];
                                                        socioInativo["NFunc"] = socioAtivo["NFunc"];
                                                        socioInativo["Genero"] = socioAtivo["Genero"];
                                                        socioInativo["Serviço"] = socioAtivo["Serviço"];
                                                        socioInativo["NSS"] = socioAtivo["NSS"];
                                                        //socioInativo["MotivoInativo"] = socioAtivo["MotivoInativo"];


                                                        this.servicos_Sociais_InativosDataSet.SóciosInativos.Rows.Add(socioInativo);
                                                        this.sóciosInativosTableAdapter.Update(this.servicos_Sociais_InativosDataSet.SóciosInativos);
                                                    }

                                                    this.conjugeTableAdapter.UpdateNovo(nomeCForm, nSSC, id);
                                                    this.Validate();
                                                    this.conjugeBindingSource.EndEdit();
                                                    this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

                                                    DataRow conjugeAtivo = this.servicos_SociaisDataSet.Conjuge.FindByIDSocio(id);
                                                    if (conjugeAtivo != null)
                                                    {
                                                        DataRow conjugeInativo = this.servicos_Sociais_InativosDataSet.ConjugeInativo.NewRow();
                                                        conjugeAtivo["Situacao"] = sit;
                                                        conjugeInativo["IDConj"] = conjugeAtivo["IDConj"];
                                                        conjugeInativo["Nome"] = conjugeAtivo["Nome"];
                                                        conjugeInativo["DNasc"] = conjugeAtivo["DNasc"];
                                                        conjugeInativo["ADSE"] = conjugeAtivo["ADSE"];
                                                        conjugeInativo["IDSocio"] = conjugeAtivo["IDSocio"];
                                                        conjugeInativo["Situacao"] = conjugeAtivo["Situacao"];

                                                        this.servicos_Sociais_InativosDataSet.ConjugeInativo.Rows.Add(conjugeInativo);
                                                        this.conjugeInativoTableAdapter.Update(this.servicos_Sociais_InativosDataSet.ConjugeInativo);
                                                    }

                                                    this.descendentesTableAdapter.UpdateSit(id, sit);
                                                    this.Validate();
                                                    this.descendentesBindingSource.EndEdit();
                                                    this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

                                                    foreach (DataRow descendenteAtivo in this.descendentesTableAdapter.GetDataByIDSocio(id).Rows)
                                                    {
                                                        DataRow descendenteInativo = this.servicos_Sociais_InativosDataSet.DescendentesInativos.NewRow();
                                                        descendenteInativo["Situacao"] = sit;
                                                        descendenteInativo["Nome"] = descendenteAtivo["Nome"];
                                                        descendenteInativo["DNasc"] = descendenteAtivo["DNasc"];
                                                        descendenteInativo["Parentesco"] = descendenteAtivo["Parentesco"];
                                                        descendenteInativo["ADSE"] = descendenteAtivo["ADSE"];
                                                        descendenteInativo["IDSocio"] = descendenteAtivo["IDSocio"];
                                                        descendenteInativo["IDDesc"] = descendenteAtivo["IDDesc"];
                                                        //descendenteInativo["Situacao"] = descendenteAtivo["Situacao"];

                                                        this.servicos_Sociais_InativosDataSet.DescendentesInativos.Rows.Add(descendenteInativo);
                                                    }

                                                    this.descendentesInativosTableAdapter.Update(this.servicos_Sociais_InativosDataSet.DescendentesInativos);

                                                    this.sóciosTableAdapter.DeleteNovo(id);
                                                    this.conjugeTableAdapter.DeleteByIDSocio(id);
                                                    this.descendentesTableAdapter.DeleteByIDSocio(id);

                                                    MessageBox.Show("Registo atualizado e movido para a base de dados de inativos com sucesso!");
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Tem de preencher o motivo!");
                                                }
                                            }
                                            else if (rbNao.Checked == true)
                                            {
                                                sit = true;
                                                this.sóciosTableAdapter.UpdateAtivo(nomeForm, ec, sit, ss, iban, swift, cp, morada, tel, serv, nSS, id);
                                                MessageBox.Show("Registo atualizado com sucesso!");
                                            }

                                            this.conjugeTableAdapter.UpdateNovo(nomeCForm, nSSC, id);

                                            this.Validate();
                                            this.sóciosBindingSource.EndEdit();
                                            this.conjugeBindingSource.EndEdit();
                                            this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

                                            MessageBox.Show("Registo atualizado com sucesso!");
                                        }
                                        else
                                        {
                                            if (rbSim.Checked == true)
                                            {
                                                if (txtMotivo.Text != "" && txtMotivo.Visible == true)
                                                {
                                                    sit = false;

                                                    this.sóciosTableAdapter.UpdateInativo(nomeForm, ec, sit, dataInat, ss, iban, swift, cp, morada, tel, serv, nSS, motivo, id);
                                                    this.Validate();
                                                    this.sóciosBindingSource.EndEdit();
                                                    this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

                                                    DataRow socioAtivo = this.servicos_SociaisDataSet.Sócios.FindByIDSocio(id);
                                                    if (socioAtivo != null)
                                                    {
                                                        DataRow socioInativo = this.servicos_Sociais_InativosDataSet.SóciosInativos.NewRow();
                                                        socioInativo["Situacao"] = sit;
                                                        socioInativo["DataInatividade"] = dataInat;
                                                        socioInativo["MotivoInativo"] = motivo;

                                                        socioInativo["IDSocio"] = socioAtivo["IDSocio"];
                                                        socioInativo["Nome"] = socioAtivo["Nome"];
                                                        socioInativo["DNasc"] = socioAtivo["DNasc"];
                                                        socioInativo["EstadoCivil"] = socioAtivo["EstadoCivil"];
                                                        socioInativo["DataAdmissao"] = socioAtivo["DataAdmissao"];
                                                        //socioInativo["Situacao"] = socioAtivo["Situacao"];
                                                        //socioInativo["DataInatividade"] = socioAtivo["DataInatividade"];
                                                        socioInativo["SistemaSaude"] = socioAtivo["SistemaSaude"];
                                                        socioInativo["NISS"] = socioAtivo["NISS"];
                                                        socioInativo["IBAN"] = socioAtivo["IBAN"];
                                                        socioInativo["BIC"] = socioAtivo["BIC"];
                                                        socioInativo["NIF"] = socioAtivo["NIF"];
                                                        socioInativo["CodPostal"] = socioAtivo["CodPostal"];
                                                        socioInativo["Morada"] = socioAtivo["Morada"];
                                                        socioInativo["Telefone"] = socioAtivo["Telefone"];
                                                        socioInativo["NFunc"] = socioAtivo["NFunc"];
                                                        socioInativo["Genero"] = socioAtivo["Genero"];
                                                        socioInativo["Serviço"] = socioAtivo["Serviço"];
                                                        socioInativo["NSS"] = socioAtivo["NSS"];
                                                        //socioInativo["MotivoInativo"] = socioAtivo["MotivoInativo"];


                                                        this.servicos_Sociais_InativosDataSet.SóciosInativos.Rows.Add(socioInativo);
                                                        this.sóciosInativosTableAdapter.Update(this.servicos_Sociais_InativosDataSet.SóciosInativos);
                                                    }

                                                    this.conjugeTableAdapter.UpdateNovo(nomeCForm, nSSC, id);
                                                    this.Validate();
                                                    this.conjugeBindingSource.EndEdit();
                                                    this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

                                                    DataRow conjugeAtivo = this.servicos_SociaisDataSet.Conjuge.FindByIDSocio(id);
                                                    if (conjugeAtivo != null)
                                                    {
                                                        DataRow conjugeInativo = this.servicos_Sociais_InativosDataSet.ConjugeInativo.NewRow();
                                                        conjugeAtivo["Situacao"] = sit;
                                                        conjugeInativo["IDConj"] = conjugeAtivo["IDConj"];
                                                        conjugeInativo["Nome"] = conjugeAtivo["Nome"];
                                                        conjugeInativo["DNasc"] = conjugeAtivo["DNasc"];
                                                        conjugeInativo["ADSE"] = conjugeAtivo["ADSE"];
                                                        conjugeInativo["IDSocio"] = conjugeAtivo["IDSocio"];
                                                        conjugeInativo["Situacao"] = conjugeAtivo["Situacao"];

                                                        this.servicos_Sociais_InativosDataSet.ConjugeInativo.Rows.Add(conjugeInativo);
                                                        this.conjugeInativoTableAdapter.Update(this.servicos_Sociais_InativosDataSet.ConjugeInativo);
                                                    }

                                                    this.descendentesTableAdapter.UpdateSit(id, sit);
                                                    this.Validate();
                                                    this.descendentesBindingSource.EndEdit();
                                                    this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

                                                    foreach (DataRow descendenteAtivo in this.descendentesTableAdapter.GetDataByIDSocio(id).Rows)
                                                    {
                                                        DataRow descendenteInativo = this.servicos_Sociais_InativosDataSet.DescendentesInativos.NewRow();
                                                        descendenteInativo["Situacao"] = sit;
                                                        descendenteInativo["Nome"] = descendenteAtivo["Nome"];
                                                        descendenteInativo["DNasc"] = descendenteAtivo["DNasc"];
                                                        descendenteInativo["Parentesco"] = descendenteAtivo["Parentesco"];
                                                        descendenteInativo["ADSE"] = descendenteAtivo["ADSE"];
                                                        descendenteInativo["IDSocio"] = descendenteAtivo["IDSocio"];
                                                        descendenteInativo["IDDesc"] = descendenteAtivo["IDDesc"];
                                                        //descendenteInativo["Situacao"] = descendenteAtivo["Situacao"];

                                                        this.servicos_Sociais_InativosDataSet.DescendentesInativos.Rows.Add(descendenteInativo);
                                                    }

                                                    this.descendentesInativosTableAdapter.Update(this.servicos_Sociais_InativosDataSet.DescendentesInativos);

                                                    this.sóciosTableAdapter.DeleteNovo(id);
                                                    this.conjugeTableAdapter.DeleteByIDSocio(id);
                                                    this.descendentesTableAdapter.DeleteByIDSocio(id);

                                                    MessageBox.Show("Registo atualizado e movido para a base de dados de inativos com sucesso!");

                                                    form.Controls["panel1"].Controls.Clear();
                                                    form.Controls["panel1"].Visible = false;
                                                    form.Controls["btRegistar"].Visible = true;
                                                    form.Controls["btRegComp"].Visible = true;
                                                    form.Controls["btConsultar"].Visible = true;
                                                    form.Controls["pbLogo"].Visible = true;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Tem de preencher o motivo!");
                                                }
                                            }
                                            else if (rbNao.Checked == true)
                                            {
                                                sit = true;

                                                this.sóciosTableAdapter.UpdateAtivo(nomeForm, ec, sit, ss, iban, swift, cp, morada, tel, serv, nSS, id);
                                                this.conjugeTableAdapter.UpdateNovo(nomeCForm, nSSC, id);

                                                this.Validate();
                                                this.sóciosBindingSource.EndEdit();
                                                this.conjugeBindingSource.EndEdit();
                                                this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

                                                MessageBox.Show("Registo atualizado com sucesso!");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nome inválido. Não pode conter números ou caracteres especiais.");
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("IBAN inválido. Deve começar com PT50 e conter 25 caracteres.");
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Telemóvel inválido. Deve começar com 91, 92, 93 ou 96 e ter 9 dígitos.");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Código Postal inválido. Deve seguir o formato 1234-567.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nome inválido. Não pode conter números ou caracteres especiais.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Não podem haver campos em branco!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Erro");
            }
        }
        
        private bool VerificarConjuge(int IDSocio)
        {
            var conjuge = this.conjugeTableAdapter.GetDataByIDSocio(IDSocio);
            return conjuge.Rows.Count > 0;
        }

        private bool VerificarDesc(int IDSocio)
        {
            var desc = this.conjugeTableAdapter.GetDataByIDSocio(IDSocio);
            return desc.Rows.Count > 0;
        }

        private void rbSim_CheckedChanged(object sender, EventArgs e)
        {
            lblMotivo.Visible = true;
            txtMotivo.Visible = true;
        }

        private void rbNao_CheckedChanged(object sender, EventArgs e)
        {
            lblMotivo.Visible = false;
            txtMotivo.Visible = false;
        }
    }
}