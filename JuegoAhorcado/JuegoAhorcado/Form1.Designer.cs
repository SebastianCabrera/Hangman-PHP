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
            this.panelPalabraEscondida = new System.Windows.Forms.Panel();
            this.panelImagen = new System.Windows.Forms.Panel();
            this.labelPalabraEscondida = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.panelPalabraEscondida.SuspendLayout();
            this.panelImagen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPalabraEscondida
            // 
            this.panelPalabraEscondida.Controls.Add(this.labelPalabraEscondida);
            this.panelPalabraEscondida.Location = new System.Drawing.Point(383, 153);
            this.panelPalabraEscondida.Name = "panelPalabraEscondida";
            this.panelPalabraEscondida.Size = new System.Drawing.Size(200, 100);
            this.panelPalabraEscondida.TabIndex = 0;
            // 
            // panelImagen
            // 
            this.panelImagen.Controls.Add(this.labelImage);
            this.panelImagen.Location = new System.Drawing.Point(383, 438);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(200, 100);
            this.panelImagen.TabIndex = 1;
            // 
            // labelPalabraEscondida
            // 
            this.labelPalabraEscondida.AutoSize = true;
            this.labelPalabraEscondida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPalabraEscondida.Location = new System.Drawing.Point(0, 0);
            this.labelPalabraEscondida.Name = "labelPalabraEscondida";
            this.labelPalabraEscondida.Size = new System.Drawing.Size(140, 20);
            this.labelPalabraEscondida.TabIndex = 0;
            this.labelPalabraEscondida.Text = "Palabra escondida";
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelImage.Location = new System.Drawing.Point(0, 0);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(51, 20);
            this.labelImage.TabIndex = 0;
            this.labelImage.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 670);
            this.Controls.Add(this.panelImagen);
            this.Controls.Add(this.panelPalabraEscondida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelPalabraEscondida.ResumeLayout(false);
            this.panelPalabraEscondida.PerformLayout();
            this.panelImagen.ResumeLayout(false);
            this.panelImagen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPalabraEscondida;
        private System.Windows.Forms.Label labelPalabraEscondida;
        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.Label labelImage;
    }
}

