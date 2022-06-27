﻿using System;
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
            Cursor.Current = Cursors.WaitCursor;
        }

        private void AutoSell_Shown(object sender, EventArgs e)
        {
            RandomHelper.PREENCHER();

            //Clientes
            lboxClientes.DataSource = Dados.CLIENTES;

            // Veículos
            cmbLojasVeiculos.DataSource = Dados.LOJAS;

            // Eventos
            cmbTipoDestino.SelectedIndex = 1;
            AtualizarListaEventos();

            Cursor.Current = Cursors.Default;
        }

        #region Gerir Veiculos

        private void btnConsultarVeiculo_Click(object sender, EventArgs e)
        {
            var dadosVeiculo = new DadosVeiculoForm(cmbLojasVeiculos.SelectedIndex, lboxVeiculos.SelectedIndex, true);
            dadosVeiculo.ShowDialog();
        }


        private void btnAdicionarVeiculo_Click(object sender, EventArgs e)
        {
            var dadosVeiculo = new DadosVeiculoForm(cmbLojasVeiculos.SelectedIndex);
            dadosVeiculo.ShowDialog();

            var veiculos = new List<Veiculo>();

            foreach (var veiculo in Dados.LOJAS[cmbLojasVeiculos.SelectedIndex].Garagem)
                veiculos.Add(veiculo);

            lboxVeiculos.DataSource = veiculos;
        }

        private void btnEditarVeiculo_Click(object sender, EventArgs e)
        {
            var dadosVeiculo = new DadosVeiculoForm(cmbLojasVeiculos.SelectedIndex, lboxVeiculos.SelectedIndex);
            dadosVeiculo.ShowDialog();

            var veiculos = new List<Veiculo>();

            foreach (var veiculo in Dados.LOJAS[cmbLojasVeiculos.SelectedIndex].Garagem)
                veiculos.Add(veiculo);

            lboxVeiculos.DataSource = veiculos;
        }

        private void cmbLojasVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxVeiculos.DataSource = Dados.LOJAS[cmbLojasVeiculos.SelectedIndex].Garagem;
        }

        private void btnApagarVeiculo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente apagar o veículo?", "Confirmação", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation) == DialogResult.No)
                return;

            var veiculo = (Veiculo) lboxVeiculos.SelectedItem;
            Dados.LOJAS[cmbLojasVeiculos.SelectedIndex].Garagem.Remove(veiculo);
            lboxVeiculos.DataSource = null;
            lboxVeiculos.DataSource = Dados.LOJAS[cmbLojasVeiculos.SelectedIndex].Garagem;
        }

        #endregion

        #region Gerir Eventos

        public void AtualizarListaEventos()
        {
            lstEventos.DataSource = null;
            lstEventos.DataSource = Dados.EVENTOS;
        }

        private void EditarEventoClick(object sender, EventArgs e)
        {
            if (!SelecionouEvento()) return;
        }

        private void ConsultarEventoClick(object sender, EventArgs e)
        {
            if (!SelecionouEvento()) return;
        }

        private void AgendarEventoClick(object sender, EventArgs e)
        {
        }

        private void btnApagarEvento_Click(object sender, EventArgs e)
        {
            if (!SelecionouEvento()) return;
            MostrarSucesso("Evento \"" + RemoverEvento() + "\" removido com sucesso!");
        }
        
        private string RemoverEvento()
        {
            int idx = lstEventos.SelectedIndex;
            Evento ev = (Evento)lstEventos.Items[idx];
            Dados.RemoverEvento(ev);
            AtualizarListaEventos();
            if (cmbTipoDestino.SelectedIndex == 1)
                PreencherComTodosOsEventos();
            return ev.Nome;
        }

        private void cmbTipoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherDestino();
        }

        private void PreencherDestino()
        {
            if(lstEventos.SelectedIndex!=-1)
                if (cmbTipoDestino.SelectedIndex == 0)
                    PreencherComTodasAsLojas();
                else if (cmbTipoDestino.SelectedIndex == 1)
                    PreencherComTodosOsEventos();
            if (cmbDestino.Items.Count > 0)
                cmbDestino.SelectedIndex = 0;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (!SelecionouEvento())
                return;

            if (cmbDestino.SelectedIndex == -1 || cmbDestino.SelectedItem==null)
            {
                MostrarErro("Tem de selecionar um destino válido!");
                return;
            }

            if (cmbTipoDestino.SelectedIndex == 1) {
                if (cmbDestino.Items[cmbDestino.SelectedIndex] == lstEventos.Items[lstEventos.SelectedIndex]) {
                    MostrarErro("Não podes enviar os veículos para o mesmo evento!");
                    return;
                }
            }

            Evento ev = GetSelectedEvento();
            Local destino = (Local)cmbDestino.SelectedItem;
            if (cmbTipoDestino.SelectedIndex == 0)
            {
                Loja lj = (Loja)destino;
                if (ev.Garagem.Count > lj.TamanhoGaragem - lj.Garagem.Count)
                {
                    MostrarErro("Essa loja não tem espaço para todos os veículos deste evento!");
                    return;
                }
            }

            ev.Terminado = true;

            Veiculo[] vcs = new Veiculo[ev.Garagem.Count];
            ev.Garagem.CopyTo(vcs);
            foreach (Veiculo ve in vcs)
                Dados.MudarLocalVeiculo(ve, ev, destino);
            
            AtualizarListaEventos();
        }

        private Evento GetSelectedEvento()
        {
            return (Evento)lstEventos.Items[lstEventos.SelectedIndex];
        }

        private void PreencherComTodasAsLojas()
        {
            cmbDestino.Items.Clear();
            Evento ev = GetSelectedEvento();
            foreach (Loja lj in Dados.LOJAS)
            {
                if (lj.Garagem.Count + ev.Garagem.Count <= lj.TamanhoGaragem)
                    cmbDestino.Items.Add(lj);
            }
            if (cmbDestino.Items.Count == 0)
            {
                MessageBox.Show("Não há nenhuma loja com espaço suficiente para os veículos desse evento!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipoDestino.SelectedIndex = 1;
            }
        }
        private void PreencherComTodosOsEventos()
        {
            cmbDestino.Items.Clear();
            foreach (Evento ev in Dados.EVENTOS)
                cmbDestino.Items.Add(ev);
        }

        private bool SelecionouEvento()
        {
            if (lstEventos.SelectedIndex == -1)
            {
                MostrarErro("Tem de selecionar um evento!");
                return false;
            }
            return true;
        }

        #endregion

        #region Gerir Clientes

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
        }

        private void btnApagarCliente_Click(object sender, EventArgs e)
        {
            if (!SelecionouCliente()) return;
            MostrarSucesso("Cliente \"" + RemoverCliente() + "\" apagado com sucesso!");
        }
        private string RemoverCliente()
        {
            int idx = lboxClientes.SelectedIndex;
            Cliente cl = (Cliente)lboxClientes.Items[idx];
            Dados.RemoverCliente(cl);
            lboxClientes.DataSource = null;
            lboxClientes.DataSource = Dados.CLIENTES;
            return cl.Nome;
        }

        private bool SelecionouCliente()
        {
            if (lboxClientes.SelectedIndex == -1)
            {
                MostrarErro("Tem de selecionar um cliente!");
                return false;
            }
            return true;
        }

        #endregion


        #region Outras coisas

        public void MostrarErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MostrarSucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        private void lstEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEventos.SelectedIndex == -1)
            {
                cmbTipoDestino.Enabled = false;
                cmbDestino.Enabled = false;
                btnFinalizar.Enabled = false;
                cmbDestino.DataSource = null;
            }
            else
            {
                PreencherDestino();
                cmbTipoDestino.Enabled = true;
                cmbDestino.Enabled = true;
                btnFinalizar.Enabled = true;
            }
        }
    }
}
