using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serviços_Sociais___Gestão
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer sair sem guardar?", "Informação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) 
                {
                    Application.Exit();
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

        private void btRegistar_Click(object sender, EventArgs e)
        {
            try
            {
                btRegistar.Visible = false;
                btRegComp.Visible = false;
                btConsultar.Visible = false;
                pbLogo.Visible = false;

                Registo registar = new Registo(this)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                panel1.Visible = true;
                panel1.Controls.Clear();
                panel1.Controls.Add(registar);
                registar.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário de registo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btRegComp_Click(object sender, EventArgs e)
        {
            try
            {
                btRegistar.Visible = false;
                btRegComp.Visible = false;
                btConsultar.Visible = false;
                pbLogo.Visible = false;

                RegComp registar = new RegComp(this)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                panel1.Visible = true;
                panel1.Controls.Clear();
                panel1.Controls.Add(registar);
                registar.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário de registo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                btRegistar.Visible = false;
                btRegComp.Visible = false;
                btConsultar.Visible = false;
                pbLogo.Visible = false;

                Consultar registar = new Consultar(this)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                panel1.Visible = true;
                panel1.Controls.Clear();
                panel1.Controls.Add(registar);
                registar.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar abrir o formulário de consulta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
