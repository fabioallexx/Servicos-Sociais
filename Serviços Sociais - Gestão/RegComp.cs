using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Serviços_Sociais___Gestão
{
    public partial class RegComp : Form
    {
        Form form;
        private int linha = -1;
        private double valorSS = 0;
        private double perc = 0;
        private string assistencia = "";
        private string pagamento = "";
        private int idSocio;
        public RegComp(Form f)
        {
            InitializeComponent();
            form = f;
        }

        private void sóciosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sóciosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

        }

        private void RegComp_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Descendentes'. Você pode movê-la ou removê-la conforme necessário.
            this.descendentesTableAdapter.Fill(this.servicos_SociaisDataSet.Descendentes);
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Descendentes'. Você pode movê-la ou removê-la conforme necessário.
            this.descendentesTableAdapter.Fill(this.servicos_SociaisDataSet.Descendentes);
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Conjuge'. Você pode movê-la ou removê-la conforme necessário.
            this.conjugeTableAdapter.Fill(this.servicos_SociaisDataSet.Conjuge);
            this.tipoAssistenciaTableAdapter.Fill(this.servicos_SociaisDataSet.TipoAssistencia);
            // TODO: This line of code loads data into the 'servicos_SociaisDataSet.Comparticipacoes' table. You can move, or remove it, as needed.
            this.comparticipacoesTableAdapter.Fill(this.servicos_SociaisDataSet.Comparticipacoes);
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Assistencias'. Você pode movê-la ou removê-la conforme necessário.
            this.assistenciasTableAdapter.Fill(this.servicos_SociaisDataSet.Assistencias);
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Sócios'. Você pode movê-la ou removê-la conforme necessário.
            this.sóciosTableAdapter.Fill(this.servicos_SociaisDataSet.Sócios);

            cbAssit.DataSource = tipoAssistenciaBindingSource;
            cbAssit.DisplayMember = "Tipo";
            cbAssit.ValueMember = "Tipo";
            cbAssit.SelectedIndex = -1;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPesNome.Text != "" && txtPesNif.Text == "")
                {
                    sóciosBindingSource.Filter = "Nome like '%" + txtPesNome.Text + "%'";
                }
                else if (txtPesNome.Text == "" && txtPesNif.Text != "")
                {
                    sóciosBindingSource.Filter = "NIF like '%" + txtPesNif.Text + "%'";
                }
                else if (txtPesNome.Text != "" && txtPesNif.Text != "")
                {
                    sóciosBindingSource.Filter = "NIF like '%" + txtPesNif.Text + "%'";
                    sóciosBindingSource.Filter = "Nome like '%" + txtPesNome.Text + "%'";
                }
                else
                    MessageBox.Show("Insira apenas um critério de pesquisa!", "Informação");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Insira apenas valores válidos", "Informação" + ex);
            }
        }

        private void CalcularComp(string comp, double perc, double val)
        {
            try
            {
                if(comp == "Consultas")
                {
                    perc = 0.60;
                    val = val * perc;
                    
                    if (val > 1000)
                    {
                        val = 1000;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Medicamentos")
                {
                    perc = 0.90;
                    val = val * perc;

                    if (val > 1000)
                    {
                        val = 1000;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Medicamentos (IVA 23%)")
                {
                    perc = 0.90;
                    val = val * perc;

                    if (val > 1000)
                    {
                        val = 1000;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Meios Auxiliares Diagnóstico e Terapêutica")
                {
                    perc = 0.60;
                    val = val * perc;

                    if (val > 1000)
                    {
                        val = 1000;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Oftalmologia (armações)")
                {
                    perc = 0.50;
                    val = val * perc;

                    if (val > 50)
                    {
                        val = 50;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Oftalmologia (lentes)")
                {
                    perc = 0.50;
                    val = val * perc;

                    if (val > 100)
                    {
                        val = 100;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Estomatologia (prótese)")
                {
                    perc = 0.50;
                    val = val * perc;

                    if (val > 50)
                    {
                        val = 50;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Estomatologia (dentes isolados)")
                {
                    perc = 0.50;
                    val = val * perc;

                    if (val > 25)
                    {
                        val = 25;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Estomatologia (aparelhos de ortodôncia)")
                {
                    perc = 0.50;
                    val = val * perc;

                    if (val > 100)
                    {
                        val = 100;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Estomatologia (reparação de próteses)")
                {
                    perc = 0.50;
                    val = val * perc;

                    if (val > 25)
                    {
                        val = 25;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Estomatologia (tratamentos)")
                {
                    perc = 0.50;
                    val = val * perc;

                    if (val > 100)
                    {
                        val = 100;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Próteses e outros aparelhos ortopédicos")
                {
                    perc = 0.50;
                    val = val * perc;

                    if (val > 250)
                    {
                        val = 250;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Reparação de próteses e aparelhos ortopédicos")
                {
                    perc = 0.50;
                    val = val * perc;

                    if (val > 100)
                    {
                        val = 100;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Veículos de rodas")
                {
                    perc = 0.50;
                    val = val * perc;

                    if (val > 250)
                    {
                        val = 250;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Outros meios de correção e compensação")
                {
                    perc = 0.50;
                    val = val * perc;

                    if (val > 50)
                    {
                        val = 50;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Transportes")
                {
                    perc = 0.60;
                    val = val * perc;

                    if (val > 1000)
                    {
                        val = 1000;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Tratamento e outros em regime de internamento")
                {
                    perc = 0.50;
                    val = val * perc;

                    if (val > 250)
                    {
                        val = 250;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Tratamentos  outros em regime ambulatório")
                {
                    perc = 0.50;
                    val = val * perc;

                    if (val > 100)
                    {
                        val = 100;
                    }
                    txtSS.Text = val.ToString();
                }
                else if(comp == "Subsídio Pré-escolar")
                {
                    val = 15;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Subsídio escolar (ensino básico - 1º ciclo)")
                {
                    val = 25;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Subsídio escolar (ensino básico - 2º ciclo)")
                {
                    val = 40;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Subsídio escolar (ensino básico - 3º ciclo)")
                {
                    val = 45;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Subsídio escolar (ensino secundário)")
                {
                    val = 60;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Subsídio escolar (ensino superior)")
                {
                    val = 75;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (1º classif. 7º ano)")
                {
                    val = 12.50;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (1º classif. 8º ano)")
                {
                    val = 13.75;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (1º classif. 9º ano)")
                {
                    val = 15;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (1º classif. 10º ano)")
                {
                    val = 16.25;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (1º classif. 11º ano)")
                {
                    val = 17.50;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (1º classif. 12º ano)")
                {
                    val = 18.75;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (1º classif. ensino superior)")
                {
                    val = 25;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (2º classif. 7º ano)")
                {
                    val = 11.25;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (2º classif. 8º ano)")
                {
                    val = 12.50;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (2º classif. 9º ano)")
                {
                    val = 13.75;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (2º classif. 10º ano)")
                {
                    val = 15;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (2º classif. 11º ano)")
                {
                    val = 16.25;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (2º classif. 12º ano)")
                {
                    val = 17.50;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (2º classif. ensino superior)")
                {
                    val = 23.75;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (3º classif. 7º ano)")
                {
                    val = 10;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (3º classif. 8º ano)")
                {
                    val = 11.25;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (3º classif. 9º ano)")
                {
                    val = 12.50;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (3º classif. 10º ano)")
                {
                    val = 13.75;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (3º classif. 11º ano)")
                {
                    val = 15;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (3º classif. 12º ano)")
                {
                    val = 16.25;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Prémio escolar (3º classif. ensino superior)")
                {
                    val = 22.50;
                    txtSS.Text = val.ToString();
                }
                else if (comp == "Subsídios de Ensino Especial" || comp == "Subsídios de Nascimento" || comp == "Subsídios de Funeral" || comp == "Subsídios de Casamento")
                {
                    val = 50;
                    txtSS.Text = val.ToString();
                }
            }
            catch { }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.sóciosTableAdapter.Fill(this.servicos_SociaisDataSet.Sócios);

            if (txtNome.Text != "" && txtMontante.Text != "" && cbAssit.SelectedValue != null)
            {
                if (Regex.IsMatch(txtMontante.Text, @"^\d+$"))
                {
                    if (linha >= 0)
                    {
                        DataGridViewRow linhaSel = sóciosDataGridView.Rows[linha];

                        int id = Convert.ToInt32(linhaSel.Cells[0].Value);

                        assistencia = cbAssit.SelectedValue.ToString();
                        string nome = txtNome.Text;
                        double valorADSE = Convert.ToDouble(txtADSE.Text);
                        double valor = Convert.ToDouble(txtMontante.Text);

                        double valorDesc = valor - valorADSE;
                        valorSS = Convert.ToDouble(txtSS.Text);

                        DateTime data = DateTime.Now;

                        this.comparticipacoesTableAdapter.Insert(assistencia, data, valor, nome, id, valorADSE, valorSS, pagamento);

                        this.Validate();
                        this.comparticipacoesBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

                        MessageBox.Show("Registo inserido com sucesso!");

                        lblPag.Visible = false;
                        rbBanco.Visible = false;
                        rbDinheiro.Visible = false;
                        txtADSE.Text = "";
                        txtMontante.Text = "";
                        txtSS.Text = "";
                        btInserir.Visible = false;
                        cbAssit.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecione um sócio.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um valor válido, com apenas números!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Tem que preencher todos os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sóciosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                linha = e.RowIndex;
                DataGridViewRow linhaSel = sóciosDataGridView.Rows[e.RowIndex];

                idSocio = Convert.ToInt32(linhaSel.Cells[0].Value);
                txtNome.Text = linhaSel.Cells[1].Value.ToString();

                btConj.Visible = true;
                btDesc.Visible = true;
            }
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

        private void txtMontante_TextChanged(object sender, EventArgs e)
        {
            if (txtMontante.Text != "")
            {
                txtADSE.Enabled = true;
            }
            else
            {
                txtADSE.Enabled = false;
            }
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                assistencia = cbAssit.SelectedValue.ToString();
                double valorADSE = Convert.ToDouble(txtADSE.Text);
                double valor = Convert.ToDouble(txtMontante.Text);

                perc = 0;
                double valorDesc = valor - valorADSE;
                valorSS = valorDesc;

                CalcularComp(assistencia, perc, valorSS);

                btInserir.Visible = true;
                lblPag.Visible = true;
                rbBanco.Visible = true;
                rbDinheiro.Visible = true;
            }
            catch
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbBanco_CheckedChanged(object sender, EventArgs e)
        {
            pagamento = "Transferência";
            btInserir.Enabled = true;
        }

        private void rbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            pagamento = "Dinheiro";
            btInserir.Enabled = true;
        }

        private void txtADSE_TextChanged(object sender, EventArgs e)
        {
            if (txtADSE.Text == "")
            {
                btCalcular.Enabled = false;
            }
            else
            {
                btCalcular.Enabled = true;
            }
        }

        private void btConj_Click(object sender, EventArgs e)
        {
            sóciosDataGridView.Visible = false;
            descendentesDataGridView.Visible = false;
            conjugeDataGridView.Visible = true;

            btDesc.Visible = true;
            btSocios.Visible = true;
            btConj.Visible = false;

            this.conjugeTableAdapter.FillBySocio(this.servicos_SociaisDataSet.Conjuge, idSocio);
        }

        private void btDesc_Click(object sender, EventArgs e)
        {
            sóciosDataGridView.Visible = false;
            conjugeDataGridView.Visible = false;
            descendentesDataGridView.Visible = true;

            btDesc.Visible = false;
            btSocios.Visible = true;
            btConj.Visible = true;

            this.descendentesTableAdapter.FillBySocio(this.servicos_SociaisDataSet.Descendentes, idSocio);
        }

        private void btSocios_Click(object sender, EventArgs e)
        {
            sóciosDataGridView.Visible = true;
            conjugeDataGridView.Visible = false;
            descendentesDataGridView.Visible = false;

            btDesc.Visible = true;
            btConj.Visible = true;
            btSocios.Visible = false;
        }
    }
}