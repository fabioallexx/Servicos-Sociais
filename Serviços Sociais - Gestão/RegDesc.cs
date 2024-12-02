using Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters;
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

namespace Serviços_Sociais___Gestão
{
    public partial class RegDesc : Form
    {
        Form form;
        int filhos;
        int id = 0;
        int nReg;
        public RegDesc(Form f, int nFilhos)
        {
            InitializeComponent();
            this.form = f;
            filhos = nFilhos;
            nReg = filhos;
        }

        public RegDesc(int id, Form f)
        {
            InitializeComponent();
            this.form = f;
            this.id = id;
        }

        private void NumeroFilhos()
        {
            if (nReg > 1)
            {
                btGuardar.Text = "Seguinte";
                btGuardar.Enabled = true;
            }
            else
            {
                btGuardar.Text = "Guardar";
                btGuardar.Enabled = true;
            }
        }

        private int ObterUltimoID()
        {
            try
            {
                DataTable dt = sóciosTableAdapter.GetData();
                if (dt.Rows.Count > 0)
                {
                    int ultimoID = (int)dt.AsEnumerable()
                                          .OrderByDescending(row => row.Field<int>("IDSocio"))
                                          .First()["IDSocio"];
                    return ultimoID;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter o último ID: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
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

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if(txtNDesc.Text != "" && cbParent.Text != "" && dtpDesc.Value != null && txtADSEDesc.Text != "")
            {
                if (Regex.IsMatch(txtNDesc.Text, @"^[A-Za-zÀ-ú\s]+$"))
                {
                    if (Regex.IsMatch(txtADSEDesc.Text, @"^\d+$"))
                    {
                        nReg--;

                        NumeroFilhos();

                        string nome = txtNDesc.Text;
                        string nomeForm = FormatarNome(nome);
                        DateTime dn = dtpDesc.Value;
                        string par = cbParent.SelectedValue.ToString();
                        string adse = txtADSEDesc.Text;
                        int ultimoID = ObterUltimoID();
                        bool sit = true;

                        if(id > 0)
                        {
                            this.descendentesTableAdapter.Insert(nomeForm, dn, par, adse, id, sit);
                        }
                        else
                        {
                            id = ultimoID;
                            this.descendentesTableAdapter.Insert(nomeForm, dn, par, adse, id, sit);
                        }

                        MessageBox.Show("Descendente registado com sucesso!", "Informação", MessageBoxButtons.OK);

                        if (nReg > 0)
                        {
                            txtNDesc.Clear();
                            cbParent.SelectedIndex = -1;
                            txtADSEDesc.Clear();
                        }
                        else
                        {
                            btGuardar.Enabled = false;

                            form.Controls["panel1"].Controls.Clear();
                            form.Controls["panel1"].Visible = false;
                            form.Controls["btRegistar"].Visible = true;
                            form.Controls["btRegComp"].Visible = true;
                            form.Controls["btConsultar"].Visible = true;
                            form.Controls["pbLogo"].Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("O número de serviço social tem que conter apenas números!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("O nome não pode conter números ou caracteres especiais!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Tem que preencher todos os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void descendentesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.descendentesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

        }

        private void RegDesc_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Sócios'. Você pode movê-la ou removê-la conforme necessário.
            this.sóciosTableAdapter.Fill(this.servicos_SociaisDataSet.Sócios);
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Parentesco'. Você pode movê-la ou removê-la conforme necessário.
            this.parentescoTableAdapter.Fill(this.servicos_SociaisDataSet.Parentesco);
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Descendentes'. Você pode movê-la ou removê-la conforme necessário.
            this.descendentesTableAdapter.Fill(this.servicos_SociaisDataSet.Descendentes);

            cbParent.DataSource = parentescoBindingSource;
            cbParent.DisplayMember = "Parentesco";
            cbParent.ValueMember = "Parentesco";
            cbParent.SelectedIndex = -1;

            NumeroFilhos();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer sair sem guardar?", "Informação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    form.Controls["panel1"].Controls.Clear();
                    form.Controls["panel1"].Visible = false;
                    form.Controls["btRegistar"].Visible = true;
                    form.Controls["btRegComp"].Visible = true;
                    form.Controls["btConsultar"].Visible = true;
                    form.Controls["pbLogo"].Visible = true;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar sair: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
