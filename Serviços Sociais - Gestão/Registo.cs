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
using static System.Windows.Forms.LinkLabel;

namespace Serviços_Sociais___Gestão
{
    public partial class Registo : Form
    {
        Form form;

        public int nFilhos = 0;
        public Registo(Form f)
        {
            InitializeComponent();
            form = f;
        }

        private void Swift()
        {
            if (txtIBAN.Text.StartsWith("PT500035"))
            {
                txtBIC.Text = "CGDIPTPL";
            }
            else if (txtIBAN.Text.StartsWith("PT500032"))
            {
                txtBIC.Text = "BCOMPTPL";
            }
            else if (txtIBAN.Text.StartsWith("PT500023"))
            {
                txtBIC.Text = "ACTVPTPL";
            }
            else if (txtIBAN.Text.StartsWith("PT500018"))
            {
                txtBIC.Text = "TOTAPTPL";
            }
            else if (txtIBAN.Text.StartsWith("PT500019"))
            {
                txtBIC.Text = "BBVAPTPL";
            }
            else if (txtIBAN.Text.StartsWith("PT500010"))
            {
                txtBIC.Text = "BBPIPTPL";
            }
            else if (txtIBAN.Text.StartsWith("PT500193"))
            {
                txtBIC.Text = "CTTVPTPL";
            }
            else if (txtIBAN.Text.StartsWith("PT500048"))
            {
                txtBIC.Text = "BFIAPTPL";
            }
            else if (txtIBAN.Text.StartsWith("PT500033"))
            {
                txtBIC.Text = "BCOMPTPL";
            }
            else if (txtIBAN.Text.StartsWith("PT500007"))
            {
                txtBIC.Text = "BESCPTPL";
            }
            else if (txtIBAN.Text.StartsWith("PT500269"))
            {
                txtBIC.Text = "BKBKPTPL";
            }
            else if (txtIBAN.Text.StartsWith("PT500079"))
            {
                txtBIC.Text = "BPNPPTPL";
            }
            else if (txtIBAN.Text.StartsWith("PT500046"))
            {
                txtBIC.Text = "CRBNPTPL";
            }
            else if (txtIBAN.Text.StartsWith("PT500036"))
            {
                txtBIC.Text = "MPIOPTPL";
            }
            else if (txtIBAN.Text.StartsWith("PT500063"))
            {
                txtBIC.Text = "BNFIPTPL";
            }
        }

