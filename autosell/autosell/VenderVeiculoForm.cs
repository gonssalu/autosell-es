namespace autosell
{
    public partial class VenderVeiculoForm : Form
    {
        private readonly int _lojaId;

        public VenderVeiculoForm(int lojaId)
        {
            InitializeComponent();
            _lojaId = lojaId;
            cmbClientes.DataSource = Dados.CLIENTES;
            cmbVeiculos.DataSource = Dados.LOJAS[_lojaId].Garagem;
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

            var tipo = TipoTransacao.Venda;
            var veiculo = Dados.LOJAS[_lojaId].Garagem[cmbVeiculos.SelectedIndex];
            double valor = double.Parse(txtValor.Text);
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
