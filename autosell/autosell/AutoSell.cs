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

            //Veiculos
            cmbLojasVeiculos.DataSource = Dados.LOJAS;

            //Eventos
            cmbTipoDestino.SelectedIndex = 0;
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
            foreach (Evento ev in Dados.EVENTOS)
                lstEventos.Items.Add(ev);
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
            lstEventos.Items.RemoveAt(idx);
            if (cmbTipoDestino.SelectedIndex == 1)
                PreencherComTodosOsEventos();
            return ev.Nome;
        }

        private void cmbTipoDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoDestino.SelectedIndex == 0)
                PreencherComTodasAsLojas();
            else if (cmbTipoDestino.SelectedIndex == 1)
                PreencherComTodosOsEventos();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (cmbTipoDestino.SelectedIndex == 1) {
                if (cmbDestino.Items[cmbDestino.SelectedIndex] == lstEventos.Items[lstEventos.SelectedIndex]) {
                    MostrarErro("Não podes enviar os veículos para o mesmo evento!");
                    return;
                }
            }
        }

        private void PreencherComTodasAsLojas()
        {
            cmbDestino.DataSource = null;
            cmbDestino.DataSource = Dados.LOJAS;
        }
        private void PreencherComTodosOsEventos()
        {
            cmbDestino.DataSource = null;
            cmbDestino.DataSource = Dados.EVENTOS;
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
    }
}
