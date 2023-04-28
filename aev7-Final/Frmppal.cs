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
                
                dgvFichajes.Visible = false;
                txtMessage.Visible = false;
                grpbPermanencias.Visible = false;
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
                            if (Fichaje.comprobarEntrada(txtNif.Text))
                            {
                                txtMessage.Visible = true;
                                ptbFlorida.Visible = false;
                                txtMessage.Text = "Empleado ya entró";
                            }
                            else
                            {
                                Fichaje.FicharEntrada(txtNif.Text, lblHora.Text, tiempo);
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
                            if (Fichaje.comprobarSalida(txtNif.Text))
                            {
                                txtMessage.Visible = true;
                                ptbFlorida.Visible = false;
                                txtMessage.Text = "Empleado ya salió";
                            }
                            else
                            {
                                Fichaje.FicharSalida(txtNif.Text, lblHora.Text, tiempo);
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

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                grpbPermanencias.Visible = true;
                dgvFichajes.Visible = true;
                txtMessage.Visible = false;
                ptbFlorida.Visible = true;
            }
        }

        private void btnVerPermanencia_Click(object sender, EventArgs e)
        {
            // Obtén las fechas seleccionadas por el usuario
            DateTime fechaInicio = dtpFecha1.Value;
            DateTime fechaFin = dtpFecha2.Value;
            string nif = txtNif.Text;

            // Valida que la fecha de inicio sea menor o igual que la fecha de fin
            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio debe ser menor o igual que la fecha de fin");
                return;
            } else
            {
                List<Fichaje> permanencias = Fichaje.Permanencia(nif, fechaInicio, fechaFin);
                dgvFichajes.DataSource = permanencias;
                dgvFichajes.Columns[0].Visible = true;

                ptbFlorida.Visible = false;

            }

        }

        private void btnSalirPermanencias_Click(object sender, EventArgs e)
        {
            grpbPermanencias.Visible = false;
            dgvFichajes.Visible = false;
            ptbFlorida.Visible = true;
        }

        private void btnPermanencia_Click(object sender, EventArgs e)
        {
            grpbPermanencias.Visible = true;
            dgvFichajes.Visible = true;
            ptbFlorida.Visible = false;
        }
    }
}
