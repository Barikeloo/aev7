using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EjemploFechasHoras
{
    internal class Empleado
    {
        string nif;
        string nombre;
        string apellido;
        bool admin;
        string clave;

        public string Nif { get { return nif; } }
        public string Nombre { get { return nombre; } }
        public string Apellido { get { return apellido; } }
        //public bool Admin { get { return admin; } }
        public string Clave { get { return clave; } }


        public Empleado(string nif, string nom, string ape, bool adm, string clave)
        {
            this.nif = nif;
            this.nombre = nom;
            this.apellido = ape;
            this.admin = adm;
            this.clave = clave;

        }

        /// <summary>
        /// Calcular la letra del nif y devuelve si es cierta o no
        /// </summary>
        /// <param name="nif">nif del usuario</param>
        /// <returns>True o False</returns>
        public static bool CalcLetra(string nif)
        {
            if (nif.Length != 9)
            {
                return false;
            }
            string letra = "TRWAGMYFPDXBNJZSQVHLCKE";
            string num = "";

            for (int i = 0; i < nif.Length - 1; i++)
            {
                if (char.IsDigit(nif[i]))
                {
                    num += nif[i];
                }
                else
                {
                    return false;
                }
            }
            char let = letra[int.Parse(num) % 23];

            if (let == nif[8])
            {
                return true;

            }
            else
                return false;

        }

        public static int InsertarEmpleado(string nif, string nombre, string apellido, bool admin, string clave)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO empleados VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", nif, nombre, apellido, admin, clave);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //public static List<Empleado> ListarEmpleados()
        //{
        //    List<Empleado> lista = new List<Empleado>();
        //    string consulta = "SELECT * FROM empleados";
        //    MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
        //    MySqlDataReader reader = comando.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Empleado emp = new Empleado(reader.GetString("nif"), reader.GetString("nombre"), reader.GetString("apellido"), reader.GetBoolean("admin"), reader.GetString("clave"));
        //        lista.Add(emp);
        //    }
        //    reader.Close();
        //    return lista;
        //}

        public static DataTable listarEmpleados()
        {
            string consulta = "SELECT * FROM empleados";
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int borrarEmpleado(string nif)
        {
            int retorno;
            string consulta = String.Format("DELETE FROM empleados WHERE nif = '{0}'", nif);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int restaurarEmpleado(string nif)
        {
            int retorno;
            string consulta = String.Format("UPDATE empleados SET admin = 0 WHERE nif = '{0}'", nif);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Empleado> BuscarEmpleado(string nif)
        {
            List<Empleado> lista = new List<Empleado>();
            string consulta = String.Format("SELECT * FROM empleados WHERE nif = '{0}'", nif);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Empleado emp = new Empleado(reader.GetString("nif"), reader.GetString("nombre"), reader.GetString("apellido"), reader.GetBoolean("administrador"), reader.GetString("clave"));
                lista.Add(emp);
            }
            reader.Close();
            return lista;
        }

        // funcion de login
        public static bool Login(string nif, string clave)
        {
            ConBD.CerrarConexion();
            ConBD.Conexion.Open();
            string consulta = String.Format("SELECT * FROM empleados WHERE nif = '{0}' AND clave = '{1}'", nif, clave);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }

        public static bool Admin(string dni)
        {
            ConBD.CerrarConexion();
            ConBD.Conexion.Open();
            string consulta = String.Format("SELECT * FROM empleados WHERE nif = '{0}' AND administrador = true", dni);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }
    }
}
