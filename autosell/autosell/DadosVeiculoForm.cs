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
    public partial class DadosVeiculoForm : Form
    {
        private int _lojaId;

        public DadosVeiculoForm(int lojaId)
        {
            InitializeComponent();

            _lojaId = lojaId;
            cmbCombustivel.DataSource = Enum.GetValues(typeof(TipoCombustivel));
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
                Dados.LOJAS[_lojaId].Garagem.Add(veiculo);
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro no registo do veículo: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Veículo registado com sucesso", "Registo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }
    }
}
