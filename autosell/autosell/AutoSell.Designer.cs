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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.tabVeiculos = new System.Windows.Forms.TabPage();
            this.tabTransacoes = new System.Windows.Forms.TabPage();
            this.tabEventos = new System.Windows.Forms.TabPage();
            this.tabEstatisticas = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabInicio.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInicio
            // 
            this.tabInicio.Controls.Add(this.listBox1);
            this.tabInicio.Controls.Add(this.label2);
            this.tabInicio.Controls.Add(this.label1);
            this.tabInicio.Location = new System.Drawing.Point(4, 29);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Size = new System.Drawing.Size(768, 393);
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
            this.tabClientes.Location = new System.Drawing.Point(4, 29);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(768, 393);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // tabVeiculos
            // 
            this.tabVeiculos.Location = new System.Drawing.Point(4, 29);
            this.tabVeiculos.Name = "tabVeiculos";
            this.tabVeiculos.Padding = new System.Windows.Forms.Padding(3);
            this.tabVeiculos.Size = new System.Drawing.Size(768, 393);
            this.tabVeiculos.TabIndex = 1;
            this.tabVeiculos.Text = "Veículos";
            this.tabVeiculos.UseVisualStyleBackColor = true;
            // 
            // tabTransacoes
            // 
            this.tabTransacoes.Location = new System.Drawing.Point(4, 29);
            this.tabTransacoes.Name = "tabTransacoes";
            this.tabTransacoes.Size = new System.Drawing.Size(768, 393);
            this.tabTransacoes.TabIndex = 2;
            this.tabTransacoes.Text = "Transações";
            this.tabTransacoes.UseVisualStyleBackColor = true;
            // 
            // tabEventos
            // 
            this.tabEventos.Location = new System.Drawing.Point(4, 29);
            this.tabEventos.Name = "tabEventos";
            this.tabEventos.Size = new System.Drawing.Size(768, 393);
            this.tabEventos.TabIndex = 3;
            this.tabEventos.Text = "Eventos";
            this.tabEventos.UseVisualStyleBackColor = true;
            // 
            // tabEstatisticas
            // 
            this.tabEstatisticas.Location = new System.Drawing.Point(4, 29);
            this.tabEstatisticas.Name = "tabEstatisticas";
            this.tabEstatisticas.Size = new System.Drawing.Size(768, 393);
            this.tabEstatisticas.TabIndex = 4;
            this.tabEstatisticas.Text = "Estatísticas";
            this.tabEstatisticas.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(211, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(354, 204);
            this.listBox1.TabIndex = 2;
            // 
            // AutoSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AutoSell";
            this.Text = "AutoSell";
            this.Load += new System.EventHandler(this.AutoSell_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.tabInicio.PerformLayout();
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
        private ListBox listBox1;
    }
}