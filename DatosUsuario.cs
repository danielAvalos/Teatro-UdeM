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
    public partial class DatosUsuario : Form
    {
        string silla;
        ConexionBD conexion = new ConexionBD();
        string nombreEvento;
        double precioTotal;
        double precioDescuentoPosicion;

        public DatosUsuario(string silla,string evento,Double precioTotal,double precioDescuento)
        {
            InitializeComponent();
            this.silla = silla;
            this.nombreEvento = evento;
            this.precioTotal = precioTotal;
            this.precioDescuentoPosicion = precioDescuento;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void DatosUsuario_Load(object sender, EventArgs e)
        {
            this.txtSilla.Text = silla;
            this.txtEvento.Text = nombreEvento;
            this.txtPrecio.Text = precioTotal.ToString();
            this.txtPrecioFinal.Text = precioDescuentoPosicion.ToString();
        }

        private void Cambio_Tipo(object sender, EventArgs e)
        {
            double temp = precioDescuentoPosicion;
            switch(this.tipoUsuario.SelectedItem.ToString())
            {
                case "estudiante":
                    temp -= (temp*0.10);
                    this.txtPrecioFinal.Text = temp.ToString();
                    break;
                case "empleado":
                    temp -= (temp*0.10);
                    this.txtPrecioFinal.Text = temp.ToString();
                    break;   
                case "otros":
                    this.txtPrecioFinal.Text = temp.ToString();
                    break;
            }
        }

        private void btonReservar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != "" && this.txtPassword.Text != "" && this.tipoUsuario.SelectedItem != null)
            {
                crearUsuario();
                string sql = "INSERT INTO Reservas VALUES('" + this.txtNombre.Text.Trim() + "','" + this.nombreEvento.ToString().Trim() + "','" + silla.Trim() + "','" + txtPrecioFinal.Text + "')";
                SqlCommand command = new SqlCommand(sql, conexion.obtenerConexion());
                conexion.obtenerConexion().Open();
                int filas = command.ExecuteNonQuery();
                conexion.obtenerConexion().Close();
                if (filas > 0)
                {
                    MessageBox.Show(this, "La reserva a sido Exitosa", "Mensaje");
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show(this, "Debes llenar todos los campos", "Espera");
            }
        }

        public bool crearUsuario()
        {
            string sql = "INSERT INTO Usuarios VALUES('"+this.txtNombre.Text.Trim()+"','"+this.tipoUsuario.SelectedItem.ToString()+"','"+this.txtPassword.Text.Trim()+"')";
            SqlCommand command = new SqlCommand(sql,conexion.obtenerConexion());
            conexion.obtenerConexion().Open();
            int filas = command.ExecuteNonQuery();
            conexion.obtenerConexion().Close();
            if (filas > 0)
            {
                MessageBox.Show(this, "Se ha creado un nuevo usuario con exito! \n Nombre:" + this.txtNombre.Text + " password: " + this.txtPassword.Text, "Mensaje");
                return true;
            }
            else
            {
                MessageBox.Show(this, "No se pudo crear el nuevo usuario", "Mensaje");
                return false;
            }
        }
    }
}
