namespace TeatroUdeM
{
    partial class Eventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eventos));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btonSalir = new System.Windows.Forms.Button();
            this.btonVerificarOcupacion = new System.Windows.Forms.Button();
            this.btonVisualizarPro = new System.Windows.Forms.Button();
            this.btonReservar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eventos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, -19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btonSalir
            // 
            this.btonSalir.BackColor = System.Drawing.Color.DarkRed;
            this.btonSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btonSalir.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btonSalir.ForeColor = System.Drawing.Color.White;
            this.btonSalir.Location = new System.Drawing.Point(0, 351);
            this.btonSalir.Name = "btonSalir";
            this.btonSalir.Size = new System.Drawing.Size(362, 46);
            this.btonSalir.TabIndex = 18;
            this.btonSalir.Text = "Salir";
            this.btonSalir.UseVisualStyleBackColor = false;
            this.btonSalir.Click += new System.EventHandler(this.btonSalir_Click);
            // 
            // btonVerificarOcupacion
            // 
            this.btonVerificarOcupacion.BackColor = System.Drawing.Color.DarkRed;
            this.btonVerificarOcupacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btonVerificarOcupacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btonVerificarOcupacion.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btonVerificarOcupacion.ForeColor = System.Drawing.Color.White;
            this.btonVerificarOcupacion.Location = new System.Drawing.Point(0, 305);
            this.btonVerificarOcupacion.Name = "btonVerificarOcupacion";
            this.btonVerificarOcupacion.Size = new System.Drawing.Size(362, 46);
            this.btonVerificarOcupacion.TabIndex = 19;
            this.btonVerificarOcupacion.Text = "Mis Reservas";
            this.btonVerificarOcupacion.UseVisualStyleBackColor = false;
            this.btonVerificarOcupacion.Click += new System.EventHandler(this.btonVerificarOcupacion_Click);
            // 
            // btonVisualizarPro
            // 
            this.btonVisualizarPro.BackColor = System.Drawing.Color.DarkRed;
            this.btonVisualizarPro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btonVisualizarPro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btonVisualizarPro.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btonVisualizarPro.ForeColor = System.Drawing.Color.White;
            this.btonVisualizarPro.Location = new System.Drawing.Point(0, 262);
            this.btonVisualizarPro.Name = "btonVisualizarPro";
            this.btonVisualizarPro.Size = new System.Drawing.Size(362, 43);
            this.btonVisualizarPro.TabIndex = 20;
            this.btonVisualizarPro.Text = "Visualizar Programacion ";
            this.btonVisualizarPro.UseVisualStyleBackColor = false;
            this.btonVisualizarPro.Click += new System.EventHandler(this.btonVisualizarPro_Click);
            // 
            // btonReservar
            // 
            this.btonReservar.BackColor = System.Drawing.Color.DarkRed;
            this.btonReservar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btonReservar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btonReservar.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btonReservar.ForeColor = System.Drawing.Color.White;
            this.btonReservar.Location = new System.Drawing.Point(0, 216);
            this.btonReservar.Name = "btonReservar";
            this.btonReservar.Size = new System.Drawing.Size(362, 46);
            this.btonReservar.TabIndex = 21;
            this.btonReservar.Text = "Hacer Reserva";
            this.btonReservar.UseVisualStyleBackColor = false;
            this.btonReservar.Click += new System.EventHandler(this.btonReservar_Click);
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 397);
            this.Controls.Add(this.btonReservar);
            this.Controls.Add(this.btonVisualizarPro);
            this.Controls.Add(this.btonVerificarOcupacion);
            this.Controls.Add(this.btonSalir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Eventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btonSalir;
        private System.Windows.Forms.Button btonVerificarOcupacion;
        private System.Windows.Forms.Button btonVisualizarPro;
        private System.Windows.Forms.Button btonReservar;
    }
}