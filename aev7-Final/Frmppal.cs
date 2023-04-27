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
    public partial class Frmppal : Form
    {
        private DateTime tiempo;
        public Frmppal()
        {
            InitializeComponent();
        }

        private void Frmppal_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

            // Cargo en el datagrid todos los fichajes existentes en la BD
            if (ConBD.Conexion != null)
            {
                ConBD.AbrirConexion();
                dgvFichajes.DataSource = Fichaje.ListadoFichajes();
                dgvFichajes.Columns[0].Visible = false;
                txtMessage.Visible = false;
                ConBD.CerrarConexion();

            }
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dd-mm-yyyy");
            tiempo = DateTime.Now;
            
        }

        

        private void btnEntrada_Click_1(object sender, EventArgs e)
        {
            if (!Empleado.CalcLetra(txtNif.Text))
            {
                ptbFlorida.Visible = false;
                txtMessage.Visible = true;
                txtMessage.Text = "El NIF no es correcto";
            }
            else
            {
                try
                {
                    if (ConBD.Conexion != null)
                    {
                        ConBD.AbrirConexion();
                        List<Empleado> lista = new List<Empleado>();
                        lista = Empleado.BuscarEmpleado(txtNif.Text);
                        if (lista.Count > 0 && lista[0].Nif == txtNif.Text)
                        {
                            if (Empleado.comprobarEntrada(txtNif.Text))
                            {
                                txtMessage.Visible = true;
                                ptbFlorida.Visible = false;
                                txtMessage.Text = "Empleado ya entró";
                            }
                            else
                            {
                                Empleado.FicharEntrada(txtNif.Text, lblHora.Text, tiempo);
                                txtMessage.Visible = true;
                                ptbFlorida.Visible = false;
                                txtMessage.Text = "Empleado ha entrado correctamente";
                            }
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

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (!Empleado.CalcLetra(txtNif.Text))
            {
                txtMessage.Visible = true;
                ptbFlorida.Visible = false;
                txtMessage.Text = "El NIF no es correcto";
            }
            else
            {
                try
                {
                    if (ConBD.Conexion != null)
                    {
                        ConBD.AbrirConexion();
                        List<Empleado> lista = new List<Empleado>();
                        lista = Empleado.BuscarEmpleado(txtNif.Text);
                        if (lista.Count > 0 && lista[0].Nif == txtNif.Text)
                        {
                            if (Empleado.comprobarSalida(txtNif.Text))
                            {
                                txtMessage.Visible = true;
                                ptbFlorida.Visible = false;
                                txtMessage.Text = "Empleado ya salió";
                            }
                            else
                            {
                                Empleado.FicharSalida(txtNif.Text, lblHora.Text, tiempo);
                                txtMessage.Visible = true;
                                ptbFlorida.Visible = false;
                                txtMessage.Text = "El empleado ha salido";
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido Salir");
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

        private void btnPresencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    string mensaje = Fichaje.LEmpleados();
                    txtMessage.Visible = true;
                    ptbFlorida.Visible = false;
                    txtMessage.Text = mensaje;

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
}
