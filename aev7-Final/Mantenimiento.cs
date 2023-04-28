using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploFechasHoras
{
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        public void btnListarEmpleados_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = Empleado.listarEmpleados();
            dgvFichajes.DataSource = Fichaje.listarFichajes();
        }

        private void btnBorrarEmpleado_Click(object sender, EventArgs e)
        {
            
            string nif = txtNifNuevo.Text; // Obtener el valor del TextBox txtNifNuevo
            

            if (!Empleado.CalcLetra(txtNifNuevo.Text))
            {
                MessageBox.Show("El nif no es correcto.");
            }
            else
            {
                try
                {
                    if (ConBD.Conexion != null)
                    {
                        ConBD.AbrirConexion();
                        List<Empleado> lista = new List<Empleado>();
                        lista = Empleado.BuscarEmpleado(txtNifNuevo.Text);
                        if (lista.Count > 0 && lista[0].Nif == txtNifNuevo.Text)
                        {
                            Empleado.borrarEmpleado(nif);
                            MessageBox.Show(string.Format("Se han borrado al empleado con el NIF {0}", nif));
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido realizar");
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
                finally
                {
                    ConBD.CerrarConexion();
                }
            }
  
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        { 
            string nif = txtNifNuevo.Text; // Obtener el valor del TextBox txtNifNuevo
            string nombre = txtNombreNuevo.Text; // Obtener el valor del TextBox txtNombreNuevo
            string apellido = txtApellidoNuevo.Text; // Obtener el valor del TextBox txtApellidoNuevo
            string clave = txtClaveNuevo.Text; // Obtener el valor del TextBox txtClaveNueva
            bool admin;
            ConBD.AbrirConexion();
            if (chbAdministradorNuevo.Checked)
            {
                MessageBox.Show("El empleado es administrador");
                admin = true;
            }
            else
            {
                MessageBox.Show("El empleado no es administrador");
                admin = false;
            }
            if (!Empleado.CalcLetra(txtNifNuevo.Text))
            {
                MessageBox.Show("El nif no es correcto.");
            }
            else
            {
                try
                {
                    if (ConBD.Conexion != null)
                    {
                        List<Empleado> lista = new List<Empleado>();
                        lista = Empleado.BuscarEmpleado(txtNifNuevo.Text);
                        if (lista.Count > 0 && lista[0].Nif == txtNifNuevo.Text)
                        {
                            MessageBox.Show("El empleado ya existe");
                        }
                        else
                        {
                            Empleado.InsertarEmpleado(nif, nombre, apellido, admin, clave);
                            MessageBox.Show(string.Format("Se han agregado al empleado con el NIF {0}", nif));
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
                finally
                {
                   
                }
            }
            ConBD.CerrarConexion();
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            ConBD.CerrarConexion();
        }
    }
}
