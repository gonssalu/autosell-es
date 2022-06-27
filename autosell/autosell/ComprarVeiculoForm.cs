using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autosell
{
    public partial class ComprarVeiculoForm : Form
    {
        private readonly int _lojaId;

        public ComprarVeiculoForm(int lojaId)
        {
            InitializeComponent();
            _lojaId = lojaId;
            cmbClientes.DataSource = Dados.CLIENTES;
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            var dadosCliente = new DadosClienteForm();
            dadosCliente.ShowDialog();

            cmbClientes.DataSource = null;
            cmbClientes.DataSource = Dados.CLIENTES;
            cmbClientes.SelectedIndex = Dados.CLIENTES.Count - 1;
        }

        private void btnRegistarVeiculo_Click(object sender, EventArgs e)
        {
            var dadosVeiculo = new DadosVeiculoForm(_lojaId);
            dadosVeiculo.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var tipo = TipoTransacao.Compra;
            var veiculo = Dados.LOJAS[_lojaId].Garagem.Last();
            double valor = Dados.LOJAS[_lojaId].Garagem.Last().Preco;
            var cliente = Dados.CLIENTES[cmbClientes.SelectedIndex];
            var data = DateTime.Now;

            var transacao = new Transacao(tipo, veiculo, valor, cliente, data);

            try {
                Dados.TRANSACOES.Add(transacao);
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro ao efetuar a transação: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Transação efetuada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
