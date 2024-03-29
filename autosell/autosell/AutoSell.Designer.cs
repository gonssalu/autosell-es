﻿namespace autosell
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
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnAdicionarCliente = new System.Windows.Forms.Button();
            this.btnApagarCliente = new System.Windows.Forms.Button();
            this.lboxClientes = new System.Windows.Forms.ListBox();
            this.tabVeiculos = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLojasVeiculos = new System.Windows.Forms.ComboBox();
            this.btnConsultarVeiculo = new System.Windows.Forms.Button();
            this.btnEditarVeiculo = new System.Windows.Forms.Button();
            this.btnAdicionarVeiculo = new System.Windows.Forms.Button();
            this.btnApagarVeiculo = new System.Windows.Forms.Button();
            this.lboxVeiculos = new System.Windows.Forms.ListBox();
            this.tabTransacoes = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbLojasTransacoes = new System.Windows.Forms.ComboBox();
            this.btnTroca = new System.Windows.Forms.Button();
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
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFim2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpInicio2 = new System.Windows.Forms.DateTimePicker();
            this.txtFatTotal2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtETCliente2 = new System.Windows.Forms.TextBox();
            this.txtETModelo2 = new System.Windows.Forms.TextBox();
            this.txtETMarca2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtECliente2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEModelo2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEMarca2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFim1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpInicio1 = new System.Windows.Forms.DateTimePicker();
            this.txtFatTotal1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtETCliente1 = new System.Windows.Forms.TextBox();
            this.txtETModelo1 = new System.Windows.Forms.TextBox();
            this.txtETMarca1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtECliente1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEModelo1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEMarca1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAtualizarEstatisticas = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabInicio.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabVeiculos.SuspendLayout();
            this.tabTransacoes.SuspendLayout();
            this.tabEventos.SuspendLayout();
            this.tabEstatisticas.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 427);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInicio
            // 
            this.tabInicio.Controls.Add(this.label2);
            this.tabInicio.Controls.Add(this.label1);
            this.tabInicio.Location = new System.Drawing.Point(4, 29);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Size = new System.Drawing.Size(768, 394);
            this.tabInicio.TabIndex = 5;
            this.tabInicio.Text = "Início";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(184, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 177);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alexandre Jerónimo\r\nDiogo Almeida\r\nGonçalo Paulino";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(202, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "AutoSell";
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.btnConsultarCliente);
            this.tabClientes.Controls.Add(this.btnEditarCliente);
            this.tabClientes.Controls.Add(this.btnAdicionarCliente);
            this.tabClientes.Controls.Add(this.btnApagarCliente);
            this.tabClientes.Controls.Add(this.lboxClientes);
            this.tabClientes.Location = new System.Drawing.Point(4, 29);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(768, 394);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(397, 7);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(86, 31);
            this.btnConsultarCliente.TabIndex = 8;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(582, 7);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(86, 31);
            this.btnEditarCliente.TabIndex = 7;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnAdicionarCliente
            // 
            this.btnAdicionarCliente.Location = new System.Drawing.Point(489, 7);
            this.btnAdicionarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionarCliente.Name = "btnAdicionarCliente";
            this.btnAdicionarCliente.Size = new System.Drawing.Size(86, 31);
            this.btnAdicionarCliente.TabIndex = 6;
            this.btnAdicionarCliente.Text = "Adicionar";
            this.btnAdicionarCliente.UseVisualStyleBackColor = true;
            this.btnAdicionarCliente.Click += new System.EventHandler(this.btnAdicionarCliente_Click);
            // 
            // btnApagarCliente
            // 
            this.btnApagarCliente.Location = new System.Drawing.Point(674, 7);
            this.btnApagarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApagarCliente.Name = "btnApagarCliente";
            this.btnApagarCliente.Size = new System.Drawing.Size(86, 31);
            this.btnApagarCliente.TabIndex = 5;
            this.btnApagarCliente.Text = "Apagar";
            this.btnApagarCliente.UseVisualStyleBackColor = true;
            this.btnApagarCliente.Click += new System.EventHandler(this.btnApagarCliente_Click);
            // 
            // lboxClientes
            // 
            this.lboxClientes.FormattingEnabled = true;
            this.lboxClientes.ItemHeight = 20;
            this.lboxClientes.Location = new System.Drawing.Point(0, 43);
            this.lboxClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lboxClientes.Name = "lboxClientes";
            this.lboxClientes.Size = new System.Drawing.Size(766, 344);
            this.lboxClientes.TabIndex = 1;
            // 
            // tabVeiculos
            // 
            this.tabVeiculos.Controls.Add(this.btnTransferir);
            this.tabVeiculos.Controls.Add(this.label3);
            this.tabVeiculos.Controls.Add(this.cmbLojasVeiculos);
            this.tabVeiculos.Controls.Add(this.btnConsultarVeiculo);
            this.tabVeiculos.Controls.Add(this.btnEditarVeiculo);
            this.tabVeiculos.Controls.Add(this.btnAdicionarVeiculo);
            this.tabVeiculos.Controls.Add(this.btnApagarVeiculo);
            this.tabVeiculos.Controls.Add(this.lboxVeiculos);
            this.tabVeiculos.Location = new System.Drawing.Point(4, 29);
            this.tabVeiculos.Name = "tabVeiculos";
            this.tabVeiculos.Padding = new System.Windows.Forms.Padding(3);
            this.tabVeiculos.Size = new System.Drawing.Size(768, 394);
            this.tabVeiculos.TabIndex = 1;
            this.tabVeiculos.Text = "Veículos";
            this.tabVeiculos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loja:";
            // 
            // cmbLojasVeiculos
            // 
            this.cmbLojasVeiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLojasVeiculos.FormattingEnabled = true;
            this.cmbLojasVeiculos.Location = new System.Drawing.Point(49, 7);
            this.cmbLojasVeiculos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLojasVeiculos.Name = "cmbLojasVeiculos";
            this.cmbLojasVeiculos.Size = new System.Drawing.Size(166, 28);
            this.cmbLojasVeiculos.TabIndex = 4;
            this.cmbLojasVeiculos.SelectedIndexChanged += new System.EventHandler(this.cmbLojasVeiculos_SelectedIndexChanged);
            // 
            // btnConsultarVeiculo
            // 
            this.btnConsultarVeiculo.Location = new System.Drawing.Point(397, 7);
            this.btnConsultarVeiculo.Name = "btnConsultarVeiculo";
            this.btnConsultarVeiculo.Size = new System.Drawing.Size(86, 31);
            this.btnConsultarVeiculo.TabIndex = 4;
            this.btnConsultarVeiculo.Text = "Consultar";
            this.btnConsultarVeiculo.UseVisualStyleBackColor = true;
            this.btnConsultarVeiculo.Click += new System.EventHandler(this.btnConsultarVeiculo_Click);
            // 
            // btnEditarVeiculo
            // 
            this.btnEditarVeiculo.Location = new System.Drawing.Point(582, 7);
            this.btnEditarVeiculo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditarVeiculo.Name = "btnEditarVeiculo";
            this.btnEditarVeiculo.Size = new System.Drawing.Size(86, 31);
            this.btnEditarVeiculo.TabIndex = 3;
            this.btnEditarVeiculo.Text = "Editar";
            this.btnEditarVeiculo.UseVisualStyleBackColor = true;
            this.btnEditarVeiculo.Click += new System.EventHandler(this.btnEditarVeiculo_Click);
            // 
            // btnAdicionarVeiculo
            // 
            this.btnAdicionarVeiculo.Location = new System.Drawing.Point(489, 7);
            this.btnAdicionarVeiculo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionarVeiculo.Name = "btnAdicionarVeiculo";
            this.btnAdicionarVeiculo.Size = new System.Drawing.Size(86, 31);
            this.btnAdicionarVeiculo.TabIndex = 2;
            this.btnAdicionarVeiculo.Text = "Adicionar";
            this.btnAdicionarVeiculo.UseVisualStyleBackColor = true;
            this.btnAdicionarVeiculo.Click += new System.EventHandler(this.btnAdicionarVeiculo_Click);
            // 
            // btnApagarVeiculo
            // 
            this.btnApagarVeiculo.Location = new System.Drawing.Point(674, 7);
            this.btnApagarVeiculo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApagarVeiculo.Name = "btnApagarVeiculo";
            this.btnApagarVeiculo.Size = new System.Drawing.Size(86, 31);
            this.btnApagarVeiculo.TabIndex = 1;
            this.btnApagarVeiculo.Text = "Apagar";
            this.btnApagarVeiculo.UseVisualStyleBackColor = true;
            this.btnApagarVeiculo.Click += new System.EventHandler(this.btnApagarVeiculo_Click);
            // 
            // lboxVeiculos
            // 
            this.lboxVeiculos.FormattingEnabled = true;
            this.lboxVeiculos.ItemHeight = 20;
            this.lboxVeiculos.Location = new System.Drawing.Point(0, 43);
            this.lboxVeiculos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lboxVeiculos.Name = "lboxVeiculos";
            this.lboxVeiculos.Size = new System.Drawing.Size(766, 344);
            this.lboxVeiculos.TabIndex = 0;
            // 
            // tabTransacoes
            // 
            this.tabTransacoes.Controls.Add(this.label19);
            this.tabTransacoes.Controls.Add(this.cmbLojasTransacoes);
            this.tabTransacoes.Controls.Add(this.btnTroca);
            this.tabTransacoes.Controls.Add(this.btnCompra);
            this.tabTransacoes.Controls.Add(this.btnVenda);
            this.tabTransacoes.Controls.Add(this.lboxTransacoes);
            this.tabTransacoes.Location = new System.Drawing.Point(4, 29);
            this.tabTransacoes.Name = "tabTransacoes";
            this.tabTransacoes.Size = new System.Drawing.Size(768, 394);
            this.tabTransacoes.TabIndex = 2;
            this.tabTransacoes.Text = "Transações";
            this.tabTransacoes.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(6, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 20);
            this.label19.TabIndex = 15;
            this.label19.Text = "Loja:";
            // 
            // cmbLojasTransacoes
            // 
            this.cmbLojasTransacoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLojasTransacoes.FormattingEnabled = true;
            this.cmbLojasTransacoes.Location = new System.Drawing.Point(49, 7);
            this.cmbLojasTransacoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLojasTransacoes.Name = "cmbLojasTransacoes";
            this.cmbLojasTransacoes.Size = new System.Drawing.Size(166, 28);
            this.cmbLojasTransacoes.TabIndex = 14;
            // 
            // btnTroca
            // 
            this.btnTroca.Location = new System.Drawing.Point(674, 7);
            this.btnTroca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTroca.Name = "btnTroca";
            this.btnTroca.Size = new System.Drawing.Size(86, 31);
            this.btnTroca.TabIndex = 13;
            this.btnTroca.Text = "Troca";
            this.btnTroca.UseVisualStyleBackColor = true;
            this.btnTroca.Click += new System.EventHandler(this.btnTroca_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(489, 7);
            this.btnCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(86, 31);
            this.btnCompra.TabIndex = 12;
            this.btnCompra.Text = "Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.Location = new System.Drawing.Point(582, 7);
            this.btnVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(86, 31);
            this.btnVenda.TabIndex = 11;
            this.btnVenda.Text = "Venda";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // lboxTransacoes
            // 
            this.lboxTransacoes.FormattingEnabled = true;
            this.lboxTransacoes.ItemHeight = 20;
            this.lboxTransacoes.Location = new System.Drawing.Point(0, 43);
            this.lboxTransacoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lboxTransacoes.Name = "lboxTransacoes";
            this.lboxTransacoes.Size = new System.Drawing.Size(766, 344);
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
            this.tabEventos.Location = new System.Drawing.Point(4, 29);
            this.tabEventos.Name = "tabEventos";
            this.tabEventos.Size = new System.Drawing.Size(768, 394);
            this.tabEventos.TabIndex = 3;
            this.tabEventos.Text = "Eventos";
            this.tabEventos.UseVisualStyleBackColor = true;
            // 
            // btnConsultarEvento
            // 
            this.btnConsultarEvento.Location = new System.Drawing.Point(398, 7);
            this.btnConsultarEvento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConsultarEvento.Name = "btnConsultarEvento";
            this.btnConsultarEvento.Size = new System.Drawing.Size(86, 31);
            this.btnConsultarEvento.TabIndex = 12;
            this.btnConsultarEvento.Text = "Consultar";
            this.btnConsultarEvento.UseVisualStyleBackColor = true;
            this.btnConsultarEvento.Click += new System.EventHandler(this.ConsultarEventoClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 523);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(545, 356);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(218, 29);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Terminar e Recolher Veículos";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // cmbDestino
            // 
            this.cmbDestino.Enabled = false;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(285, 357);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(254, 28);
            this.cmbDestino.TabIndex = 9;
            // 
            // cmbTipoDestino
            // 
            this.cmbTipoDestino.Enabled = false;
            this.cmbTipoDestino.FormattingEnabled = true;
            this.cmbTipoDestino.Items.AddRange(new object[] {
            "Loja",
            "Outro evento"});
            this.cmbTipoDestino.Location = new System.Drawing.Point(160, 357);
            this.cmbTipoDestino.Name = "cmbTipoDestino";
            this.cmbTipoDestino.Size = new System.Drawing.Size(119, 28);
            this.cmbTipoDestino.TabIndex = 8;
            this.cmbTipoDestino.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDestino_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Destino dos veículos:";
            // 
            // btnEditarEvento
            // 
            this.btnEditarEvento.Location = new System.Drawing.Point(582, 7);
            this.btnEditarEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditarEvento.Name = "btnEditarEvento";
            this.btnEditarEvento.Size = new System.Drawing.Size(86, 31);
            this.btnEditarEvento.TabIndex = 6;
            this.btnEditarEvento.Text = "Editar";
            this.btnEditarEvento.UseVisualStyleBackColor = true;
            this.btnEditarEvento.Click += new System.EventHandler(this.EditarEventoClick);
            // 
            // btnAgendarEvento
            // 
            this.btnAgendarEvento.Location = new System.Drawing.Point(489, 7);
            this.btnAgendarEvento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAgendarEvento.Name = "btnAgendarEvento";
            this.btnAgendarEvento.Size = new System.Drawing.Size(86, 31);
            this.btnAgendarEvento.TabIndex = 5;
            this.btnAgendarEvento.Text = "Agendar";
            this.btnAgendarEvento.UseVisualStyleBackColor = true;
            this.btnAgendarEvento.Click += new System.EventHandler(this.AgendarEventoClick);
            // 
            // btnApagarEvento
            // 
            this.btnApagarEvento.Location = new System.Drawing.Point(674, 7);
            this.btnApagarEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApagarEvento.Name = "btnApagarEvento";
            this.btnApagarEvento.Size = new System.Drawing.Size(86, 31);
            this.btnApagarEvento.TabIndex = 4;
            this.btnApagarEvento.Text = "Apagar";
            this.btnApagarEvento.UseVisualStyleBackColor = true;
            this.btnApagarEvento.Click += new System.EventHandler(this.btnApagarEvento_Click);
            // 
            // lstEventos
            // 
            this.lstEventos.FormattingEnabled = true;
            this.lstEventos.ItemHeight = 20;
            this.lstEventos.Location = new System.Drawing.Point(0, 44);
            this.lstEventos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstEventos.Name = "lstEventos";
            this.lstEventos.Size = new System.Drawing.Size(766, 304);
            this.lstEventos.TabIndex = 1;
            this.lstEventos.SelectedIndexChanged += new System.EventHandler(this.lstEventos_SelectedIndexChanged);
            // 
            // tabEstatisticas
            // 
            this.tabEstatisticas.Controls.Add(this.label20);
            this.tabEstatisticas.Controls.Add(this.groupBox3);
            this.tabEstatisticas.Controls.Add(this.groupBox2);
            this.tabEstatisticas.Controls.Add(this.btnAtualizarEstatisticas);
            this.tabEstatisticas.Location = new System.Drawing.Point(4, 29);
            this.tabEstatisticas.Name = "tabEstatisticas";
            this.tabEstatisticas.Size = new System.Drawing.Size(768, 394);
            this.tabEstatisticas.TabIndex = 4;
            this.tabEstatisticas.Text = "Estatísticas";
            this.tabEstatisticas.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 324);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(496, 20);
            this.label20.TabIndex = 16;
            this.label20.Tag = "";
            this.label20.Text = "*A faturação total inclui as compras e vendas, pelo que pode ser negativa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dtpFim2);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.dtpInicio2);
            this.groupBox3.Controls.Add(this.txtFatTotal2);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(390, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 289);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estatísticas 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Data de Fim:";
            // 
            // dtpFim2
            // 
            this.dtpFim2.Location = new System.Drawing.Point(194, 53);
            this.dtpFim2.Name = "dtpFim2";
            this.dtpFim2.Size = new System.Drawing.Size(121, 27);
            this.dtpFim2.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Data de Início:";
            // 
            // dtpInicio2
            // 
            this.dtpInicio2.Location = new System.Drawing.Point(53, 53);
            this.dtpInicio2.Name = "dtpInicio2";
            this.dtpInicio2.Size = new System.Drawing.Size(121, 27);
            this.dtpInicio2.TabIndex = 14;
            // 
            // txtFatTotal2
            // 
            this.txtFatTotal2.Location = new System.Drawing.Point(122, 251);
            this.txtFatTotal2.Name = "txtFatTotal2";
            this.txtFatTotal2.ReadOnly = true;
            this.txtFatTotal2.Size = new System.Drawing.Size(247, 27);
            this.txtFatTotal2.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtETCliente2);
            this.groupBox4.Controls.Add(this.txtETModelo2);
            this.groupBox4.Controls.Add(this.txtETMarca2);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtECliente2);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtEModelo2);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtEMarca2);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(5, 99);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 147);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mais Vendas";
            // 
            // txtETCliente2
            // 
            this.txtETCliente2.Location = new System.Drawing.Point(249, 105);
            this.txtETCliente2.Name = "txtETCliente2";
            this.txtETCliente2.ReadOnly = true;
            this.txtETCliente2.Size = new System.Drawing.Size(105, 27);
            this.txtETCliente2.TabIndex = 12;
            // 
            // txtETModelo2
            // 
            this.txtETModelo2.Location = new System.Drawing.Point(249, 72);
            this.txtETModelo2.Name = "txtETModelo2";
            this.txtETModelo2.ReadOnly = true;
            this.txtETModelo2.Size = new System.Drawing.Size(105, 27);
            this.txtETModelo2.TabIndex = 10;
            // 
            // txtETMarca2
            // 
            this.txtETMarca2.Location = new System.Drawing.Point(249, 39);
            this.txtETMarca2.Name = "txtETMarca2";
            this.txtETMarca2.ReadOnly = true;
            this.txtETMarca2.Size = new System.Drawing.Size(105, 27);
            this.txtETMarca2.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(279, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Total:";
            // 
            // txtECliente2
            // 
            this.txtECliente2.Location = new System.Drawing.Point(75, 107);
            this.txtECliente2.Name = "txtECliente2";
            this.txtECliente2.ReadOnly = true;
            this.txtECliente2.Size = new System.Drawing.Size(165, 27);
            this.txtECliente2.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "Cliente:";
            // 
            // txtEModelo2
            // 
            this.txtEModelo2.Location = new System.Drawing.Point(75, 72);
            this.txtEModelo2.Name = "txtEModelo2";
            this.txtEModelo2.ReadOnly = true;
            this.txtEModelo2.Size = new System.Drawing.Size(165, 27);
            this.txtEModelo2.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Modelo:";
            // 
            // txtEMarca2
            // 
            this.txtEMarca2.Location = new System.Drawing.Point(75, 39);
            this.txtEMarca2.Name = "txtEMarca2";
            this.txtEMarca2.ReadOnly = true;
            this.txtEMarca2.Size = new System.Drawing.Size(165, 27);
            this.txtEMarca2.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Marca:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 253);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 20);
            this.label18.TabIndex = 13;
            this.label18.Text = "Faturação total:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtpFim1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dtpInicio1);
            this.groupBox2.Controls.Add(this.txtFatTotal1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(3, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 289);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estatísticas 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Data de Fim:";
            // 
            // dtpFim1
            // 
            this.dtpFim1.Location = new System.Drawing.Point(194, 53);
            this.dtpFim1.Name = "dtpFim1";
            this.dtpFim1.Size = new System.Drawing.Size(121, 27);
            this.dtpFim1.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Data de Início:";
            // 
            // dtpInicio1
            // 
            this.dtpInicio1.Location = new System.Drawing.Point(53, 53);
            this.dtpInicio1.Name = "dtpInicio1";
            this.dtpInicio1.Size = new System.Drawing.Size(121, 27);
            this.dtpInicio1.TabIndex = 14;
            // 
            // txtFatTotal1
            // 
            this.txtFatTotal1.Location = new System.Drawing.Point(122, 251);
            this.txtFatTotal1.Name = "txtFatTotal1";
            this.txtFatTotal1.ReadOnly = true;
            this.txtFatTotal1.Size = new System.Drawing.Size(247, 27);
            this.txtFatTotal1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtETCliente1);
            this.groupBox1.Controls.Add(this.txtETModelo1);
            this.groupBox1.Controls.Add(this.txtETMarca1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtECliente1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEModelo1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEMarca1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(5, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 147);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mais Vendas";
            // 
            // txtETCliente1
            // 
            this.txtETCliente1.Location = new System.Drawing.Point(249, 105);
            this.txtETCliente1.Name = "txtETCliente1";
            this.txtETCliente1.ReadOnly = true;
            this.txtETCliente1.Size = new System.Drawing.Size(105, 27);
            this.txtETCliente1.TabIndex = 12;
            // 
            // txtETModelo1
            // 
            this.txtETModelo1.Location = new System.Drawing.Point(249, 72);
            this.txtETModelo1.Name = "txtETModelo1";
            this.txtETModelo1.ReadOnly = true;
            this.txtETModelo1.Size = new System.Drawing.Size(105, 27);
            this.txtETModelo1.TabIndex = 10;
            // 
            // txtETMarca1
            // 
            this.txtETMarca1.Location = new System.Drawing.Point(249, 39);
            this.txtETMarca1.Name = "txtETMarca1";
            this.txtETMarca1.ReadOnly = true;
            this.txtETMarca1.Size = new System.Drawing.Size(105, 27);
            this.txtETMarca1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total:";
            // 
            // txtECliente1
            // 
            this.txtECliente1.Location = new System.Drawing.Point(75, 107);
            this.txtECliente1.Name = "txtECliente1";
            this.txtECliente1.ReadOnly = true;
            this.txtECliente1.Size = new System.Drawing.Size(165, 27);
            this.txtECliente1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cliente:";
            // 
            // txtEModelo1
            // 
            this.txtEModelo1.Location = new System.Drawing.Point(75, 72);
            this.txtEModelo1.Name = "txtEModelo1";
            this.txtEModelo1.ReadOnly = true;
            this.txtEModelo1.Size = new System.Drawing.Size(165, 27);
            this.txtEModelo1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Modelo:";
            // 
            // txtEMarca1
            // 
            this.txtEMarca1.Location = new System.Drawing.Point(75, 39);
            this.txtEMarca1.Name = "txtEMarca1";
            this.txtEMarca1.ReadOnly = true;
            this.txtEMarca1.Size = new System.Drawing.Size(165, 27);
            this.txtEMarca1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Marca:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Faturação total:";
            // 
            // btnAtualizarEstatisticas
            // 
            this.btnAtualizarEstatisticas.Location = new System.Drawing.Point(305, 347);
            this.btnAtualizarEstatisticas.Name = "btnAtualizarEstatisticas";
            this.btnAtualizarEstatisticas.Size = new System.Drawing.Size(160, 29);
            this.btnAtualizarEstatisticas.TabIndex = 0;
            this.btnAtualizarEstatisticas.Text = "Atualizar Estatísticas";
            this.btnAtualizarEstatisticas.UseVisualStyleBackColor = true;
            this.btnAtualizarEstatisticas.Click += new System.EventHandler(this.btnAtualizarEstatisticas_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(305, 7);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(86, 31);
            this.btnTransferir.TabIndex = 6;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // AutoSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.tabTransacoes.PerformLayout();
            this.tabEventos.ResumeLayout(false);
            this.tabEventos.PerformLayout();
            this.tabEstatisticas.ResumeLayout(false);
            this.tabEstatisticas.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private Button btnConsultarCliente;
        private Button btnEditarCliente;
        private Button btnAdicionarCliente;
        private Button btnApagarCliente;
        private Button btnTroca;
        private TabPage tabEstatisticas;
        private GroupBox groupBox3;
        private Label label10;
        private DateTimePicker dtpFim2;
        private Label label13;
        private DateTimePicker dtpInicio2;
        private TextBox txtFatTotal2;
        private GroupBox groupBox4;
        private TextBox txtETCliente2;
        private TextBox txtETModelo2;
        private TextBox txtETMarca2;
        private Label label14;
        private TextBox txtECliente2;
        private Label label15;
        private TextBox txtEModelo2;
        private Label label16;
        private TextBox txtEMarca2;
        private Label label17;
        private Label label18;
        private GroupBox groupBox2;
        private Label label9;
        private DateTimePicker dtpFim1;
        private Label label12;
        private DateTimePicker dtpInicio1;
        private TextBox txtFatTotal1;
        private GroupBox groupBox1;
        private TextBox txtETCliente1;
        private TextBox txtETModelo1;
        private TextBox txtETMarca1;
        private Label label8;
        private TextBox txtECliente1;
        private Label label7;
        private TextBox txtEModelo1;
        private Label label6;
        private TextBox txtEMarca1;
        private Label label5;
        private Label label11;
        private Button btnAtualizarEstatisticas;
        private Label label19;
        private ComboBox cmbLojasTransacoes;
        private Label label20;
        private Button btnTransferir;
    }
}