        private void btCancelar_Click_1(object sender, EventArgs e)
        {
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

        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text != "" && cbGen.SelectedValue != null && dateTimePickerDN.Value != null &&
                        cbEC.SelectedValue != null && txtMorada.Text != "" && txtCP.Text != "" && txtTelemovel.Text != ""
                        && cbSS.SelectedValue != null && txtNSS.Text != "" && txtNISS.Text != "" && txtIBAN.Text != "" &&
                        txtBIC.Text != "" && txtNIF.Text != "" && txtNF.Text != "" && cbServ.SelectedValue != null)
                {
                    if (cbEC.SelectedValue.ToString() == "Casado")
                    {

                        this.sóciosTableAdapter.Fill(this.servicos_SociaisDataSet.Sócios);

                        string nome = txtNome.Text;
                        string nomeForm = FormatarNome(nome);
                        string gen = cbGen.SelectedValue.ToString();
                        DateTime dn = dateTimePickerDN.Value;
                        DateTime da = dateTimePickerDA.Value;
                        string ec = cbEC.SelectedValue.ToString();
                        string morada = txtMorada.Text;
                        string cp = txtCP.Text;
                        string tel = txtTelemovel.Text;
                        string ss = cbSS.SelectedValue.ToString();
                        string nSS = txtNSS.Text;
                        string niss = txtNISS.Text;
                        string iban = txtIBAN.Text;
                        string swift = txtBIC.Text;
                        string nif = txtNIF.Text;
                        string nfunc = txtNF.Text;
                        string serv = cbServ.SelectedValue.ToString();
                        bool sit = true;

                        if (Regex.IsMatch(nomeForm, @"^[A-Za-zÀ-ú\s]+$"))
                        {
                            if ((DateTime.Now.Year - dn.Year) > 18 ||
                                (DateTime.Now.Year - dn.Year != 18 && DateTime.Now.DayOfYear > dn.DayOfYear))
                            {
                                if (Regex.IsMatch(txtCP.Text, @"^\d{4}-\d{3}$"))
                                {
                                    if (Regex.IsMatch(txtTelemovel.Text, @"^(91|92|93|96)\d{7}$"))
                                    {
                                        if (Regex.IsMatch(txtNISS.Text, @"^\d{11}$"))
                                        {
                                            if (Regex.IsMatch(txtIBAN.Text, @"^PT50\d{21}$"))
                                            {
                                                if (Regex.IsMatch(txtNIF.Text, @"^\d{9}$"))
                                                {
                                                    if (Regex.IsMatch(txtNF.Text, @"^\d+$"))
                                                    {
                                                        this.sóciosTableAdapter.InsertNovo(nomeForm, dn, ec, da, sit, ss, niss, iban, swift, nif, cp, morada, tel, nfunc, gen, serv, nSS);

                                                        this.Validate();
                                                        this.sóciosBindingSource.EndEdit();
                                                        this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

                                                        MessageBox.Show("Registro inserido com sucesso!");

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
                                                        MessageBox.Show("Número de Funcionário inválido. Deve conter apenas números.");
                                                        errorProvider.SetError(txtNF, "Número de Funcionário inválido. Deve conter apenas números.");
                                                        return;
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("NIF inválido. Deve conter 9 dígitos.");
                                                    errorProvider.SetError(txtNIF, "NIF inválido. Deve conter 9 dígitos.");
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("IBAN inválido. Deve começar com PT50 e conter 25 caracteres.");
                                                errorProvider.SetError(txtIBAN, "IBAN inválido. Deve começar com PT50 e conter 25 caracteres.");
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("NISS inválido. Deve conter 11 dígitos.");
                                            errorProvider.SetError(txtNISS, "NISS inválido. Deve conter 11 dígitos.");
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Telemóvel inválido. Deve começar com 91, 92, 93 ou 96 e ter 9 dígitos.");
                                        errorProvider.SetError(txtTelemovel, "Telemóvel inválido. Deve começar com 91, 92, 93 ou 96 e ter 9 dígitos.");
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Código Postal inválido. Deve seguir o formato 1234-567.");
                                    errorProvider.SetError(txtCP, "Código Postal inválido. Deve seguir o formato 1234-567.");
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("A pessoa deve ter 18 anos ou mais.");
                                errorProvider.SetError(dateTimePickerDN, "A pessoa deve ter 18 anos ou mais.");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nome inválido. Não pode conter números ou caracteres especiais.");
                            errorProvider.SetError(txtNome, "O nome não pode conter número ou caracteres especiais.");
                            return;
                        }
                    }
                    else
                    {
                        this.sóciosTableAdapter.Fill(this.servicos_SociaisDataSet.Sócios);

                        string nome = txtNome.Text;
                        string nomeForm = FormatarNome(nome);
                        string gen = cbGen.SelectedValue.ToString();
                        DateTime dn = dateTimePickerDN.Value;
                        DateTime da = DateTime.Now;
                        string ec = cbEC.SelectedValue.ToString();
                        string morada = txtMorada.Text;
                        string cp = txtCP.Text;
                        string tel = txtTelemovel.Text;
                        string ss = cbSS.SelectedValue.ToString();
                        string nSS = txtNSS.Text;
                        string niss = txtNISS.Text;
                        string iban = txtIBAN.Text;
                        string swift = txtBIC.Text;
                        string nif = txtNIF.Text;
                        string nfunc = txtNF.Text;
                        string serv = cbServ.SelectedValue.ToString();
                        bool sit = true;

                        if (Regex.IsMatch(nomeForm, @"^[A-Za-zÀ-ú\s]+$"))
                        {
                            if ((DateTime.Now.Year - dn.Year) > 18 ||
                                (DateTime.Now.Year - dn.Year != 18 && DateTime.Now.DayOfYear > dn.DayOfYear))
                            {
                                if (Regex.IsMatch(txtCP.Text, @"^\d{4}-\d{3}$"))
                                {
                                    if (Regex.IsMatch(txtTelemovel.Text, @"^(91|92|93|96)\d{7}$"))
                                    {
                                        if (Regex.IsMatch(txtNISS.Text, @"^\d{11}$"))
                                        {
                                            if (Regex.IsMatch(txtIBAN.Text, @"^PT50\d{21}$"))
                                            {
                                                if (Regex.IsMatch(txtNIF.Text, @"^\d{9}$"))
                                                {
                                                    if (Regex.IsMatch(txtNF.Text, @"^\d+$"))
                                                    {
                                                        this.sóciosTableAdapter.InsertNovo(nomeForm, dn, ec, da, sit, ss, niss, iban, swift, nif, cp, morada, tel, nfunc, gen, serv, nSS);

                                                        this.Validate();
                                                        this.sóciosBindingSource.EndEdit();
                                                        this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

                                                        MessageBox.Show("Registro inserido com sucesso!");

                                                        rbSim.Visible = true;
                                                        rbNao.Visible = true;
                                                        lblDesc.Visible = true;
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Número de Funcionário inválido. Deve conter apenas números.");
                                                        errorProvider.SetError(txtNF, "Número de Funcionário inválido. Deve conter apenas números.");
                                                        return;
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("NIF inválido. Deve conter 9 dígitos.");
                                                    errorProvider.SetError(txtNIF, "NIF inválido. Deve conter 9 dígitos.");
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("IBAN inválido. Deve começar com PT50 e conter 25 caracteres.");
                                                errorProvider.SetError(txtIBAN, "IBAN inválido. Deve começar com PT50 e conter 25 caracteres.");
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("NISS inválido. Deve conter 11 dígitos.");
                                            errorProvider.SetError(txtNISS, "NISS inválido. Deve conter 11 dígitos.");
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Telemóvel inválido. Deve começar com 91, 92, 93 ou 96 e ter 9 dígitos.");
                                        errorProvider.SetError(txtTelemovel, "Telemóvel inválido. Deve começar com 91, 92, 93 ou 96 e ter 9 dígitos.");
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Código Postal inválido. Deve seguir o formato 1234-567.");
                                    errorProvider.SetError(txtCP, "Código Postal inválido. Deve seguir o formato 1234-567.");
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("A pessoa deve ter 18 anos ou mais.");
                                errorProvider.SetError(dateTimePickerDN, "A pessoa deve ter 18 anos ou mais.");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nome inválido. Não pode conter números ou caracteres especiais.");
                            errorProvider.SetError(txtNome, "O nome não pode conter número ou caracteres especiais.");
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Não podem haver campos em branco!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar registar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void estadoCivilBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estadoCivilBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

        }

        private void estadoCivilBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.estadoCivilBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.servicos_SociaisDataSet);

        }

        private void ConfigCB()
        {
            cbGen.DataSource = generoBindingSource;
            cbGen.DisplayMember = "Genero";
            cbGen.ValueMember = "Genero";
            cbGen.SelectedIndex = -1;

            cbEC.DataSource = estadoCivilBindingSource;
            cbEC.DisplayMember = "EstadoCivil";
            cbEC.ValueMember = "EstadoCivil";
            cbEC.SelectedIndex = -1;

            cbServ.DataSource = serviçoBindingSource;
            cbServ.DisplayMember = "Serviço";
            cbServ.ValueMember = "Serviço";
            cbServ.SelectedIndex = -1;

            cbSS.DataSource = sistemaSaudeBindingSource;
            cbSS.DisplayMember = "SistemaSaude";
            cbSS.ValueMember = "SistemaSaude";
            cbSS.SelectedIndex = -1;
        }

        private void Registo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Genero'. Você pode movê-la ou removê-la conforme necessário.
            this.generoTableAdapter.Fill(this.servicos_SociaisDataSet.Genero);
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Serviço'. Você pode movê-la ou removê-la conforme necessário.
            this.serviçoTableAdapter.Fill(this.servicos_SociaisDataSet.Serviço);
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.SistemaSaude'. Você pode movê-la ou removê-la conforme necessário.
            this.sistemaSaudeTableAdapter.Fill(this.servicos_SociaisDataSet.SistemaSaude);
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.Sócios'. Você pode movê-la ou removê-la conforme necessário.
            this.sóciosTableAdapter.Fill(this.servicos_SociaisDataSet.Sócios);
            // TODO: esta linha de código carrega dados na tabela 'servicos_SociaisDataSet.EstadoCivil'. Você pode movê-la ou removê-la conforme necessário.
            this.estadoCivilTableAdapter.Fill(this.servicos_SociaisDataSet.EstadoCivil);

            
            ConfigCB();
        }

        private void txtIBAN_TextChanged(object sender, EventArgs e)
        {
            Swift();
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário de registo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerDN_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
