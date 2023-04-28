using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EjemploFechasHoras
{
    class Fichaje
    {
        private String nif;
        private DateTime dia;
        private DateTime horaEntrada;
        private DateTime horaSalida;
        private bool finalizado;  // False (no finalizado) - True (finalizado)
        private float tiempoTotal;

        public String Nif { get { return nif; } set { nif = value; } }
        public DateTime Dia { get { return dia; } set { dia = value; } }
        public DateTime HEntrada { get { return horaEntrada; } set { horaEntrada = value; } }
        public DateTime HSalida { get { return horaSalida; } set { horaSalida = value; } }
        public bool Finalizado { get { return finalizado; } set { finalizado = value; } }
        public float TiempoTotal { get { return tiempoTotal; } set { tiempoTotal = value; } }

        public Fichaje(String dni)
        {
            nif = dni;
            HSalida = DateTime.MinValue;  // Valor mínimo posible -no admite NULL-
            finalizado = false;  // Cuando se crea el fichaje está abierto
        }

        public static string LEmpleados()
        {
            string mensaje = "Empleados actualmente activos:";
            string consulta = "SELECT * FROM empleados e INNER JOIN fichajes f ON f.Empleado_nif = e.nif WHERE f.finalizado = false";
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                mensaje += "\n" + reader.GetString("nif") + " - " + reader.GetString("nombre") + " " + reader.GetString("apellido");
            }
            reader.Close();
            return mensaje;
        }
        //public static List<Fichaje> ListadoFichajes()
        //{
        //    List<Fichaje> lista = new List<Fichaje>();
        //    String consulta = "SELECT * FROM fichajes";
        //    MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
        //    MySqlDataReader reader = comando.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Fichaje f = new Fichaje(reader.GetString("Empleado_nif"));
        //        f.Dia = reader.GetDateTime("dia");
        //        f.HEntrada = DateTime.Parse(reader.GetString("horaEntrada"));
        //        f.HSalida = DateTime.Parse(reader.GetString("horaSalida"));
        //        f.Finalizado = reader.GetBoolean("finalizado");
        //        f.TiempoTotal = reader.GetFloat("tiempoTotal");
        //        lista.Add(f);
        //    }
        //    reader.Close();
        //    return lista;
        //}

        public static DataTable listarFichajes()
        {
            string consulta = "SELECT * FROM fichajes";
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static List<Fichaje> Permanencia(string dni, DateTime d1, DateTime d2)
        {
            List<Fichaje> lista = new List<Fichaje>();
            String consulta = "SELECT * FROM fichajes WHERE Empleado_nif=@Nif AND dia BETWEEN @D1 AND @D2";
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            comando.Parameters.AddWithValue("Nif", dni);
            comando.Parameters.AddWithValue("D1", d1.ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("D2", d2.ToString("yyyy-MM-dd"));
            ConBD.CerrarConexion();
            ConBD.AbrirConexion();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Fichaje f = new Fichaje(reader.GetString("Empleado_nif"));
                f.Dia = reader.GetDateTime("dia");
                f.HEntrada = DateTime.Parse(reader.GetString("horaEntrada"));
                f.HSalida = DateTime.Parse(reader.GetString("horaSalida"));
                f.Finalizado = reader.GetBoolean("finalizado");
                f.TiempoTotal = reader.GetFloat("tiempoTotal");
                lista.Add(f);
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
    }
}
