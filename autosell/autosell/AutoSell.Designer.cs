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
            this.btnConsultarVeiculo = new System.Windows.Forms.Button();
            this.btnEditarVeiculo = new System.Windows.Forms.Button();
            this.btnAdicionarVeiculo = new System.Windows.Forms.Button();
            this.btnApagarVeiculo = new System.Windows.Forms.Button();
            this.lboxVeiculos = new System.Windows.Forms.ListBox();
            this.tabTransacoes = new System.Windows.Forms.TabPage();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnTroca = new System.Windows.Forms.Button();
            this.lboxTransacoes = new System.Windows.Forms.ListBox();
            this.tabEventos = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbTipoDestino = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditarEvento = new System.Windows.Forms.Button();
            this.btnAdicionarEvento = new System.Windows.Forms.Button();
            this.btnApagarEvento = new System.Windows.Forms.Button();
            this.lstEventos = new System.Windows.Forms.ListBox();
            this.tabEstatisticas = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLojas = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabInicio.SuspendLayout();
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
            // btnConsultarVeiculo
            // 
            this.btnConsultarVeiculo.Location = new System.Drawing.Point(347, 5);
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
            this.tabTransacoes.Controls.Add(this.btnCompra);
            this.tabTransacoes.Controls.Add(this.btnVenda);
            this.tabTransacoes.Controls.Add(this.btnTroca);
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
            this.btnCompra.TabIndex = 8;
            this.btnCompra.Text = "Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            // 
            // btnVenda
            // 
            this.btnVenda.Location = new System.Drawing.Point(509, 5);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(75, 23);
            this.btnVenda.TabIndex = 7;
            this.btnVenda.Text = "Venda";
            this.btnVenda.UseVisualStyleBackColor = true;
            // 
            // btnTroca
            // 
            this.btnTroca.Location = new System.Drawing.Point(590, 5);
            this.btnTroca.Name = "btnTroca";
            this.btnTroca.Size = new System.Drawing.Size(75, 23);
            this.btnTroca.TabIndex = 6;
            this.btnTroca.Text = "Troca";
            this.btnTroca.UseVisualStyleBackColor = true;
            // 
            // lboxTransacoes
            // 
            this.lboxTransacoes.FormattingEnabled = true;
            this.lboxTransacoes.ItemHeight = 15;
            this.lboxTransacoes.Location = new System.Drawing.Point(0, 32);
            this.lboxTransacoes.Name = "lboxTransacoes";
            this.lboxTransacoes.Size = new System.Drawing.Size(671, 259);
            this.lboxTransacoes.TabIndex = 5;
            // 
            // tabEventos
            // 
            this.tabEventos.Controls.Add(this.button1);
            this.tabEventos.Controls.Add(this.btnFinalizar);
            this.tabEventos.Controls.Add(this.cmbDestino);
            this.tabEventos.Controls.Add(this.cmbTipoDestino);
            this.tabEventos.Controls.Add(this.label4);
            this.tabEventos.Controls.Add(this.btnEditarEvento);
            this.tabEventos.Controls.Add(this.btnAdicionarEvento);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(477, 268);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(192, 22);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Terminar e Recolher Veículos";
            this.btnFinalizar.UseVisualStyleBackColor = true;
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
            this.btnEditarEvento.Location = new System.Drawing.Point(511, 5);
            this.btnEditarEvento.Name = "btnEditarEvento";
            this.btnEditarEvento.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEvento.TabIndex = 6;
            this.btnEditarEvento.Text = "Editar";
            this.btnEditarEvento.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarEvento
            // 
            this.btnAdicionarEvento.Location = new System.Drawing.Point(430, 5);
            this.btnAdicionarEvento.Name = "btnAdicionarEvento";
            this.btnAdicionarEvento.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarEvento.TabIndex = 5;
            this.btnAdicionarEvento.Text = "Adicionar";
            this.btnAdicionarEvento.UseVisualStyleBackColor = true;
            // 
            // btnApagarEvento
            // 
            this.btnApagarEvento.Location = new System.Drawing.Point(592, 5);
            this.btnApagarEvento.Name = "btnApagarEvento";
            this.btnApagarEvento.Size = new System.Drawing.Size(75, 23);
            this.btnApagarEvento.TabIndex = 4;
            this.btnApagarEvento.Text = "Apagar";
            this.btnApagarEvento.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loja";
            // 
            // cmbLojas
            // 
            this.cmbLojas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLojas.FormattingEnabled = true;
            this.cmbLojas.Location = new System.Drawing.Point(52, 38);
            this.cmbLojas.Name = "cmbLojas";
            this.cmbLojas.Size = new System.Drawing.Size(166, 23);
            this.cmbLojas.TabIndex = 4;
            this.cmbLojas.SelectedIndexChanged += new System.EventHandler(this.cmbLojas_SelectedIndexChanged);
            // 
            // AutoSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbLojas);
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
            this.tabVeiculos.ResumeLayout(false);
            this.tabTransacoes.ResumeLayout(false);
            this.tabEventos.ResumeLayout(false);
            this.tabEventos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label3;
        private ComboBox cmbLojas;
        private ListBox lstEventos;
        private ComboBox cmbTipoDestino;
        private Label label4;
        private Button btnEditarEvento;
        private Button btnAdicionarEvento;
        private Button btnApagarEvento;
        private ComboBox cmbDestino;
        private Button button1;
        private Button btnFinalizar;
        private Button btnCompra;
        private Button btnVenda;
        private Button btnTroca;
        private ListBox lboxTransacoes;
        private Button btnConsultarVeiculo;
    }
}
