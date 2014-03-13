using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeatroUdeM
{
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
        }

        string usuario;
        string id;

        public Eventos(string id, string usuario)
        {
            InitializeComponent();
            this.id = id;
            this.usuario = usuario;
        }

        private void btonReservar_Click(object sender, EventArgs e)
        {
            Reservar nueva = new Reservar(id,usuario);
            this.Visible = false;
            nueva.ShowDialog();
            this.Visible = true;            
        }

        private void btonVisualizarPro_Click(object sender, EventArgs e)
        {
            ProgramacionEventos programacion = new ProgramacionEventos();
            this.Visible = false;
            programacion.ShowDialog();
            this.Visible = true;

        }

        private void btonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonVerificarOcupacion_Click(object sender, EventArgs e)
        {
            Mis_Reservas misReservas = new Mis_Reservas(usuario);
            this.Visible = false;
            misReservas.ShowDialog(this);
            this.Visible = true;
        }
    }
}
