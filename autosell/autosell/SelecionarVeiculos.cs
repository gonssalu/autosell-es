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
        public int cmb1idx = -1;
        public int cmb2idx = -1;
        private bool transferMode = false;

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

        public void PrepararLojas()
        {
            foreach(Loja l in Dados.LOJAS)
            {
                cmbLoja1.Items.Add(l);
                cmbLoja2.Items.Add(l);
            }
            cmbLoja2.SelectedIndex = 1;
            cmbLoja1.SelectedIndex = 0;
            cmbLoja2.Enabled = true;
            cmbLoja1.Enabled = true;
            cmbLoja2.Visible = true;
            cmbLoja1.Visible = true;
            this.Text = "Transferir Veículos";
            btnSelecionar.Text = "->";
            btnDesselecionar.Text = "<-";
            transferMode = true;
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
            if (lstFirst.SelectedIndex != -1 && !(transferMode && (cmb1idx == -1 || cmb2idx == -1 || cmb1idx == cmb2idx)))
            {
                lstSecond.SelectedIndex = -1;
                btnSelecionar.Enabled = true;
                btnDesselecionar.Enabled = false;
            }
        }

        private void lstSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSecond.SelectedIndex != -1 && !(transferMode && (cmb1idx == -1 || cmb2idx == -1 || cmb1idx == cmb2idx)))
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

        private void MostrarErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmbLoja1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb1idx = cmbLoja1.SelectedIndex;
            if (cmbLoja1.SelectedIndex == cmbLoja2.SelectedIndex && cmbLoja1.SelectedIndex!=-1)
            {
                MostrarErro("A loja de destino deve ser diferente da loja de origem.");
                btnSelecionar.Enabled = false;
                btnDesselecionar.Enabled = false;
                return;
            }
            lstFirst.DataSource = null;
            if (cmbLoja1.SelectedIndex == -1)
            {
                return;
            }
            veiculos.Clear();
            foreach (Veiculo v in Dados.LOJAS[cmbLoja1.SelectedIndex].Garagem)
                 veiculos.Add(v);
            lstFirst.DataSource = veiculos;
            btnSelecionar.Enabled = true;
            btnDesselecionar.Enabled = true;
        }

        private void cmbLoja2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb2idx = cmbLoja2.SelectedIndex;
            if (cmbLoja1.SelectedIndex == cmbLoja2.SelectedIndex && cmbLoja2.SelectedIndex != -1)
            {
                MostrarErro("A loja de destino deve ser diferente da loja de origem.");
                btnSelecionar.Enabled = false;
                btnDesselecionar.Enabled = false;
                return;
            }
            lstSecond.DataSource = null;
            if (cmbLoja2.SelectedIndex == -1)
            {
                return;
            }
            veiculosSelected.Clear();
            foreach (Veiculo v in Dados.LOJAS[cmbLoja2.SelectedIndex].Garagem)
                veiculosSelected.Add(v);
            lstSecond.DataSource = veiculosSelected;
            btnSelecionar.Enabled = true;
            btnDesselecionar.Enabled = true;
        }
    }
}
