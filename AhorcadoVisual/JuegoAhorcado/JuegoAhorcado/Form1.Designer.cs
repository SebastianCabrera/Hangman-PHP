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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelEscondida = new System.Windows.Forms.Panel();
            this.labelEscondida = new System.Windows.Forms.Label();
            this.buttonVerificar = new System.Windows.Forms.Button();
            this.panelImagen = new System.Windows.Forms.Panel();
            this.labelImagen = new System.Windows.Forms.Label();
            this.textBoxLetra = new System.Windows.Forms.TextBox();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.labelIntentos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelPalabra = new System.Windows.Forms.Panel();
            this.labelPalabra = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonNuevaPalabra = new System.Windows.Forms.Button();
            this.panelRepetidas = new System.Windows.Forms.Panel();
            this.labelRepetidas = new System.Windows.Forms.Label();
            this.labelTituloRepetidas = new System.Windows.Forms.Label();
            this.labelAviso = new System.Windows.Forms.Label();
            this.panelEscondida.SuspendLayout();
            this.panelImagen.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelPalabra.SuspendLayout();
            this.panelRepetidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEscondida
            // 
            this.panelEscondida.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelEscondida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEscondida.Controls.Add(this.labelEscondida);
            this.panelEscondida.Location = new System.Drawing.Point(316, 303);
            this.panelEscondida.Name = "panelEscondida";
            this.panelEscondida.Size = new System.Drawing.Size(359, 100);
            this.panelEscondida.TabIndex = 0;
            // 
            // labelEscondida
            // 
            this.labelEscondida.AutoSize = true;
            this.labelEscondida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEscondida.Font = new System.Drawing.Font("Perpetua Titling MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEscondida.Location = new System.Drawing.Point(0, 0);
            this.labelEscondida.Name = "labelEscondida";
            this.labelEscondida.Size = new System.Drawing.Size(220, 38);
            this.labelEscondida.TabIndex = 0;
            this.labelEscondida.Text = "escondida";
            this.labelEscondida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonVerificar
            // 
            this.buttonVerificar.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.buttonVerificar.Location = new System.Drawing.Point(435, 492);
            this.buttonVerificar.Name = "buttonVerificar";
            this.buttonVerificar.Size = new System.Drawing.Size(138, 41);
            this.buttonVerificar.TabIndex = 1;
            this.buttonVerificar.Text = "Verificar";
            this.buttonVerificar.UseVisualStyleBackColor = true;
            this.buttonVerificar.Click += new System.EventHandler(this.buttonVerificar_Click);
            // 
            // panelImagen
            // 
            this.panelImagen.Controls.Add(this.labelImagen);
            this.panelImagen.Location = new System.Drawing.Point(299, 24);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(376, 256);
            this.panelImagen.TabIndex = 2;
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelImagen.Image = ((System.Drawing.Image)(resources.GetObject("labelImagen.Image")));
            this.labelImagen.Location = new System.Drawing.Point(0, 0);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(51, 20);
            this.labelImagen.TabIndex = 0;
            this.labelImagen.Text = "label1";
            // 
            // textBoxLetra
            // 
            this.textBoxLetra.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxLetra.Location = new System.Drawing.Point(455, 435);
            this.textBoxLetra.Name = "textBoxLetra";
            this.textBoxLetra.Size = new System.Drawing.Size(100, 32);
            this.textBoxLetra.TabIndex = 4;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMensaje.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.labelMensaje.Location = new System.Drawing.Point(0, 0);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(105, 24);
            this.labelMensaje.TabIndex = 5;
            this.labelMensaje.Text = "Mensaje";
            // 
            // labelIntentos
            // 
            this.labelIntentos.AutoSize = true;
            this.labelIntentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIntentos.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.labelIntentos.Location = new System.Drawing.Point(0, 0);
            this.labelIntentos.Name = "labelIntentos";
            this.labelIntentos.Size = new System.Drawing.Size(183, 24);
            this.labelIntentos.TabIndex = 6;
            this.labelIntentos.Text = "labelIntentos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMensaje);
            this.panel1.Location = new System.Drawing.Point(86, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 37);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelIntentos);
            this.panel2.Location = new System.Drawing.Point(696, 550);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 36);
            this.panel2.TabIndex = 8;
            // 
            // panelPalabra
            // 
            this.panelPalabra.Controls.Add(this.labelPalabra);
            this.panelPalabra.Location = new System.Drawing.Point(40, 224);
            this.panelPalabra.Name = "panelPalabra";
            this.panelPalabra.Size = new System.Drawing.Size(200, 100);
            this.panelPalabra.TabIndex = 9;
            // 
            // labelPalabra
            // 
            this.labelPalabra.AutoSize = true;
            this.labelPalabra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPalabra.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.labelPalabra.Location = new System.Drawing.Point(0, 0);
            this.labelPalabra.Name = "labelPalabra";
            this.labelPalabra.Size = new System.Drawing.Size(186, 24);
            this.labelPalabra.TabIndex = 0;
            this.labelPalabra.Text = " labelPalabra";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.png");
            this.imageList1.Images.SetKeyName(1, "1.png");
            this.imageList1.Images.SetKeyName(2, "2.png");
            this.imageList1.Images.SetKeyName(3, "3.png");
            this.imageList1.Images.SetKeyName(4, "4.png");
            this.imageList1.Images.SetKeyName(5, "5.png");
            this.imageList1.Images.SetKeyName(6, "6.png");
            this.imageList1.Images.SetKeyName(7, "7.png");
            this.imageList1.Images.SetKeyName(8, "8.png");
            this.imageList1.Images.SetKeyName(9, "9.png");
            // 
            // buttonNuevaPalabra
            // 
            this.buttonNuevaPalabra.Location = new System.Drawing.Point(44, 24);
            this.buttonNuevaPalabra.Name = "buttonNuevaPalabra";
            this.buttonNuevaPalabra.Size = new System.Drawing.Size(159, 37);
            this.buttonNuevaPalabra.TabIndex = 10;
            this.buttonNuevaPalabra.Text = "Nueva palabra";
            this.buttonNuevaPalabra.UseVisualStyleBackColor = true;
            this.buttonNuevaPalabra.Click += new System.EventHandler(this.buttonNuevaPalabra_Click);
            // 
            // panelRepetidas
            // 
            this.panelRepetidas.Controls.Add(this.labelRepetidas);
            this.panelRepetidas.Location = new System.Drawing.Point(708, 303);
            this.panelRepetidas.Name = "panelRepetidas";
            this.panelRepetidas.Size = new System.Drawing.Size(308, 100);
            this.panelRepetidas.TabIndex = 11;
            // 
            // labelRepetidas
            // 
            this.labelRepetidas.AutoSize = true;
            this.labelRepetidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRepetidas.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepetidas.Location = new System.Drawing.Point(0, 0);
            this.labelRepetidas.Name = "labelRepetidas";
            this.labelRepetidas.Size = new System.Drawing.Size(83, 24);
            this.labelRepetidas.TabIndex = 0;
            this.labelRepetidas.Text = "label1";
            // 
            // labelTituloRepetidas
            // 
            this.labelTituloRepetidas.AutoSize = true;
            this.labelTituloRepetidas.Font = new System.Drawing.Font("Perpetua Titling MT", 16F, System.Drawing.FontStyle.Bold);
            this.labelTituloRepetidas.Location = new System.Drawing.Point(712, 264);
            this.labelTituloRepetidas.Name = "labelTituloRepetidas";
            this.labelTituloRepetidas.Size = new System.Drawing.Size(298, 38);
            this.labelTituloRepetidas.TabIndex = 12;
            this.labelTituloRepetidas.Text = "Letras usadas:";
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.labelAviso.Location = new System.Drawing.Point(577, 437);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(439, 24);
            this.labelAviso.TabIndex = 13;
            this.labelAviso.Text = "El caracter es invalido o repetido";
            this.labelAviso.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 622);
            this.Controls.Add(this.labelAviso);
            this.Controls.Add(this.labelTituloRepetidas);
            this.Controls.Add(this.panelRepetidas);
            this.Controls.Add(this.buttonNuevaPalabra);
            this.Controls.Add(this.panelPalabra);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxLetra);
            this.Controls.Add(this.panelImagen);
            this.Controls.Add(this.buttonVerificar);
            this.Controls.Add(this.panelEscondida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelEscondida.ResumeLayout(false);
            this.panelEscondida.PerformLayout();
            this.panelImagen.ResumeLayout(false);
            this.panelImagen.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelPalabra.ResumeLayout(false);
            this.panelPalabra.PerformLayout();
            this.panelRepetidas.ResumeLayout(false);
            this.panelRepetidas.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelPalabra;
        private System.Windows.Forms.Label labelPalabra;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonNuevaPalabra;
        private System.Windows.Forms.Panel panelRepetidas;
        private System.Windows.Forms.Label labelRepetidas;
        private System.Windows.Forms.Label labelTituloRepetidas;
        private System.Windows.Forms.Label labelAviso;
        private System.Windows.Forms.Label labelImagen;
    }
}

