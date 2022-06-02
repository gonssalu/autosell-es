namespace autosell
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnPecas = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnTransacoes = new System.Windows.Forms.Button();
            this.btnEstatisticas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.Location = new System.Drawing.Point(136, 162);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(141, 47);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVeiculos.Location = new System.Drawing.Point(369, 162);
            this.btnVeiculos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(141, 47);
            this.btnVeiculos.TabIndex = 1;
            this.btnVeiculos.Text = "Veículos";
            this.btnVeiculos.UseVisualStyleBackColor = true;
            // 
            // btnPecas
            // 
            this.btnPecas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPecas.Location = new System.Drawing.Point(600, 162);
            this.btnPecas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPecas.Name = "btnPecas";
            this.btnPecas.Size = new System.Drawing.Size(141, 47);
            this.btnPecas.TabIndex = 2;
            this.btnPecas.Text = "Peças";
            this.btnPecas.UseVisualStyleBackColor = true;
            // 
            // btnEventos
            // 
            this.btnEventos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEventos.Location = new System.Drawing.Point(136, 261);
            this.btnEventos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(141, 47);
            this.btnEventos.TabIndex = 3;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = true;
            // 
            // btnTransacoes
            // 
            this.btnTransacoes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransacoes.Location = new System.Drawing.Point(369, 261);
            this.btnTransacoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTransacoes.Name = "btnTransacoes";
            this.btnTransacoes.Size = new System.Drawing.Size(141, 47);
            this.btnTransacoes.TabIndex = 4;
            this.btnTransacoes.Text = "Transações";
            this.btnTransacoes.UseVisualStyleBackColor = true;
            // 
            // btnEstatisticas
            // 
            this.btnEstatisticas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEstatisticas.Location = new System.Drawing.Point(600, 261);
            this.btnEstatisticas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEstatisticas.Name = "btnEstatisticas";
            this.btnEstatisticas.Size = new System.Drawing.Size(141, 47);
            this.btnEstatisticas.TabIndex = 5;
            this.btnEstatisticas.Text = "Estatísticas";
            this.btnEstatisticas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 472);
            this.Controls.Add(this.btnEstatisticas);
            this.Controls.Add(this.btnTransacoes);
            this.Controls.Add(this.btnEventos);
            this.Controls.Add(this.btnPecas);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.btnClientes);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Menu - AutoSell";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnClientes;
        private Button btnVeiculos;
        private Button btnPecas;
        private Button btnEventos;
        private Button btnTransacoes;
        private Button btnEstatisticas;
    }
}