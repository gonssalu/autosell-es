namespace autosell
{
    partial class PrepararVeiculoForm
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
            this.lboxPecasSede = new System.Windows.Forms.ListBox();
            this.lboxPecasUtilizar = new System.Windows.Forms.ListBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxPecasSede
            // 
            this.lboxPecasSede.FormattingEnabled = true;
            this.lboxPecasSede.ItemHeight = 15;
            this.lboxPecasSede.Location = new System.Drawing.Point(27, 32);
            this.lboxPecasSede.Name = "lboxPecasSede";
            this.lboxPecasSede.Size = new System.Drawing.Size(212, 184);
            this.lboxPecasSede.TabIndex = 0;
            // 
            // lboxPecasUtilizar
            // 
            this.lboxPecasUtilizar.FormattingEnabled = true;
            this.lboxPecasUtilizar.ItemHeight = 15;
            this.lboxPecasUtilizar.Location = new System.Drawing.Point(405, 32);
            this.lboxPecasUtilizar.Name = "lboxPecasUtilizar";
            this.lboxPecasUtilizar.Size = new System.Drawing.Size(212, 184);
            this.lboxPecasUtilizar.TabIndex = 1;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(282, 55);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(282, 100);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(542, 222);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(461, 222);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // PrepararVeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 258);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lboxPecasUtilizar);
            this.Controls.Add(this.lboxPecasSede);
            this.Name = "PrepararVeiculoForm";
            this.Text = "PrepararVeiculoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lboxPecasSede;
        private ListBox lboxPecasUtilizar;
        private Button btnRight;
        private Button btnLeft;
        private Button btnVoltar;
        private Button btnGuardar;
    }
}