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
    public partial class DadosClienteForm : Form
    {
        private readonly int _clienteId;

        public DadosClienteForm(int clienteId = -1, bool consulta = false)
        {
            InitializeComponent();
            _clienteId = clienteId;

            if (clienteId == -1) return;

            txtNome.Text = Dados.CLIENTES[clienteId].Nome;
            txtTelefone.Text = Dados.CLIENTES[clienteId].Telefone;
            txtNif.Text = Dados.CLIENTES[clienteId].Nif;

            if (!consulta) return;

            btnGuardar.Visible = false;
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            txtNif.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text)) {
                MessageBox.Show("O nome do cliente é obrigatório");
                return;
            }

            if (string.IsNullOrEmpty(txtTelefone.Text)) {
                MessageBox.Show("O telefone do cliente é obrigatório");
                return;
            }

            if (string.IsNullOrEmpty(txtNif.Text)) {
                MessageBox.Show("O nif do cliente é obrigatório");
                return;
            }

            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string nif = txtNif.Text;

            if (!int.TryParse(telefone, out int telefoneInt)) {
                MessageBox.Show("O telefone do cliente deve ser um número");
                return;
            }

            if (!int.TryParse(nif, out int nifInt)) {
                MessageBox.Show("O nif do cliente deve ser um número");
                return;
            }

            var cliente = new Cliente(nome, telefone, nif);

            try {
                if (_clienteId == -1)
                    Dados.CLIENTES.Add(cliente);
                else
                    Dados.CLIENTES[_clienteId] = cliente;
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro no registo do cliente: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(_clienteId == -1 ? "Cliente registado com sucesso" : "Cliente alterado com sucesso", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
