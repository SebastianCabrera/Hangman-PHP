namespace JuegoAhorcado
{
    partial class Form1
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
            this.panelEscondida = new System.Windows.Forms.Panel();
            this.buttonVerificar = new System.Windows.Forms.Button();
            this.labelEscondida = new System.Windows.Forms.Label();
            this.panelImagen = new System.Windows.Forms.Panel();
            this.textBoxLetra = new System.Windows.Forms.TextBox();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.labelIntentos = new System.Windows.Forms.Label();
            this.panelEscondida.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEscondida
            // 
            this.panelEscondida.Controls.Add(this.labelEscondida);
            this.panelEscondida.Location = new System.Drawing.Point(215, 101);
            this.panelEscondida.Name = "panelEscondida";
            this.panelEscondida.Size = new System.Drawing.Size(200, 100);
            this.panelEscondida.TabIndex = 0;
            // 
            // buttonVerificar
            // 
            this.buttonVerificar.Location = new System.Drawing.Point(299, 344);
            this.buttonVerificar.Name = "buttonVerificar";
            this.buttonVerificar.Size = new System.Drawing.Size(102, 37);
            this.buttonVerificar.TabIndex = 1;
            this.buttonVerificar.Text = "Verificar";
            this.buttonVerificar.UseVisualStyleBackColor = true;
            this.buttonVerificar.Click += new System.EventHandler(this.buttonVerificar_Click);
            // 
            // labelEscondida
            // 
            this.labelEscondida.AutoSize = true;
            this.labelEscondida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEscondida.Location = new System.Drawing.Point(0, 0);
            this.labelEscondida.Name = "labelEscondida";
            this.labelEscondida.Size = new System.Drawing.Size(82, 20);
            this.labelEscondida.TabIndex = 0;
            this.labelEscondida.Text = "escondida";
            // 
            // panelImagen
            // 
            this.panelImagen.Location = new System.Drawing.Point(545, 154);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(71, 100);
            this.panelImagen.TabIndex = 2;
            // 
            // textBoxLetra
            // 
            this.textBoxLetra.Location = new System.Drawing.Point(299, 264);
            this.textBoxLetra.Name = "textBoxLetra";
            this.textBoxLetra.Size = new System.Drawing.Size(100, 26);
            this.textBoxLetra.TabIndex = 4;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Location = new System.Drawing.Point(327, 412);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(51, 20);
            this.labelMensaje.TabIndex = 5;
            this.labelMensaje.Text = "label1";
            // 
            // labelIntentos
            // 
            this.labelIntentos.AutoSize = true;
            this.labelIntentos.Location = new System.Drawing.Point(545, 409);
            this.labelIntentos.Name = "labelIntentos";
            this.labelIntentos.Size = new System.Drawing.Size(51, 20);
            this.labelIntentos.TabIndex = 6;
            this.labelIntentos.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 441);
            this.Controls.Add(this.labelIntentos);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.textBoxLetra);
            this.Controls.Add(this.panelImagen);
            this.Controls.Add(this.buttonVerificar);
            this.Controls.Add(this.panelEscondida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelEscondida.ResumeLayout(false);
            this.panelEscondida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEscondida;
        private System.Windows.Forms.Label labelEscondida;
        private System.Windows.Forms.Button buttonVerificar;
        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.TextBox textBoxLetra;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.Label labelIntentos;
    }
}

