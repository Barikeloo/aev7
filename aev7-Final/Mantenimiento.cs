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
            // Aquí puedes procesar los resultados de las funciones borrarEmpleado y BuscarEmpleado según tus necesidades
            // Por ejemplo, puedes mostrar un mensaje que indique cuántos empleados se han borrado
            MessageBox.Show(string.Format("Se han borrado al empleado con el NIF {0}", nif));
        }
    }
}
