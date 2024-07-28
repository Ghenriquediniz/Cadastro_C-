using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ponto
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            email_TextBox2.MaxLength = 10;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novo_Click(object sender, EventArgs e)
        {

        }

        private void CNPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void IE_TextChanged(object sender, EventArgs e)
        {

        }

        private void EMAIL_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void email_TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RAZAO_TextChanged(object sender, EventArgs e)
        {

        }

        private void FANTASIA_TextChanged(object sender, EventArgs e)
        {

        }

        private void RUACOMPLEMENTO_TextChanged(object sender, EventArgs e)
        {

        }

        private void N_TextChanged(object sender, EventArgs e)
        {

        }

        private void COMPLEMENTO_TextChanged(object sender, EventArgs e)
        {

        }

        private void BAIRRO_TextChanged(object sender, EventArgs e)
        {

        }

        private void MUNICI_TextChanged(object sender, EventArgs e)
        {

        }

        private void UF_TextChanged(object sender, EventArgs e)
        {

        }

        private void PAIS_TextChanged(object sender, EventArgs e)
        {

        }

        private void cep_extBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NOME_TextChanged(object sender, EventArgs e)
        {

        }

        private void DD_TextChanged(object sender, EventArgs e)
        {

        }

        private void WAHTS_TextChanged(object sender, EventArgs e)
        {

        }

        private void gravar_Click(object sender, EventArgs e)
        {
            CNPJ.Text = string.Empty;
            IE.Text = string.Empty;
            email_TextBox2.Text = string.Empty;
            RAZAO.Text = string.Empty;
            FANTASIA.Text = string.Empty;
            RUACOMPLEMENTO.Text = string.Empty;
            N.Text = string.Empty;
            COMPLEMENTO.Text = string.Empty;
            BAIRRO.Text = string.Empty;
            MUNICI.Text = string.Empty;
            UF.Text = string.Empty;
            PAIS.Text = string.Empty;
            cep_extBox1.Text = string.Empty;
            NOME.Text = string.Empty;
            DD.Text = string.Empty;
            WAHTS.Text = string.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            tela_ok();
        }

        private void tela_ok()
        {
            string mensagem = "Cadastro realizado com sucesso";
            string titulo = "Sucesso";
            MessageBoxButtons botoes = MessageBoxButtons.OK;
            MessageBoxIcon icone = MessageBoxIcon.Information;

            // Exibe o MessageBox
            MessageBox.Show(this, mensagem, titulo, botoes, icone);
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            
        }
    }
}
