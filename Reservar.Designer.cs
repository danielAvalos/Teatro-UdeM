namespace TeatroUdeM
{
    partial class Reservar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btonRegresar = new System.Windows.Forms.Button();
            this.btonMostrarMapaInt = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.ListadoEventosDis = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 461);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btonRegresar
            // 
            this.btonRegresar.BackColor = System.Drawing.Color.DarkRed;
            this.btonRegresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btonRegresar.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btonRegresar.ForeColor = System.Drawing.Color.White;
            this.btonRegresar.Location = new System.Drawing.Point(0, 573);
            this.btonRegresar.Name = "btonRegresar";
            this.btonRegresar.Size = new System.Drawing.Size(658, 50);
            this.btonRegresar.TabIndex = 1;
            this.btonRegresar.Text = "Regresar";
            this.btonRegresar.UseVisualStyleBackColor = false;
            this.btonRegresar.Click += new System.EventHandler(this.btonRegresar_Click);
            // 
            // btonMostrarMapaInt
            // 
            this.btonMostrarMapaInt.BackColor = System.Drawing.Color.DarkRed;
            this.btonMostrarMapaInt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btonMostrarMapaInt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btonMostrarMapaInt.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btonMostrarMapaInt.ForeColor = System.Drawing.Color.White;
            this.btonMostrarMapaInt.Location = new System.Drawing.Point(0, 523);
            this.btonMostrarMapaInt.Name = "btonMostrarMapaInt";
            this.btonMostrarMapaInt.Size = new System.Drawing.Size(658, 50);
            this.btonMostrarMapaInt.TabIndex = 2;
            this.btonMostrarMapaInt.Text = "Mostrar Mapa Interactivo";
            this.btonMostrarMapaInt.UseVisualStyleBackColor = false;
            this.btonMostrarMapaInt.Click += new System.EventHandler(this.btonMostrarMapaInt_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(54, 485);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(181, 19);
            this.lblDescripcion.TabIndex = 21;
            this.lblDescripcion.Text = "EVENTOS DISPONIBLES";
            // 
            // ListadoEventosDis
            // 
            this.ListadoEventosDis.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.ListadoEventosDis.FormattingEnabled = true;
            this.ListadoEventosDis.Location = new System.Drawing.Point(241, 482);
            this.ListadoEventosDis.Name = "ListadoEventosDis";
            this.ListadoEventosDis.Size = new System.Drawing.Size(321, 27);
            this.ListadoEventosDis.TabIndex = 22;
            // 
            // Reservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(658, 623);
            this.Controls.Add(this.ListadoEventosDis);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btonMostrarMapaInt);
            this.Controls.Add(this.btonRegresar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Reservar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservas teatro U de M";
            this.Load += new System.EventHandler(this.Reservar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btonRegresar;
        private System.Windows.Forms.Button btonMostrarMapaInt;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox ListadoEventosDis;
    }
}