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
    public partial class Logearse : Form
    {
        public Logearse()
        {
            InitializeComponent();
        }

        ConexionBD conexion = new ConexionBD();

        private void btonLogearse_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != "" && this.txtPassword.Text != "")
            {
                string sql = "SELECT * FROM Usuarios WHERE nombre='" + this.txtNombre.Text + "' AND password='" + this.txtPassword.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql,conexion.obtenerConexion());
                DataTable dt = new DataTable();
                conexion.obtenerConexion().Open();
                da.Fill(dt);
                conexion.obtenerConexion().Close();
                da.Dispose();                                
                if(dt.Rows.Count > 0 && dt.Rows[0]["tipo"].ToString().Trim() == "admon")
                {
                    Administracion nueva = new Administracion();
                    this.Visible = false;
                    nueva.ShowDialog();
                    this.Visible = false;
                    this.txtNombre.Text = "";
                    this.txtPassword.Text = "";
                }
                else if (dt.Rows.Count > 0)
                {
                    Eventos nuevoUsuario = new Eventos(dt.Rows[0]["id"].ToString(), dt.Rows[0]["nombre"].ToString());                    
                    this.Visible = false;
                    nuevoUsuario.ShowDialog();
                    this.Visible = true;
                    this.txtNombre.Text = "";
                    this.txtPassword.Text = "";
                }
                else
                {
                    this.txtNombre.Text = "";
                    this.txtPassword.Text = "";
                    MessageBox.Show(this, "Haz ingresado datos erroneos", "Error!!");
                }
            }
            else
            {
                MessageBox.Show("Los dos campos son Obligatorios","Espera");
            }
        }

        private void btonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
