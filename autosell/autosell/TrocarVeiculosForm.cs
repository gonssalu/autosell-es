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
    public partial class TrocarVeiculosForm : Form
    {
        private readonly int _lojaId;

        public TrocarVeiculosForm(int lojaId)
        {
            InitializeComponent();
            _lojaId = lojaId;
            cmbClientes.DataSource = Dados.CLIENTES;
            cmbVeiculos.DataSource = Dados.LOJAS[_lojaId].Garagem;
        }

        private void btnRegistarVeiculo_Click(object sender, EventArgs e)
        {
            var dadosVeiculo = new DadosVeiculoForm(_lojaId);
            dadosVeiculo.ShowDialog();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            var dadosCliente = new DadosClienteForm();
            dadosCliente.ShowDialog();

            cmbClientes.DataSource = null;
            cmbClientes.DataSource = Dados.CLIENTES;
            cmbClientes.SelectedIndex = Dados.CLIENTES.Count - 1;
        }

        private void btnPrepararVeiculo_Click(object sender, EventArgs e)
        {
            var prepararVeiculo = new PrepararVeiculoForm();
            prepararVeiculo.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedIndex == -1) {
                MessageBox.Show("Selecione um cliente");
                return;
            }

            if (cmbVeiculos.SelectedIndex == -1) {
                MessageBox.Show("Selecione um veículo");
                return;
            }

            if (!double.TryParse(txtValor.Text, out double _)) {
                MessageBox.Show("Valor inválido");
                return;
            }

            var tipo = TipoTransacao.Troca;
            var veiculo = Dados.LOJAS[_lojaId].Garagem[cmbVeiculos.SelectedIndex];
            double valor = double.Parse(txtValor.Text);
            var cliente = Dados.CLIENTES[cmbClientes.SelectedIndex];
            var veiculoRecebido = Dados.LOJAS[_lojaId].Garagem.Last();

            var transacao = new Transacao(tipo, veiculo, valor, cliente, veiculoRecebido);

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
