namespace TeatroUdeM
{
    partial class Mis_Reservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mis_Reservas));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btonRegresar = new System.Windows.Forms.Button();
            this.ListaReservasUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaReservasUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(1, -19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 155);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Italic);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(195, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(144, 112);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Mis reservas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btonRegresar
            // 
            this.btonRegresar.BackColor = System.Drawing.Color.DarkRed;
            this.btonRegresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btonRegresar.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold);
            this.btonRegresar.ForeColor = System.Drawing.Color.White;
            this.btonRegresar.Location = new System.Drawing.Point(0, 341);
            this.btonRegresar.Name = "btonRegresar";
            this.btonRegresar.Size = new System.Drawing.Size(375, 46);
            this.btonRegresar.TabIndex = 33;
            this.btonRegresar.Text = "Regresar";
            this.btonRegresar.UseVisualStyleBackColor = false;
            this.btonRegresar.Click += new System.EventHandler(this.btonRegresar_Click);
            // 
            // ListaReservasUsuario
            // 
            this.ListaReservasUsuario.BackgroundColor = System.Drawing.Color.White;
            this.ListaReservasUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaReservasUsuario.Location = new System.Drawing.Point(12, 166);
            this.ListaReservasUsuario.Name = "ListaReservasUsuario";
            this.ListaReservasUsuario.Size = new System.Drawing.Size(351, 142);
            this.ListaReservasUsuario.TabIndex = 34;
            // 
            // Mis_Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(375, 387);
            this.Controls.Add(this.ListaReservasUsuario);
            this.Controls.Add(this.btonRegresar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mis_Reservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Mis_Reservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaReservasUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btonRegresar;
        private System.Windows.Forms.DataGridView ListaReservasUsuario;
    }
}