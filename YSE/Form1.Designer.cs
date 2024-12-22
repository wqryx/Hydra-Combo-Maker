namespace PruebaWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable necesaria para el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar cualquier recurso que se esté utilizando.
        /// </summary>
        /// <param name="disposing">Si se deben eliminar los recursos administrados.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxCarpeta = new System.Windows.Forms.TextBox();
            this.textBoxPalabra = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.comboBoxOpcion = new System.Windows.Forms.ComboBox();
            this.labelCarpeta = new System.Windows.Forms.Label();
            this.labelPalabra = new System.Windows.Forms.Label();
            this.labelOpcion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDibujo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCarpeta
            // 
            this.textBoxCarpeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.textBoxCarpeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCarpeta.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxCarpeta.ForeColor = System.Drawing.Color.White;
            this.textBoxCarpeta.Location = new System.Drawing.Point(476, 418);
            this.textBoxCarpeta.Name = "textBoxCarpeta";
            this.textBoxCarpeta.Size = new System.Drawing.Size(260, 23);
            this.textBoxCarpeta.TabIndex = 0;
            // 
            // textBoxPalabra
            // 
            this.textBoxPalabra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.textBoxPalabra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPalabra.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxPalabra.ForeColor = System.Drawing.Color.White;
            this.textBoxPalabra.Location = new System.Drawing.Point(476, 457);
            this.textBoxPalabra.Name = "textBoxPalabra";
            this.textBoxPalabra.Size = new System.Drawing.Size(260, 23);
            this.textBoxPalabra.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Location = new System.Drawing.Point(476, 539);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(260, 35);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // comboBoxOpcion
            // 
            this.comboBoxOpcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.comboBoxOpcion.Font = new System.Drawing.Font("Arial", 10F);
            this.comboBoxOpcion.ForeColor = System.Drawing.Color.White;
            this.comboBoxOpcion.FormattingEnabled = true;
            this.comboBoxOpcion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxOpcion.Location = new System.Drawing.Point(476, 496);
            this.comboBoxOpcion.Name = "comboBoxOpcion";
            this.comboBoxOpcion.Size = new System.Drawing.Size(260, 24);
            this.comboBoxOpcion.TabIndex = 3;
            // 
            // labelCarpeta
            // 
            this.labelCarpeta.AutoSize = true;
            this.labelCarpeta.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelCarpeta.ForeColor = System.Drawing.Color.White;
            this.labelCarpeta.Location = new System.Drawing.Point(476, 402);
            this.labelCarpeta.Name = "labelCarpeta";
            this.labelCarpeta.Size = new System.Drawing.Size(138, 16);
            this.labelCarpeta.TabIndex = 4;
            this.labelCarpeta.Text = "Ruta de la carpeta:";
            // 
            // labelPalabra
            // 
            this.labelPalabra.AutoSize = true;
            this.labelPalabra.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelPalabra.ForeColor = System.Drawing.Color.White;
            this.labelPalabra.Location = new System.Drawing.Point(476, 441);
            this.labelPalabra.Name = "labelPalabra";
            this.labelPalabra.Size = new System.Drawing.Size(239, 16);
            this.labelPalabra.TabIndex = 5;
            this.labelPalabra.Text = "Palabra a buscar en los archivos:";
            // 
            // labelOpcion
            // 
            this.labelOpcion.AutoSize = true;
            this.labelOpcion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelOpcion.ForeColor = System.Drawing.Color.White;
            this.labelOpcion.Location = new System.Drawing.Point(476, 480);
            this.labelOpcion.Name = "labelOpcion";
            this.labelOpcion.Size = new System.Drawing.Size(163, 16);
            this.labelOpcion.TabIndex = 6;
            this.labelOpcion.Text = "Elige una opción (1-5):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 10);
            this.panel1.TabIndex = 7;
            // 
            // labelDibujo
            // 
            this.labelDibujo.Font = new System.Drawing.Font("Consolas", 8F);
            this.labelDibujo.ForeColor = System.Drawing.Color.White;
            this.labelDibujo.Location = new System.Drawing.Point(398, 52);
            this.labelDibujo.Name = "labelDibujo";
            this.labelDibujo.Size = new System.Drawing.Size(416, 312);
            this.labelDibujo.TabIndex = 8;
            this.labelDibujo.Text = resources.GetString("labelDibujo.Text");
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1212, 799);
            this.Controls.Add(this.labelDibujo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelOpcion);
            this.Controls.Add(this.labelPalabra);
            this.Controls.Add(this.labelCarpeta);
            this.Controls.Add(this.comboBoxOpcion);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxPalabra);
            this.Controls.Add(this.textBoxCarpeta);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCarpeta;
        private System.Windows.Forms.TextBox textBoxPalabra;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ComboBox comboBoxOpcion;
        private System.Windows.Forms.Label labelCarpeta;
        private System.Windows.Forms.Label labelPalabra;
        private System.Windows.Forms.Label labelOpcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDibujo;
    }
}