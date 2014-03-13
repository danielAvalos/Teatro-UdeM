using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeatroUdeM
{
    public partial class Mis_Reservas : Form
    {
        string usuario;
        ConexionBD conexion = new ConexionBD();
        public Mis_Reservas(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mis_Reservas_Load(object sender, EventArgs e)
        {
            string sql = "SELECT evento,silla,precio FROM Reservas WHERE usuario='" + usuario + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql,conexion.obtenerConexion());
            DataTable dt = new DataTable();
            conexion.obtenerConexion().Open();
            da.Fill(dt);
            conexion.obtenerConexion().Close();
            ListaReservasUsuario.DataSource = dt;
        }
    }
}
