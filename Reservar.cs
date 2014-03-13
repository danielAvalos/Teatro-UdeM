using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace TeatroUdeM
{
    public partial class Reservar : Form
    {

        ConexionBD conexion = new ConexionBD();
        string usuario;
        string id;

        public Reservar()
        {
            InitializeComponent();
        }

        public Reservar(string id, string usuario)
        {
            InitializeComponent();
            this.id = id;
            this.usuario = usuario;
        }        

        private void btonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonMostrarMapaInt_Click(object sender, EventArgs e)
        {
            if (this.ListadoEventosDis.SelectedItem != null)
            {
                Sugerencia sugerencia = new Sugerencia();
                this.Visible = false;
                sugerencia.Show();
                Thread.Sleep(4000);                
                sugerencia.cerrar();
                mapaInteractivo mapa = new mapaInteractivo(this.ListadoEventosDis.SelectedItem.ToString(),id,usuario);                
                mapa.ShowDialog(this);
                this.Visible = true;
            }
            else
            {
                MessageBox.Show(this,"Debes seleccionar un evento antes de ver el Mapa","Espera");
            }
        }

        private void Reservar_Load(object sender, EventArgs e)
        {
            string sql = "SELECT id,nombre FROM Eventos";
            SqlDataAdapter da = new SqlDataAdapter(sql,conexion.obtenerConexion());
            DataTable dt = new DataTable();
            conexion.obtenerConexion().Open();
            da.Fill(dt);
            conexion.obtenerConexion().Close();
            foreach (DataRow dr in dt.Rows)
            {
                this.ListadoEventosDis.Items.Add(dr["nombre"]);
            }
        }
    }
}
