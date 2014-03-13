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
    public partial class ProgramacionEventos : Form
    {

        ConexionBD conexion = new ConexionBD();

        public ProgramacionEventos()
        {
            InitializeComponent();
        }

        private void btonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProgramacionEventos_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Eventos";
            SqlDataAdapter da = new SqlDataAdapter(sql,conexion.obtenerConexion());
            DataTable dt = new DataTable();
            conexion.obtenerConexion().Open();
            da.Fill(dt);
            conexion.obtenerConexion().Close();
            if (dt.Rows.Count > 0)
            {
                this.ListadoEventosClasificado.Items.Insert(0,"Todos");
                foreach (DataRow dr in dt.Rows)
                {
                    this.ListadoEventosClasificado.Items.Add(dr["nombre"]);
                }
                this.EventosDisponibles.DataSource = dt;
            }
        }

        private void pVerHoy_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Eventos WHERE fecha='"+DateTime.Now+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conexion.obtenerConexion());
            DataTable dt = new DataTable();
            conexion.obtenerConexion().Open();
            da.Fill(dt);
            conexion.obtenerConexion().Close();
            if (dt.Rows.Count > 0)
            {
                this.ListadoEventosClasificado.Items.Clear();                
                foreach (DataRow dr in dt.Rows)
                {
                    this.ListadoEventosClasificado.Items.Add(dr["nombre"]);
                }
                this.ListadoEventosClasificado.Items.Insert(0, "Todos");
                this.EventosDisponibles.DataSource = dt;
            }
        }

        private void ListadoEventosClasificado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            if (this.ListadoEventosClasificado.SelectedItem.ToString() != "Todos")
            {
                sql = "SELECT * FROM Eventos WHERE nombre='" + this.ListadoEventosClasificado.SelectedItem.ToString() + "'";
                
            }
            else
            {
                sql = "SELECT * FROM Eventos ";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, conexion.obtenerConexion());
            DataTable dt = new DataTable();
            conexion.obtenerConexion().Open();
            da.Fill(dt);
            conexion.obtenerConexion().Close();
            this.EventosDisponibles.DataSource = dt;
        }
    }
}
