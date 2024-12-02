using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Serviços_Sociais___Gestão
{
    public partial class RegConj : Form
    {
        int id = 0;
        Form form;
        public int nFilhos = 0;
        public RegConj(Form f)
        {
            InitializeComponent();
            form = f;
        }

        public RegConj()
        {
            InitializeComponent();
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

        private void RegistoDoc_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Sócios'. Você pode movê-la ou removê-la conforme necessário.
            this.sóciosTableAdapter.Fill(this.servicos_SociaisDataSet.Sócios);
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Conjuge'. Você pode movê-la ou removê-la conforme necessário.
            this.conjugeTableAdapter.Fill(this.servicos_SociaisDataSet.Conjuge);

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            FormPrincipal fp = new FormPrincipal();

            form.Controls["panel1"].Controls.Clear();
            form.Controls["panel1"].Visible = false;
            form.Controls["btRegistar"].Visible = true;
            form.Controls["btRegComp"].Visible = true;
            form.Controls["btConsultar"].Visible = true;
            form.Controls["pbLogo"].Visible = true;
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

        private void btGuardarC_Click(object sender, EventArgs e)
        {
            if(txtNConjuge.Text != "" && txtADSE.Text != "")
            {
                if (Regex.IsMatch(txtNConjuge.Text, @"^[A-Za-zÀ-ú\s]+$"))
                {
                    if (Regex.IsMatch(txtADSE.Text, @"^\d+$"))
                    {
                        this.conjugeTableAdapter.Fill(this.servicos_SociaisDataSet.Conjuge);

                        string nome = txtNConjuge.Text;
                        string nomeForm = FormatarNome(nome);
                        DateTime dn = dtpConjuge.Value;
                        string adse = txtADSE.Text;
                        bool sit = true;

                        int ultimoID = ObterUltimoID();

                        if (ultimoID == 0)
                        {
                            MessageBox.Show("Não foi possível obter o ID de sócio. Verifique se existem sócios registados.",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            id = ultimoID;
                            lblDesc.Visible = true;
                            rbSim.Visible = true;
                            rbNao.Visible = true;
                        }

                        this.conjugeTableAdapter.Insert(nomeForm, dn, adse, id, sit);

                        MessageBox.Show("Conjuge registado com sucesso!", "Informação", MessageBoxButtons.OK);

                        btGuardarC.Visible = false;
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

        private void conjugeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.conjugeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

        }

        private void rbSim_CheckedChanged(object sender, EventArgs e)
        {
            lblQuantos.Visible = true;
            numericUpDown.Visible = true;
            btConfirmar.Visible = true;
        }

        private void rbNao_CheckedChanged(object sender, EventArgs e)
        {
            lblQuantos.Visible = false;
            numericUpDown.Visible = false;
            btConfirmar.Visible = true;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            btConfirmar.Visible = true;
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbCSim.Checked) 
                {
                    if (rbSim.Checked)
                    {
                        nFilhos = Convert.ToInt16(numericUpDown.Value);

                        RegDesc registar = new RegDesc(form, nFilhos)
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
                        FormPrincipal fp = new FormPrincipal()
                        {
                            TopLevel = false,
                            FormBorderStyle = FormBorderStyle.None,
                            Dock = DockStyle.Fill
                        };

                        form.Controls["panel1"].Controls.Clear();
                        form.Controls["panel1"].Visible = false;
                        form.Controls["btRegistar"].Visible = true;
                        form.Controls["btRegComp"].Visible = true;
                        form.Controls["btConsultar"].Visible = true;
                        form.Controls["pbLogo"].Visible = true;

                        fp.Show();
                    }
                }
                else
                {
                    FormPrincipal fp = new FormPrincipal()
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill
                    };

                    form.Controls["panel1"].Controls.Clear();
                    form.Controls["panel1"].Visible = false;
                    form.Controls["btRegistar"].Visible = true;
                    form.Controls["btRegComp"].Visible = true;
                    form.Controls["btConsultar"].Visible = true;
                    form.Controls["pbLogo"].Visible = true;

                    fp.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário de registo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void rbCSim_CheckedChanged(object sender, EventArgs e)
        {
            gbConjuge.Visible = true;
            btConfirmar.Visible = true;
            lblDesc.Visible = false;
            rbSim.Visible = false;
            rbNao.Visible = false;
            lblQuantos.Visible = false;
            numericUpDown.Visible = false;
        }

        private void rbCNao_CheckedChanged(object sender, EventArgs e)
        {
            gbConjuge.Visible = false;
            lblDesc.Visible = true;
            rbSim.Visible = true;
            rbNao.Visible = true;
            btConfirmar.Visible = true;
            lblQuantos.Visible = true;
            numericUpDown.Visible = true;
        }
    }
}
