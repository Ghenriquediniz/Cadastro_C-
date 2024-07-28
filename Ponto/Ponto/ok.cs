using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ponto
{
    public partial class ok : Form
    {
        public ok()
        {
            InitializeComponent();
        }

        private void ok_Load(object sender, EventArgs e)
        {
            string mensagem = "Cadastro realizado com sucesso";
            string titulo = "Sucesso";
            MessageBoxButtons botoes = MessageBoxButtons.OK;
            MessageBoxIcon icone = MessageBoxIcon.Information;

            // Exibe o MessageBox
            MessageBox.Show(mensagem, titulo, botoes, icone);
        }
    }
}
