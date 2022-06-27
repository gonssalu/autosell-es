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
    public partial class SelecionarVeiculos : Form
    {
        public List<Veiculo> veiculosSelected = new();
        public List<Veiculo> veiculos = new();
        public bool done = false;

        public SelecionarVeiculos()
        {
            InitializeComponent();
        }

        public void PrepararListasVeiculos(List<Veiculo> vvs)
        {
            veiculosSelected = vvs;
            for (int i = 0; i<Dados.LOJAS.Count; i++)
                foreach(Veiculo v in Dados.LOJAS[i].Garagem)
                    if(!veiculosSelected.Contains(v))
                        veiculos.Add(v);

            lstFirst.DataSource = veiculos;
        }

        private void SelecionarVeiculos_Load(object sender, EventArgs e)
        {

            lstSecond.DataSource = veiculosSelected;
        }
        
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            veiculosSelected.Add((Veiculo)lstFirst.Items[lstFirst.SelectedIndex]);
            veiculos.RemoveAt(lstFirst.SelectedIndex);
            RefreshLists();
        }

        private void RefreshLists()
        {
            lstSecond.DataSource = null;
            lstFirst.DataSource = null;
            lstSecond.DataSource = veiculosSelected;
            lstFirst.DataSource = veiculos;
        }

        private void lstFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFirst.SelectedIndex != -1)
            {
                lstSecond.SelectedIndex = -1;
                btnSelecionar.Enabled = true;
                btnDesselecionar.Enabled = false;
            }
        }

        private void lstSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSecond.SelectedIndex != -1)
            {
                lstFirst.SelectedIndex = -1;
                btnDesselecionar.Enabled = true;
                btnSelecionar.Enabled = false;
            }
        }

        private void btnDesselecionar_Click(object sender, EventArgs e)
        {
            veiculos.Add((Veiculo)lstSecond.Items[lstSecond.SelectedIndex]);
            veiculosSelected.RemoveAt(lstSecond.SelectedIndex);
            RefreshLists();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            done = true;
            Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
