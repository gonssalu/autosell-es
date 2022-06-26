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
    public partial class AutoSell : Form
    {
        public AutoSell()
        {
            InitializeComponent();
        }

        private void AutoSell_Load(object sender, EventArgs e)
        {
            RandomHelper.PREENCHER();
            Cursor.Current = Cursors.WaitCursor;
            cmbLojas.DataSource = Dados.LOJAS;
        }
        private void AutoSell_Shown(object sender, EventArgs e)
        {
            RandomHelper.PREENCHER();

            //Veiculos
            cmbLojas.DataSource = Dados.LOJAS;

            //Eventos
            cmbTipoDestino.SelectedIndex = 0;
            cmbDestino.DataSource = Dados.LOJAS;
            lstEventos.DataSource = Dados.EVENTOS;

            Cursor.Current = Cursors.Default;
        }

        private void btnAdicionarVeiculo_Click(object sender, EventArgs e)
        {
            var dadosVeiculo = new DadosVeiculoForm(cmbLojas.SelectedIndex);
            dadosVeiculo.ShowDialog();

            var veiculos = new List<Veiculo>();

            foreach (var veiculo in Dados.LOJAS[cmbLojas.SelectedIndex].Garagem)
                veiculos.Add(veiculo);

            lboxVeiculos.DataSource = veiculos;
        }

        private void btnEditarVeiculo_Click(object sender, EventArgs e)
        {
            var dadosVeiculo = new DadosVeiculoForm(cmbLojas.SelectedIndex, lboxVeiculos.SelectedIndex);
            dadosVeiculo.ShowDialog();

            var veiculos = new List<Veiculo>();

            foreach (var veiculo in Dados.LOJAS[cmbLojas.SelectedIndex].Garagem)
                veiculos.Add(veiculo);

            lboxVeiculos.DataSource = veiculos;
        }

        private void cmbLojas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxVeiculos.DataSource = Dados.LOJAS[cmbLojas.SelectedIndex].Garagem;
        }

        private void btnApagarVeiculo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente apagar o veículo?", "Confirmação", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation) == DialogResult.No)
                return;

            var veiculo = (Veiculo) lboxVeiculos.SelectedItem;
            Dados.LOJAS[cmbLojas.SelectedIndex].Garagem.Remove(veiculo);
            lboxVeiculos.DataSource = null;
            lboxVeiculos.DataSource = Dados.LOJAS[cmbLojas.SelectedIndex].Garagem;
        }
    }
}
