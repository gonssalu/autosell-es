namespace autosell
{
    partial class SelecionarVeiculos
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
            this.lstFirst = new System.Windows.Forms.ListBox();
            this.lstSecond = new System.Windows.Forms.ListBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnDesselecionar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFirst
            // 
            this.lstFirst.FormattingEnabled = true;
            this.lstFirst.ItemHeight = 20;
            this.lstFirst.Location = new System.Drawing.Point(12, 58);
            this.lstFirst.Name = "lstFirst";
            this.lstFirst.Size = new System.Drawing.Size(277, 244);
            this.lstFirst.TabIndex = 0;
            this.lstFirst.SelectedIndexChanged += new System.EventHandler(this.lstFirst_SelectedIndexChanged);
            // 
            // lstSecond
            // 
            this.lstSecond.FormattingEnabled = true;
            this.lstSecond.ItemHeight = 20;
            this.lstSecond.Location = new System.Drawing.Point(451, 58);
            this.lstSecond.Name = "lstSecond";
            this.lstSecond.Size = new System.Drawing.Size(277, 244);
            this.lstSecond.TabIndex = 1;
            this.lstSecond.SelectedIndexChanged += new System.EventHandler(this.lstSecond_SelectedIndexChanged);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Enabled = false;
            this.btnSelecionar.Location = new System.Drawing.Point(314, 58);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(110, 52);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnDesselecionar
            // 
            this.btnDesselecionar.Enabled = false;
            this.btnDesselecionar.Location = new System.Drawing.Point(314, 126);
            this.btnDesselecionar.Name = "btnDesselecionar";
            this.btnDesselecionar.Size = new System.Drawing.Size(110, 52);
            this.btnDesselecionar.TabIndex = 3;
            this.btnDesselecionar.Text = "Desselecionar";
            this.btnDesselecionar.UseVisualStyleBackColor = true;
            this.btnDesselecionar.Click += new System.EventHandler(this.btnDesselecionar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(314, 273);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(110, 29);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(314, 238);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 29);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // SelecionarVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 323);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnDesselecionar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.lstSecond);
            this.Controls.Add(this.lstFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelecionarVeiculos";
            this.Text = "Selecionar Veiculos";
            this.Load += new System.EventHandler(this.SelecionarVeiculos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstFirst;
        public ListBox lstSecond;
        private Button btnSelecionar;
        private Button btnDesselecionar;
        private Button btnConfirmar;
        private Button btnVoltar;
    }
}