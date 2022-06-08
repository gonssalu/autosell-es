namespace autosell
{
    public partial class MainForm : Form
    {
        Button activeBtn;

        public MainForm()
        {
            InitializeComponent();
        }

        void clicked(Button btn)
        {
            if (activeBtn != null)
            {
                activeBtn.BackColor = Colors.Primary;
            }
            activeBtn = btn;

            btn.BackColor = Colors.Background;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            clicked((Button)sender);
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            clicked((Button)sender);
        }

        private void btnTransacoes_Click(object sender, EventArgs e)
        {
            clicked((Button)sender);
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            clicked((Button)sender);
        }

        private void btnPecas_Click(object sender, EventArgs e)
        {
            clicked((Button)sender);
        }

        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            clicked((Button)sender);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Colors.Background;
            btnClientes.BackColor = Colors.Primary;
            btnEstatisticas.BackColor = Colors.Primary;
            btnEventos.BackColor = Colors.Primary;
            btnPecas.BackColor = Colors.Primary;
            btnTransacoes.BackColor = Colors.Primary;
            btnVeiculos.BackColor = Colors.Primary;
            lblBrand.BackColor = Colors.Primary;
        }
    }
}