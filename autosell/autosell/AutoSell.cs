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

            // Clientes
            lboxClientes.DataSource = Dados.CLIENTES;

            // Transações
            lboxTransacoes.DataSource = Dados.TRANSACOES;
            cmbLojasTransacoes.DataSource = Dados.LOJAS;

            //Estatísticas
            dtpInicio1.Value = DateTime.Now;
            dtpInicio2.Value = DateTime.Now;
            dtpFim1.Value = DateTime.Now;
            dtpFim2.Value = DateTime.Now;

            Cursor.Current = Cursors.Default;
        }

        #region Gerir Veiculos

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            SelecionarVeiculos sv = new SelecionarVeiculos();
            sv.PrepararLojas();
            sv.ShowDialog();
            if (sv.done)
            {
                foreach (Veiculo v in sv.veiculos)
                {
                    if (v.IdLocal != Dados.LOJAS[sv.cmb1idx].IdLocal)
                        Dados.MudarLocalVeiculo(v, Dados.LOJAS[sv.cmb2idx], Dados.LOJAS[sv.cmb1idx]);
                }

                foreach (Veiculo v in sv.veiculosSelected)
                {
                    if (v.IdLocal != Dados.LOJAS[sv.cmb2idx].IdLocal)
                        Dados.MudarLocalVeiculo(v, Dados.LOJAS[sv.cmb1idx], Dados.LOJAS[sv.cmb2idx]);
                }

                AtualizarListaVeiculos();

                MostrarSucesso("Os veículos foram transferidos com sucesso!");
                
            }
        }

        private void AtualizarListaVeiculos()
        {
            var veiculos = new List<Veiculo>();

            foreach (var veiculo in Dados.LOJAS[cmbLojasVeiculos.SelectedIndex].Garagem)
                veiculos.Add(veiculo);

            lboxVeiculos.DataSource = veiculos;
        }

        private void btnConsultarVeiculo_Click(object sender, EventArgs e)
        {
            if (!SelecionouVeiculo()) return;
            var dadosVeiculo = new DadosVeiculoForm(cmbLojasVeiculos.SelectedIndex, lboxVeiculos.SelectedIndex, true);
            dadosVeiculo.ShowDialog();
        }


        private void btnAdicionarVeiculo_Click(object sender, EventArgs e)
        {
            if (!SelecionouVeiculo()) return;

            var dadosVeiculo = new DadosVeiculoForm(cmbLojasVeiculos.SelectedIndex);
            dadosVeiculo.ShowDialog();

            var veiculos = new List<Veiculo>();

            foreach (var veiculo in Dados.LOJAS[cmbLojasVeiculos.SelectedIndex].Garagem)
                veiculos.Add(veiculo);

            lboxVeiculos.DataSource = veiculos;
        }

        private void btnEditarVeiculo_Click(object sender, EventArgs e)
        {
            if (!SelecionouVeiculo()) return;

            var dadosVeiculo = new DadosVeiculoForm(cmbLojasVeiculos.SelectedIndex, lboxVeiculos.SelectedIndex);
            dadosVeiculo.ShowDialog();

            var veiculos = new List<Veiculo>();

            foreach (var veiculo in Dados.LOJAS[cmbLojasVeiculos.SelectedIndex].Garagem)
                veiculos.Add(veiculo);

            lboxVeiculos.DataSource = veiculos;
        }

        private void btnApagarVeiculo_Click(object sender, EventArgs e)
        {
            if (!SelecionouVeiculo()) return;

            if (MessageBox.Show("Deseja realmente apagar o veículo?", "Confirmação", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation) == DialogResult.No)
                return;

            var veiculo = (Veiculo) lboxVeiculos.SelectedItem;
            Dados.LOJAS[cmbLojasVeiculos.SelectedIndex].Garagem.Remove(veiculo);
            lboxVeiculos.DataSource = null;
            lboxVeiculos.DataSource = Dados.LOJAS[cmbLojasVeiculos.SelectedIndex].Garagem;
        }

        private void cmbLojasVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lboxVeiculos.DataSource = Dados.LOJAS[cmbLojasVeiculos.SelectedIndex].Garagem;
        }

        private bool SelecionouVeiculo()
        {
            if (lboxVeiculos.SelectedIndex == -1) {
                MostrarErro("Tem de selecionar um veículo!");
                return false;
            }

            return true;
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
            JanelaEvento je = new JanelaEvento();
            je.EditarEsteEvento(lstEventos.SelectedIndex);
            je.ShowDialog();
            if (je.done)
            {
                AtualizarListaEventos();
                MostrarSucesso("Evento alterado com sucesso!");
            }
        }

        private void ConsultarEventoClick(object sender, EventArgs e)
        {
            if (!SelecionouEvento()) return;
            JanelaEvento je = new JanelaEvento();
            je.MostrarEsteEvento(lstEventos.SelectedIndex);
            je.ShowDialog();
        }

        private void AgendarEventoClick(object sender, EventArgs e)
        {
            if (!SelecionouEvento()) return;
            JanelaEvento je = new JanelaEvento();
            je.ShowDialog();
            if (je.done)
            {
                AtualizarListaEventos();
                MostrarSucesso("Evento agendado com sucesso!");
            }
        }

        private void btnApagarEvento_Click(object sender, EventArgs e)
        {
            if (!SelecionouEvento()) return;
            MostrarSucesso("Evento \"" + RemoverEvento() + "\" removido com sucesso!");
        }

        private string RemoverEvento()
        {
            int idx = lstEventos.SelectedIndex;
            Evento ev = (Evento) lstEventos.Items[idx];
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
            if (lstEventos.SelectedIndex != -1)
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

            if (cmbDestino.SelectedIndex == -1 || cmbDestino.SelectedItem == null) {
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

            Local destino = (Local) cmbDestino.SelectedItem;

            if (cmbTipoDestino.SelectedIndex == 0) {
                Loja lj = (Loja) destino;

                if (ev.Garagem.Count > lj.TamanhoGaragem - lj.Garagem.Count) {
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
            return (Evento) lstEventos.Items[lstEventos.SelectedIndex];
        }

        private void PreencherComTodasAsLojas()
        {
            cmbDestino.Items.Clear();
            Evento ev = GetSelectedEvento();

            foreach (Loja lj in Dados.LOJAS) {
                if (lj.Garagem.Count + ev.Garagem.Count <= lj.TamanhoGaragem)
                    cmbDestino.Items.Add(lj);
            }

            if (cmbDestino.Items.Count == 0) {
                MessageBox.Show("Não há nenhuma loja com espaço suficiente para os veículos desse evento!", "Oops",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (lstEventos.SelectedIndex == -1) {
                MostrarErro("Tem de selecionar um evento!");
                return false;
            }

            return true;
        }

        private void lstEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEventos.SelectedIndex == -1) {
                cmbTipoDestino.Enabled = false;
                cmbDestino.Enabled = false;
                btnFinalizar.Enabled = false;
                cmbDestino.DataSource = null;
            }
            else {
                if (!GetSelectedEvento().Terminado) {
                    PreencherDestino();
                    cmbTipoDestino.Enabled = true;
                    cmbDestino.Enabled = true;
                    btnFinalizar.Enabled = true;
                }
                else {
                    cmbTipoDestino.Enabled = false;
                    cmbDestino.Enabled = false;
                    btnFinalizar.Enabled = false;
                    cmbDestino.DataSource = null;
                }
            }
        }

        #endregion

        #region Gerir Clientes

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            if (!SelecionouCliente()) return;
            var dadosCliente = new DadosClienteForm(lboxClientes.SelectedIndex, true);
            dadosCliente.ShowDialog();
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            if (!SelecionouCliente()) return;

            var dadosCliente = new DadosClienteForm();
            dadosCliente.ShowDialog();

            var clientes = new List<Cliente>();

            foreach (var cliente in Dados.CLIENTES)
                clientes.Add(cliente);

            lboxClientes.DataSource = clientes;
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (!SelecionouCliente()) return;

            var dadosCliente = new DadosClienteForm(lboxClientes.SelectedIndex);
            dadosCliente.ShowDialog();

            var clientes = new List<Cliente>();

            foreach (var cliente in Dados.CLIENTES)
                clientes.Add(cliente);

            lboxClientes.DataSource = clientes;
        }

        private void btnApagarCliente_Click(object sender, EventArgs e)
        {
            if (!SelecionouCliente()) return;
            MostrarSucesso("Cliente \"" + RemoverCliente() + "\" apagado com sucesso!");
        }

        private string RemoverCliente()
        {
            int idx = lboxClientes.SelectedIndex;
            Cliente cl = (Cliente) lboxClientes.Items[idx];
            Dados.RemoverCliente(cl);
            lboxClientes.DataSource = null;
            lboxClientes.DataSource = Dados.CLIENTES;
            return cl.Nome;
        }

        private bool SelecionouCliente()
        {
            if (lboxClientes.SelectedIndex == -1) {
                MostrarErro("Tem de selecionar um cliente!");
                return false;
            }

            return true;
        }

        #endregion

        #region Transações

        private void btnCompra_Click(object sender, EventArgs e)
        {
            var comprarVeiculo = new ComprarVeiculoForm(cmbLojasTransacoes.SelectedIndex);
            comprarVeiculo.ShowDialog();

            var transacoes = new List<Transacao>();

            foreach (var transacao in Dados.TRANSACOES)
                transacoes.Add(transacao);

            lboxTransacoes.DataSource = transacoes;
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            var venderVeiculo = new VenderVeiculoForm(cmbLojasTransacoes.SelectedIndex);
            venderVeiculo.ShowDialog();

            var transacoes = new List<Transacao>();

            foreach (var transacao in Dados.TRANSACOES)
                transacoes.Add(transacao);

            lboxTransacoes.DataSource = transacoes;
        }

        private void btnTroca_Click(object sender, EventArgs e)
        {
            var trocarVeiculo = new TrocarVeiculosForm(cmbLojasTransacoes.SelectedIndex);
            trocarVeiculo.ShowDialog();

            var transacoes = new List<Transacao>();

            foreach (var transacao in Dados.TRANSACOES)
                transacoes.Add(transacao);

            lboxTransacoes.DataSource = transacoes;
        }

        #endregion

        #region Estatisticas

        private void btnAtualizarEstatisticas_Click(object sender, EventArgs e)
        {
            if (dtpInicio1.Value > dtpFim1.Value) {
                MostrarErro("A data de início da Estatística 1 não pode ser posterior à data de fim!");
                return;
            }

            if (dtpInicio2.Value > dtpFim2.Value) {
                MostrarErro("A data de início da Estatística 2 não pode ser posterior à data de fim!");
                return;
            }

            PreencherEstatisticas();
            MostrarSucesso("As estatísticas foram calculadas com sucesso!");
        }

        private void GetEstatisticasFor(DateTime inicio, DateTime fim, out string marca, out string modelo, out string cliente,
                                        out double totalMarca, out double totalModelo, out double totalCliente, out double total)
        {
            total = 0;
            totalCliente = 0;
            totalMarca = 0;
            totalModelo = 0;
            cliente = "Sem vendas registadas";
            marca = "Sem vendas registadas";
            modelo = "Sem vendas registadas";
            Dictionary<String, double> totalMarcas = new();
            Dictionary<String, double> totalModelos = new();
            Dictionary<String, double> totalClientes = new();

            foreach (Transacao tr in Dados.TRANSACOES) {
                if (tr.Data >= inicio && tr.Data <= fim) {
                    if (tr.Tipo == TipoTransacao.Venda) {
                        UpdateDictionaryKey(totalMarcas, tr.Veiculo.Marca, tr.Valor);
                        UpdateDictionaryKey(totalModelos, tr.Veiculo.Modelo, tr.Valor);
                        UpdateDictionaryKey(totalClientes, tr.Cliente.Nome, tr.Valor);
                        total += tr.Valor;
                    }
                    else if (tr.Tipo == TipoTransacao.Compra) {
                        total -= tr.Valor;
                    }
                }
            }

            if (totalMarcas.Count != 0) {
                totalMarca = totalMarcas.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;
                marca = totalMarcas.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            }

            if (totalModelos.Count != 0) {
                totalModelo = totalModelos.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;
                modelo = totalModelos.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            }

            if (totalClientes.Count != 0) {
                totalCliente = totalClientes.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;
                cliente = totalClientes.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            }
        }

        private void UpdateDictionaryKey(Dictionary<String, double> dic, String key, double value)
        {
            if (dic.ContainsKey(key))
                dic[key] += value;
            else
                dic.Add(key, value);
        }

        private void PreencherEstatisticas()
        {
            GetEstatisticasFor(dtpInicio1.Value, dtpFim1.Value, out string marca1, out string modelo1, out string cliente1,
                               out double totalMarca1, out double totalModelo1, out double totalCliente1, out double total1);

            GetEstatisticasFor(dtpInicio2.Value, dtpFim2.Value, out string marca2, out string modelo2, out string cliente2,
                               out double totalMarca2, out double totalModelo2, out double totalCliente2, out double total2);

            txtECliente1.Text = cliente1;
            txtEMarca1.Text = marca1;
            txtEModelo1.Text = modelo1;
            txtFatTotal1.Text = total1.ToString("C");
            txtETCliente1.Text = totalCliente1.ToString("C");
            txtETMarca1.Text = totalMarca1.ToString("C");
            txtETModelo1.Text = totalModelo1.ToString("C");

            txtECliente2.Text = cliente2;
            txtEMarca2.Text = marca2;
            txtEModelo2.Text = modelo2;
            txtFatTotal2.Text = total2.ToString("C");
            txtETCliente2.Text = totalCliente2.ToString("C");
            txtETMarca2.Text = totalMarca2.ToString("C");
            txtETModelo2.Text = totalModelo2.ToString("C");
        }

        #endregion

        #region Outras coisas

        private void MostrarErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MostrarSucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
