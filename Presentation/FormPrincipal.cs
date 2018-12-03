using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormPrincipal : Form
    {
        private Consultas consulta;
        private Validacao validacao;

        public FormPrincipal()
        {
            InitializeComponent();
            consulta = new Consultas();
            validacao = new Validacao();
        }

        #region Abrir Conta
        private void btnAbrirConta_Click(object sender, EventArgs e)
        {
            Form formCadastro = new FormCadastro();
            formCadastro.ShowDialog();
            Clear();
        }
        #endregion

        #region Listar Contas
        private void btnListarContas_Click(object sender, EventArgs e)
        {
            DataSet ds = consulta.ListarContas();
            
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataGridView dataGrid = new DataGridView();
                Form formContas = new Form();
                
                dataGrid.DataSource = ds.Tables[0];
                dataGrid.RowHeadersVisible = false; //Remove cabeçalho da linha
                dataGrid.Dock = DockStyle.Fill; // Expande tamanho do Grid

                formContas.Text = "Contas";
                formContas.Controls.Add(dataGrid);
                formContas.ShowDialog();
            }
            else { MessageBox.Show("Nenhuma conta cadastrada!"); }
        }
        #endregion

        #region Consultar Conta
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<string> DadosConta;

            if (!String.IsNullOrWhiteSpace(txtNumConta.Text) && validacao.ValidaConta(txtNumConta.Text))
            {
                DadosConta = consulta.ConsultarConta(txtNumConta.Text);

                if (DadosConta.Count > 0)
                {
                    txtNome.Text = DadosConta[0];
                    txtValorReal.Text = DadosConta[1];
                    txtValorDolar.Text = DadosConta[2];
                }
                else { MessageBox.Show("Digite uma conta válida!"); Clear(); }
            }
        }
        #endregion

        #region Crédito
        private void btnCredito_Click(object sender, EventArgs e)
        {
            if (validacao.ValidaConta(txtContaTransact.Text) && validacao.ValidaValor(txtValorTransact.Text))
            {
                if (consulta.ExecutaTransacao(txtContaTransact.Text, txtValorTransact.Text.Replace(",", ".")))
                {
                    MessageBox.Show("Valor creditado com sucesso!");
                }
                else { MessageBox.Show("Conta inválida!"); }                
            }
            else { MessageBox.Show("Conta ou valor inválido!"); }

            Clear();
        }
        #endregion

        #region Débito
        private void btnDebito_Click(object sender, EventArgs e)
        {
            if (validacao.ValidaConta(txtContaTransact.Text) && validacao.ValidaValor(txtValorTransact.Text))
            {
                if (consulta.ExecutaTransacao(txtContaTransact.Text, "-" + txtValorTransact.Text.Replace(",", ".")))
                {
                    MessageBox.Show("Valor debitado com sucesso!");
                }
                else { MessageBox.Show("Conta inválida ou Saldo insulficiente!"); }
            }
            else { MessageBox.Show("Conta ou valor inválido!"); }

            Clear();
        }
        #endregion

        #region Limpar campos
        private void Clear()
        {
            txtNome.Clear();
            txtNumConta.Clear();
            txtValorReal.Clear();
            txtValorDolar.Clear();
            txtContaTransact.Clear();
            txtValorTransact.Clear();
        }
        #endregion
    }
}