using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace autosell
{
    public partial class PrepararVeiculoForm : Form
    {
        private int totalPecas = 0;

        public PrepararVeiculoForm()
        {
            InitializeComponent();
            lboxPecasSede.DataSource = Dados.PECAS;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(Interaction.InputBox("Quantidade:", "Quantidade", "1"));

            if (quantidade <= 0) {
                MessageBox.Show("Quantidade deve ser maior que 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dados.PECAS[lboxPecasSede.SelectedIndex].Unidades -= quantidade;

            if (Dados.PECAS[lboxPecasSede.SelectedIndex].Unidades < Dados.PECAS[lboxPecasSede.SelectedIndex].StockMinimo) {
                MessageBox.Show("Não há quantidade suficiente para a peça selecionada", "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Dados.PECAS[lboxPecasSede.SelectedIndex].Unidades += quantidade;
                return;
            }

            lboxPecasUtilizar.Items.Add(Dados.PECAS[lboxPecasSede.SelectedIndex].Nome);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(Interaction.InputBox("Quantidade:", "Quantidade", "1"));

            if (quantidade <= 0) {
                MessageBox.Show("Quantidade deve ser maior que 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dados.PECAS[lboxPecasSede.SelectedIndex].Unidades += quantidade;
            lboxPecasUtilizar.Items.RemoveAt(lboxPecasUtilizar.SelectedIndex);
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pecas guardadas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
