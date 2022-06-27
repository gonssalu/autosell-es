namespace autosell
{
    partial class JanelaEvento
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
            if (disposing && (components != null))
            {
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
            this.btnAgendar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbLojas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkForaLoja = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutroLocal = new System.Windows.Forms.TextBox();
            this.btnAssociarVeiculos = new System.Windows.Forms.Button();
            this.lblVeiAss = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(335, 199);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(94, 29);
            this.btnAgendar.TabIndex = 0;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(96, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(333, 27);
            this.txtNome.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Data de Fim:";
            // 
            // dtpFim
            // 
            this.dtpFim.Location = new System.Drawing.Point(236, 90);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(193, 27);
            this.dtpFim.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Data de Início:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(37, 90);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(193, 27);
            this.dtpInicio.TabIndex = 18;
            // 
            // cmbLojas
            // 
            this.cmbLojas.FormattingEnabled = true;
            this.cmbLojas.Location = new System.Drawing.Point(129, 129);
            this.cmbLojas.Name = "cmbLojas";
            this.cmbLojas.Size = new System.Drawing.Size(151, 28);
            this.cmbLojas.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Loja:";
            // 
            // chkForaLoja
            // 
            this.chkForaLoja.AutoSize = true;
            this.chkForaLoja.Location = new System.Drawing.Point(286, 131);
            this.chkForaLoja.Name = "chkForaLoja";
            this.chkForaLoja.Size = new System.Drawing.Size(143, 24);
            this.chkForaLoja.TabIndex = 25;
            this.chkForaLoja.Text = "Fora de uma loja";
            this.chkForaLoja.UseVisualStyleBackColor = true;
            this.chkForaLoja.CheckedChanged += new System.EventHandler(this.chkForaLoja_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Outro local:";
            // 
            // txtOutroLocal
            // 
            this.txtOutroLocal.Enabled = false;
            this.txtOutroLocal.Location = new System.Drawing.Point(129, 166);
            this.txtOutroLocal.Name = "txtOutroLocal";
            this.txtOutroLocal.ReadOnly = true;
            this.txtOutroLocal.Size = new System.Drawing.Size(300, 27);
            this.txtOutroLocal.TabIndex = 27;
            // 
            // btnAssociarVeiculos
            // 
            this.btnAssociarVeiculos.Location = new System.Drawing.Point(168, 199);
            this.btnAssociarVeiculos.Name = "btnAssociarVeiculos";
            this.btnAssociarVeiculos.Size = new System.Drawing.Size(161, 29);
            this.btnAssociarVeiculos.TabIndex = 28;
            this.btnAssociarVeiculos.Text = "Associar Veículos";
            this.btnAssociarVeiculos.UseVisualStyleBackColor = true;
            this.btnAssociarVeiculos.Click += new System.EventHandler(this.btnAssociarVeiculos_Click);
            // 
            // lblVeiAss
            // 
            this.lblVeiAss.AutoSize = true;
            this.lblVeiAss.ForeColor = System.Drawing.Color.Red;
            this.lblVeiAss.Location = new System.Drawing.Point(168, 238);
            this.lblVeiAss.Name = "lblVeiAss";
            this.lblVeiAss.Size = new System.Drawing.Size(154, 20);
            this.lblVeiAss.TabIndex = 29;
            this.lblVeiAss.Text = "Veículos associados: 0";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(335, 234);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(94, 29);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(335, 199);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 29);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // JanelaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 282);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblVeiAss);
            this.Controls.Add(this.btnAssociarVeiculos);
            this.Controls.Add(this.txtOutroLocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkForaLoja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLojas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JanelaEvento";
            this.Text = "Agendar Evento";
            this.Load += new System.EventHandler(this.JanelaEvento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAgendar;
        private Label label1;
        private TextBox txtNome;
        private Label label9;
        private DateTimePicker dtpFim;
        private Label label12;
        private DateTimePicker dtpInicio;
        private ComboBox cmbLojas;
        private Label label2;
        private CheckBox chkForaLoja;
        private Label label3;
        private TextBox txtOutroLocal;
        private Button btnAssociarVeiculos;
        private Label lblVeiAss;
        private Button btnVoltar;
        private Button btnGuardar;
    }
}