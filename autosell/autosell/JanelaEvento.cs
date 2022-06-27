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
    public partial class JanelaEvento : Form
    {
        public int idxEvento = -1;
        public bool done = false;
        public List<Veiculo> veiculos = new();

        public JanelaEvento()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void UpdateLabel()
        {
            if (idxEvento != -1)
                lblVeiAss.Text = "Veículos associados: " + Dados.EVENTOS[idxEvento].Garagem.Count;
        }

        private void UpdateLabel(int val)
        {
             lblVeiAss.Text = "Veículos associados: " + val;
        }

        private void JanelaEvento_Load(object sender, EventArgs e)
        {
            if (idxEvento == -1)
            {
                dtpInicio.Value = DateTime.Now;
                dtpFim.Value = DateTime.Now;
            }
            PreencherListaLojas();
        }

        public void MostrarEsteEvento(int eventoIdx)
        {
            idxEvento = eventoIdx;
            PreencherValoresEvento();
            btnAgendar.Enabled = false;
            btnAgendar.Visible = false;
            btnAssociarVeiculos.Enabled = false;
            btnAssociarVeiculos.Visible = false;

            chkForaLoja.Enabled = false;
            txtNome.ReadOnly = true;
            txtOutroLocal.ReadOnly = true;
            dtpInicio.Enabled = false;
            dtpFim.Enabled = false;
            cmbLojas.Enabled = false;

            chkForaLoja.Visible = false;
            cmbLojas.Visible = false;
            label2.Visible = false;
            label3.Text = "Morada:";
            label3.Location = new Point(59, 169);
        }

        private void PreencherValoresEvento()
        {
            txtNome.Text = Dados.EVENTOS[idxEvento].Nome;
            chkForaLoja.Checked = true;
            txtOutroLocal.Text = Dados.EVENTOS[idxEvento].Morada;
            dtpInicio.Value = Dados.EVENTOS[idxEvento].DataInicio;
            dtpFim.Value = Dados.EVENTOS[idxEvento].DataFim;
            this.Text = "Evento \""+txtNome.Text+"\"";
            UpdateLabel();
        }

        public void EditarEsteEvento(int eventoIdx)
        {
            idxEvento = eventoIdx;
            PreencherValoresEvento();
            btnAgendar.Enabled = false;
            btnAgendar.Visible = false;
            btnAssociarVeiculos.Enabled = false;
            btnGuardar.Enabled = true;
            btnGuardar.Visible = true;
        }

        private void PreencherListaLojas()
        {
            cmbLojas.DataSource = null;
            cmbLojas.DataSource = Dados.LOJAS;
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            if (!FazerVerificacoes())
                return;
            Evento ev = new Evento(txtNome.Text, chkForaLoja.Checked ? txtOutroLocal.Text : Dados.LOJAS[cmbLojas.SelectedIndex].Morada, dtpInicio.Value, dtpFim.Value);
            Dados.GuardarEvento(ev);
            foreach(Veiculo v in veiculos)
            {
                for(int i = 0; i<Dados.LOJAS.Count; i++)
                {
                    if (Dados.LOJAS[i].IdLocal == v.IdLocal)
                        Dados.MudarLocalVeiculo(v, Dados.LOJAS[i], ev);
                }
            }
            done = true;
            Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!FazerVerificacoes())
                return;
            Dados.EVENTOS[idxEvento].Nome = txtNome.Text;
            Dados.EVENTOS[idxEvento].Morada = chkForaLoja.Checked ? txtOutroLocal.Text : Dados.LOJAS[cmbLojas.SelectedIndex].Morada;
            Dados.EVENTOS[idxEvento].DataInicio = dtpInicio.Value;
            Dados.EVENTOS[idxEvento].DataFim = dtpFim.Value;
            done = true;
            Hide();
        }

        private bool FazerVerificacoes()
        {
            if (txtNome.Text == "")
            {
                MostrarErro("Não preencheu o campo nome!");
                return false;
            }
            if (chkForaLoja.Checked)
            {
                if (txtOutroLocal.Text == "")
                {
                    MostrarErro("Não é possível criar um evento sem um local/loja!");
                    return false;
                }
            }
            else
            {
                if (cmbLojas.SelectedIndex == -1)
                {
                    MostrarErro("Não é possível criar um evento sem um local/loja!");
                    return false;
                }
            }

            if (dtpInicio.Value > dtpFim.Value)
            {
                MostrarErro("A data de início da Estatística 1 não pode ser posterior à data de fim!");
                return false;
            }
                
            return true;
        }

        private void MostrarErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void chkForaLoja_CheckedChanged(object sender, EventArgs e)
        {
            cmbLojas.Enabled = !chkForaLoja.Checked;
            txtOutroLocal.Enabled = chkForaLoja.Checked;
            txtOutroLocal.ReadOnly = !chkForaLoja.Checked;
        }

        private void btnAssociarVeiculos_Click(object sender, EventArgs e)
        {
            SelecionarVeiculos sv = new SelecionarVeiculos();
            sv.PrepararListasVeiculos(veiculos);
            sv.ShowDialog();
            veiculos = sv.veiculosSelected;
            UpdateLabel(veiculos.Count);
        }
    }
}
