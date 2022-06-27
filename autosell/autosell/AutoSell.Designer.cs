namespace autosell
{
    partial class AutoSell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.tabVeiculos = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLojasVeiculos = new System.Windows.Forms.ComboBox();
            this.btnConsultarVeiculo = new System.Windows.Forms.Button();
            this.btnEditarVeiculo = new System.Windows.Forms.Button();
            this.btnAdicionarVeiculo = new System.Windows.Forms.Button();
            this.btnApagarVeiculo = new System.Windows.Forms.Button();
            this.lboxVeiculos = new System.Windows.Forms.ListBox();
            this.tabTransacoes = new System.Windows.Forms.TabPage();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.lboxTransacoes = new System.Windows.Forms.ListBox();
            this.tabEventos = new System.Windows.Forms.TabPage();
            this.btnConsultarEvento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbTipoDestino = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditarEvento = new System.Windows.Forms.Button();
            this.btnAgendarEvento = new System.Windows.Forms.Button();
            this.btnApagarEvento = new System.Windows.Forms.Button();
            this.lstEventos = new System.Windows.Forms.ListBox();
            this.tabEstatisticas = new System.Windows.Forms.TabPage();
            this.lboxClientes = new System.Windows.Forms.ListBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnTroca = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabInicio.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabVeiculos.SuspendLayout();
            this.tabTransacoes.SuspendLayout();
            this.tabEventos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInicio);
            this.tabControl1.Controls.Add(this.tabClientes);
            this.tabControl1.Controls.Add(this.tabVeiculos);
            this.tabControl1.Controls.Add(this.tabTransacoes);
            this.tabControl1.Controls.Add(this.tabEventos);
            this.tabControl1.Controls.Add(this.tabEstatisticas);
            this.tabControl1.Location = new System.Drawing.Point(10, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 320);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInicio
            // 
            this.tabInicio.Controls.Add(this.label2);
            this.tabInicio.Controls.Add(this.label1);
            this.tabInicio.Location = new System.Drawing.Point(4, 24);
            this.tabInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Size = new System.Drawing.Size(671, 292);
            this.tabInicio.TabIndex = 5;
            this.tabInicio.Text = "Início";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(161, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 141);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alexandre Jerónimo\r\nDiogo Almeida\r\nGonçalo Paulino";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(177, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "AutoSell";
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.btnConsultar);
            this.tabClientes.Controls.Add(this.btnEditar);
            this.tabClientes.Controls.Add(this.btnAdicionar);
            this.tabClientes.Controls.Add(this.btnApagar);
            this.tabClientes.Controls.Add(this.lboxClientes);
            this.tabClientes.Location = new System.Drawing.Point(4, 24);
            this.tabClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabClientes.Size = new System.Drawing.Size(671, 292);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // tabVeiculos
            // 
            this.tabVeiculos.Controls.Add(this.label3);
            this.tabVeiculos.Controls.Add(this.cmbLojasVeiculos);
            this.tabVeiculos.Controls.Add(this.btnConsultarVeiculo);
            this.tabVeiculos.Controls.Add(this.btnEditarVeiculo);
            this.tabVeiculos.Controls.Add(this.btnAdicionarVeiculo);
            this.tabVeiculos.Controls.Add(this.btnApagarVeiculo);
            this.tabVeiculos.Controls.Add(this.lboxVeiculos);
            this.tabVeiculos.Location = new System.Drawing.Point(4, 24);
            this.tabVeiculos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVeiculos.Name = "tabVeiculos";
            this.tabVeiculos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVeiculos.Size = new System.Drawing.Size(671, 292);
            this.tabVeiculos.TabIndex = 1;
            this.tabVeiculos.Text = "Veículos";
            this.tabVeiculos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loja:";
            // 
            // cmbLojasVeiculos
            // 
            this.cmbLojasVeiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLojasVeiculos.FormattingEnabled = true;
            this.cmbLojasVeiculos.Location = new System.Drawing.Point(43, 5);
            this.cmbLojasVeiculos.Name = "cmbLojasVeiculos";
            this.cmbLojasVeiculos.Size = new System.Drawing.Size(146, 23);
            this.cmbLojasVeiculos.TabIndex = 4;
            this.cmbLojasVeiculos.SelectedIndexChanged += new System.EventHandler(this.cmbLojasVeiculos_SelectedIndexChanged);
            // 
            // btnConsultarVeiculo
            // 
            this.btnConsultarVeiculo.Location = new System.Drawing.Point(347, 5);
            this.btnConsultarVeiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarVeiculo.Name = "btnConsultarVeiculo";
            this.btnConsultarVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarVeiculo.TabIndex = 4;
            this.btnConsultarVeiculo.Text = "Consultar";
            this.btnConsultarVeiculo.UseVisualStyleBackColor = true;
            this.btnConsultarVeiculo.Click += new System.EventHandler(this.btnConsultarVeiculo_Click);
            // 
            // btnEditarVeiculo
            // 
            this.btnEditarVeiculo.Location = new System.Drawing.Point(509, 5);
            this.btnEditarVeiculo.Name = "btnEditarVeiculo";
            this.btnEditarVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnEditarVeiculo.TabIndex = 3;
            this.btnEditarVeiculo.Text = "Editar";
            this.btnEditarVeiculo.UseVisualStyleBackColor = true;
            this.btnEditarVeiculo.Click += new System.EventHandler(this.btnEditarVeiculo_Click);
            // 
            // btnAdicionarVeiculo
            // 
            this.btnAdicionarVeiculo.Location = new System.Drawing.Point(428, 5);
            this.btnAdicionarVeiculo.Name = "btnAdicionarVeiculo";
            this.btnAdicionarVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarVeiculo.TabIndex = 2;
            this.btnAdicionarVeiculo.Text = "Adicionar";
            this.btnAdicionarVeiculo.UseVisualStyleBackColor = true;
            this.btnAdicionarVeiculo.Click += new System.EventHandler(this.btnAdicionarVeiculo_Click);
            // 
            // btnApagarVeiculo
            // 
            this.btnApagarVeiculo.Location = new System.Drawing.Point(590, 5);
            this.btnApagarVeiculo.Name = "btnApagarVeiculo";
            this.btnApagarVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnApagarVeiculo.TabIndex = 1;
            this.btnApagarVeiculo.Text = "Apagar";
            this.btnApagarVeiculo.UseVisualStyleBackColor = true;
            this.btnApagarVeiculo.Click += new System.EventHandler(this.btnApagarVeiculo_Click);
            // 
            // lboxVeiculos
            // 
            this.lboxVeiculos.FormattingEnabled = true;
            this.lboxVeiculos.ItemHeight = 15;
            this.lboxVeiculos.Location = new System.Drawing.Point(0, 32);
            this.lboxVeiculos.Name = "lboxVeiculos";
            this.lboxVeiculos.Size = new System.Drawing.Size(671, 259);
            this.lboxVeiculos.TabIndex = 0;
            // 
            // tabTransacoes
            // 
            this.tabTransacoes.Controls.Add(this.btnTroca);
            this.tabTransacoes.Controls.Add(this.btnCompra);
            this.tabTransacoes.Controls.Add(this.btnVenda);
            this.tabTransacoes.Controls.Add(this.lboxTransacoes);
            this.tabTransacoes.Location = new System.Drawing.Point(4, 24);
            this.tabTransacoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTransacoes.Name = "tabTransacoes";
            this.tabTransacoes.Size = new System.Drawing.Size(671, 292);
            this.tabTransacoes.TabIndex = 2;
            this.tabTransacoes.Text = "Transações";
            this.tabTransacoes.UseVisualStyleBackColor = true;
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(428, 5);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(75, 23);
            this.btnCompra.TabIndex = 12;
            this.btnCompra.Text = "Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            // 
            // btnVenda
            // 
            this.btnVenda.Location = new System.Drawing.Point(509, 5);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(75, 23);
            this.btnVenda.TabIndex = 11;
            this.btnVenda.Text = "Venda";
            this.btnVenda.UseVisualStyleBackColor = true;
            // 
            // lboxTransacoes
            // 
            this.lboxTransacoes.FormattingEnabled = true;
            this.lboxTransacoes.ItemHeight = 15;
            this.lboxTransacoes.Location = new System.Drawing.Point(0, 32);
            this.lboxTransacoes.Name = "lboxTransacoes";
            this.lboxTransacoes.Size = new System.Drawing.Size(671, 259);
            this.lboxTransacoes.TabIndex = 10;
            // 
            // tabEventos
            // 
            this.tabEventos.Controls.Add(this.btnConsultarEvento);
            this.tabEventos.Controls.Add(this.button1);
            this.tabEventos.Controls.Add(this.btnFinalizar);
            this.tabEventos.Controls.Add(this.cmbDestino);
            this.tabEventos.Controls.Add(this.cmbTipoDestino);
            this.tabEventos.Controls.Add(this.label4);
            this.tabEventos.Controls.Add(this.btnEditarEvento);
            this.tabEventos.Controls.Add(this.btnAgendarEvento);
            this.tabEventos.Controls.Add(this.btnApagarEvento);
            this.tabEventos.Controls.Add(this.lstEventos);
            this.tabEventos.Location = new System.Drawing.Point(4, 24);
            this.tabEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEventos.Name = "tabEventos";
            this.tabEventos.Size = new System.Drawing.Size(671, 292);
            this.tabEventos.TabIndex = 3;
            this.tabEventos.Text = "Eventos";
            this.tabEventos.UseVisualStyleBackColor = true;
            // 
            // btnConsultarEvento
            // 
            this.btnConsultarEvento.Location = new System.Drawing.Point(348, 5);
            this.btnConsultarEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultarEvento.Name = "btnConsultarEvento";
            this.btnConsultarEvento.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarEvento.TabIndex = 12;
            this.btnConsultarEvento.Text = "Consultar";
            this.btnConsultarEvento.UseVisualStyleBackColor = true;
            this.btnConsultarEvento.Click += new System.EventHandler(this.ConsultarEventoClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(477, 267);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(191, 22);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Terminar e Recolher Veículos";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(249, 268);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(223, 23);
            this.cmbDestino.TabIndex = 9;
            // 
            // cmbTipoDestino
            // 
            this.cmbTipoDestino.FormattingEnabled = true;
            this.cmbTipoDestino.Items.AddRange(new object[] {
            "Loja",
            "Outro evento"});
            this.cmbTipoDestino.Location = new System.Drawing.Point(140, 268);
            this.cmbTipoDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoDestino.Name = "cmbTipoDestino";
            this.cmbTipoDestino.Size = new System.Drawing.Size(105, 23);
            this.cmbTipoDestino.TabIndex = 8;
            this.cmbTipoDestino.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDestino_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Destino dos veículos:";
            // 
            // btnEditarEvento
            // 
            this.btnEditarEvento.Location = new System.Drawing.Point(509, 5);
            this.btnEditarEvento.Name = "btnEditarEvento";
            this.btnEditarEvento.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEvento.TabIndex = 6;
            this.btnEditarEvento.Text = "Editar";
            this.btnEditarEvento.UseVisualStyleBackColor = true;
            this.btnEditarEvento.Click += new System.EventHandler(this.EditarEventoClick);
            // 
            // btnAgendarEvento
            // 
            this.btnAgendarEvento.Location = new System.Drawing.Point(428, 5);
            this.btnAgendarEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgendarEvento.Name = "btnAgendarEvento";
            this.btnAgendarEvento.Size = new System.Drawing.Size(75, 23);
            this.btnAgendarEvento.TabIndex = 5;
            this.btnAgendarEvento.Text = "Agendar";
            this.btnAgendarEvento.UseVisualStyleBackColor = true;
            this.btnAgendarEvento.Click += new System.EventHandler(this.AgendarEventoClick);
            // 
            // btnApagarEvento
            // 
            this.btnApagarEvento.Location = new System.Drawing.Point(590, 5);
            this.btnApagarEvento.Name = "btnApagarEvento";
            this.btnApagarEvento.Size = new System.Drawing.Size(75, 23);
            this.btnApagarEvento.TabIndex = 4;
            this.btnApagarEvento.Text = "Apagar";
            this.btnApagarEvento.UseVisualStyleBackColor = true;
            this.btnApagarEvento.Click += new System.EventHandler(this.btnApagarEvento_Click);
            // 
            // lstEventos
            // 
            this.lstEventos.FormattingEnabled = true;
            this.lstEventos.ItemHeight = 15;
            this.lstEventos.Location = new System.Drawing.Point(0, 33);
            this.lstEventos.Name = "lstEventos";
            this.lstEventos.Size = new System.Drawing.Size(671, 229);
            this.lstEventos.TabIndex = 1;
            // 
            // tabEstatisticas
            // 
            this.tabEstatisticas.Location = new System.Drawing.Point(4, 24);
            this.tabEstatisticas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEstatisticas.Name = "tabEstatisticas";
            this.tabEstatisticas.Size = new System.Drawing.Size(671, 292);
            this.tabEstatisticas.TabIndex = 4;
            this.tabEstatisticas.Text = "Estatísticas";
            this.tabEstatisticas.UseVisualStyleBackColor = true;
            // 
            // lboxClientes
            // 
            this.lboxClientes.FormattingEnabled = true;
            this.lboxClientes.ItemHeight = 15;
            this.lboxClientes.Location = new System.Drawing.Point(0, 32);
            this.lboxClientes.Name = "lboxClientes";
            this.lboxClientes.Size = new System.Drawing.Size(671, 259);
            this.lboxClientes.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(347, 5);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(509, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(428, 5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(590, 5);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnTroca
            // 
            this.btnTroca.Location = new System.Drawing.Point(590, 5);
            this.btnTroca.Name = "btnTroca";
            this.btnTroca.Size = new System.Drawing.Size(75, 23);
            this.btnTroca.TabIndex = 13;
            this.btnTroca.Text = "Troca";
            this.btnTroca.UseVisualStyleBackColor = true;
            // 
            // AutoSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AutoSell";
            this.Text = "AutoSell";
            this.Load += new System.EventHandler(this.AutoSell_Load);
            this.Shown += new System.EventHandler(this.AutoSell_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.tabInicio.PerformLayout();
            this.tabClientes.ResumeLayout(false);
            this.tabVeiculos.ResumeLayout(false);
            this.tabVeiculos.PerformLayout();
            this.tabTransacoes.ResumeLayout(false);
            this.tabEventos.ResumeLayout(false);
            this.tabEventos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabInicio;
        private Label label2;
        private Label label1;
        private TabPage tabClientes;
        private TabPage tabVeiculos;
        private TabPage tabTransacoes;
        private TabPage tabEventos;
        private TabPage tabEstatisticas;
        private Button btnAdicionarVeiculo;
        private Button btnApagarVeiculo;
        private ListBox lboxVeiculos;
        private Button btnEditarVeiculo;
        private ListBox lstEventos;
        private ComboBox cmbTipoDestino;
        private Label label4;
        private Button btnEditarEvento;
        private Button btnAgendarEvento;
        private Button btnApagarEvento;
        private ComboBox cmbDestino;
        private Button button1;
        private Button btnFinalizar;
        private Button btnConsultarEvento;
        private Label label3;
        private ComboBox cmbLojasVeiculos;
        private Button btnConsultarVeiculo;
        private ListBox lboxTransacoes;
        private Button btnCompra;
        private Button btnVenda;
        private ListBox lboxClientes;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnAdicionar;
        private Button btnApagar;
        private Button btnTroca;
    }
}
