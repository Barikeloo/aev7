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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nif = txtNifLogin.Text;
            string clave = txtContra.Text;
            bool admin = Empleado.Admin(nif);
            bool emp = Empleado.Login(nif, clave);
            if (admin)
            {
                if (emp)
                {
                    Mantenimiento mant = new Mantenimiento();
                    mant.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("El usuario o la contraseña es incorrecta.");
                }
            } else
            {
                MessageBox.Show("No eres administrador");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
