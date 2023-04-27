using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public bool Admin { get { return admin; } }
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

        public static int InsertarEmpleado(Empleado emp)
        {
            int retorno;
            string consulta = "INSERT INTO empleados (nif,nombre,apellido,direccion,admin,clave) " +
                              "VALUES (@Nif, @Nombre,@Apellido,@Direccion,@Admin, @Clave)";
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("Nif", emp.nif);
            comando.Parameters.AddWithValue("Nombre", emp.nombre);
            comando.Parameters.AddWithValue("Apellido", emp.apellido);
            comando.Parameters.AddWithValue("Admin", emp.admin);
            comando.Parameters.AddWithValue("Clave", emp.clave);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Empleado> ListarEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();
            string consulta = "SELECT * FROM empleados";
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Empleado emp = new Empleado(reader.GetString("nif"), reader.GetString("nombre"), reader.GetString("apellido"), reader.GetBoolean("admin"), reader.GetString("clave"));
                lista.Add(emp);
            }
            reader.Close();
            return lista;
        }

        public static int FicharEntrada(string nif, string hora, DateTime dia)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO fichajes (Empleado_nif, dia, HoraEntrada) VALUES ('{0}', '{1}', '{2}')", nif, dia.ToString("yyyy-MM-dd"), hora);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int FicharSalida(string nif, string hora, DateTime dia)
        {
            int retorno;
            string consulta = String.Format("UPDATE fichajes SET HoraSalida = '{0}', finalizado = true WHERE Empleado_nif = '{1}' AND dia = '{2}'", hora, nif, dia.ToString("yyyy-MM-dd"));

            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static bool comprobarEntrada(string nif) //Comprueba si el empleado ya ha fichado entrada
        {
            string consulta = String.Format("SELECT * FROM fichajes WHERE Empleado_nif = '{0}' AND dia = '{1}'", nif, DateTime.Now.ToString("yyyy-MM-dd"));
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

        public static bool comprobarSalida(string nif) //Comprueba si el empleado ya ha fichado salida
        {
            string consulta = String.Format("SELECT * FROM fichajes WHERE Empleado_nif = '{0}' AND dia = '{1}' AND HoraSalida IS NOT NULL", nif, DateTime.Now.ToString("yyyy-MM-dd"));
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
    }
}
