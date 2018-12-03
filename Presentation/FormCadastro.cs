using Business;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormCadastro : Form
    {
        private Consultas consulta;
        private Validacao validacao;

        public FormCadastro()
        {
            InitializeComponent();
            consulta = new Consultas();
            validacao = new Validacao();
        }

        private void btnNewConta_Click(object sender, EventArgs e)
        {
            if (validacao.ValidaValor(txtSaldoIni.Text) && !string.IsNullOrWhiteSpace(txtNomeCad.Text))
            {
                consulta.InsereConta(txtNomeCad.Text, txtSaldoIni.Text.Replace(",", "."));
                MessageBox.Show("Conta criada com sucesso!");
            }
            else { MessageBox.Show("Dados inválidos!"); }

            Close();
        }
    }
}