using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autosell
{
    public partial class DadosVeiculoForm : Form
    {
        private readonly int _lojaId;
        private readonly int _veiculoId;

        public DadosVeiculoForm(int lojaId, int veiculoId = -1)
        {
            InitializeComponent();

            _lojaId = lojaId;
            _veiculoId = veiculoId;
            cmbCombustivel.DataSource = Enum.GetValues(typeof(TipoCombustivel));

            if (veiculoId == -1) return;

            txtMarca.Text = Dados.LOJAS[_lojaId].Garagem[veiculoId].Marca;
            txtModelo.Text = Dados.LOJAS[_lojaId].Garagem[veiculoId].Modelo;
            txtAno.Text = Dados.LOJAS[_lojaId].Garagem[veiculoId].Ano.ToString();
            txtCor.Text = Dados.LOJAS[_lojaId].Garagem[veiculoId].Cor;
            txtKms.Text = Dados.LOJAS[_lojaId].Garagem[veiculoId].KmsPercorridos.ToString(CultureInfo.InvariantCulture);
            txtPreco.Text = Dados.LOJAS[_lojaId].Garagem[veiculoId].Preco.ToString(CultureInfo.InvariantCulture);
            txtNumDonos.Text = Dados.LOJAS[_lojaId].Garagem[veiculoId].NrDonos.ToString();
            txtDonoAnterior.Text = Dados.LOJAS[_lojaId].Garagem[veiculoId].NomeDonoAnterior;
            cmbCombustivel.SelectedItem = Dados.LOJAS[_lojaId].Garagem[veiculoId].Combustivel;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "" || txtModelo.Text == "" || txtAno.Text == "" || cmbCombustivel.SelectedItem == null ||
                txtCor.Text == "" || txtPreco.Text == "" || txtKms.Text == "" || txtNumDonos.Text == "") {
                MessageBox.Show("Preencha os campos obrigatórios!");
                return;
            }

            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            var combustivel = (TipoCombustivel) Enum.Parse(typeof(TipoCombustivel), cmbCombustivel.Text);
            string cor = txtCor.Text;
            string donoAnterior = txtDonoAnterior.Text;

            if (!int.TryParse(txtAno.Text, out int ano)) {
                MessageBox.Show("Ano inválido!");
                return;
            }

            if (!double.TryParse(txtPreco.Text, out double preco)) {
                MessageBox.Show("Preço inválido!");
                return;
            }

            if (!double.TryParse(txtKms.Text, out double kms)) {
                MessageBox.Show("Kms inválido!");
                return;
            }

            if (!int.TryParse(txtNumDonos.Text, out int numDonos)) {
                MessageBox.Show("Número de donos inválido!");
                return;
            }

            var veiculo = new Veiculo(marca, modelo, ano, combustivel, cor, preco, kms, numDonos, donoAnterior, _lojaId);

            try {
                if (_veiculoId == -1)
                    Dados.LOJAS[_lojaId].Garagem.Add(veiculo);
                else
                    Dados.LOJAS[_lojaId].Garagem[_veiculoId] = veiculo;
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro no registo do veículo: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Veículo registado com sucesso", "Registo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
