namespace JuegoAhorcado
{
    partial class Inicio
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelIndicacion = new System.Windows.Forms.Label();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.tableLayoutPanelMejorTiempo = new System.Windows.Forms.TableLayoutPanel();
            this.labelTituloMejorTiempo = new System.Windows.Forms.Label();
            this.labelInfoMejorTiempo = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            this.tableLayoutPanelMejorTiempo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.labelTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1172, 100);
            this.panelTitulo.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitulo.Font = new System.Drawing.Font("Perpetua Titling MT", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(222, 38);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Ahorcado";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(87, 301);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(215, 26);
            this.textBoxNombre.TabIndex = 1;
            // 
            // labelIndicacion
            // 
            this.labelIndicacion.AutoSize = true;
            this.labelIndicacion.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.labelIndicacion.Location = new System.Drawing.Point(83, 227);
            this.labelIndicacion.Name = "labelIndicacion";
            this.labelIndicacion.Size = new System.Drawing.Size(374, 24);
            this.labelIndicacion.TabIndex = 2;
            this.labelIndicacion.Text = "Por favor, ingrese su nombre";
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.buttonIniciar.Location = new System.Drawing.Point(87, 566);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(111, 50);
            this.buttonIniciar.TabIndex = 3;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // tableLayoutPanelMejorTiempo
            // 
            this.tableLayoutPanelMejorTiempo.ColumnCount = 1;
            this.tableLayoutPanelMejorTiempo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMejorTiempo.Controls.Add(this.labelTituloMejorTiempo, 0, 0);
            this.tableLayoutPanelMejorTiempo.Controls.Add(this.labelInfoMejorTiempo, 0, 1);
            this.tableLayoutPanelMejorTiempo.Location = new System.Drawing.Point(561, 196);
            this.tableLayoutPanelMejorTiempo.Name = "tableLayoutPanelMejorTiempo";
            this.tableLayoutPanelMejorTiempo.RowCount = 2;
            this.tableLayoutPanelMejorTiempo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMejorTiempo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelMejorTiempo.Size = new System.Drawing.Size(575, 440);
            this.tableLayoutPanelMejorTiempo.TabIndex = 4;
            // 
            // labelTituloMejorTiempo
            // 
            this.labelTituloMejorTiempo.AutoSize = true;
            this.labelTituloMejorTiempo.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.labelTituloMejorTiempo.Location = new System.Drawing.Point(3, 0);
            this.labelTituloMejorTiempo.Name = "labelTituloMejorTiempo";
            this.labelTituloMejorTiempo.Size = new System.Drawing.Size(297, 24);
            this.labelTituloMejorTiempo.TabIndex = 0;
            this.labelTituloMejorTiempo.Text = "Diez mejores jugadores";
            // 
            // labelInfoMejorTiempo
            // 
            this.labelInfoMejorTiempo.AutoSize = true;
            this.labelInfoMejorTiempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInfoMejorTiempo.Font = new System.Drawing.Font("Perpetua Titling MT", 10F, System.Drawing.FontStyle.Bold);
            this.labelInfoMejorTiempo.Location = new System.Drawing.Point(3, 88);
            this.labelInfoMejorTiempo.Name = "labelInfoMejorTiempo";
            this.labelInfoMejorTiempo.Size = new System.Drawing.Size(569, 352);
            this.labelInfoMejorTiempo.TabIndex = 1;
            this.labelInfoMejorTiempo.Text = "label1";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 648);
            this.Controls.Add(this.tableLayoutPanelMejorTiempo);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.labelIndicacion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.panelTitulo);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.tableLayoutPanelMejorTiempo.ResumeLayout(false);
            this.tableLayoutPanelMejorTiempo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelIndicacion;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMejorTiempo;
        private System.Windows.Forms.Label labelTituloMejorTiempo;
        private System.Windows.Forms.Label labelInfoMejorTiempo;
    }
}