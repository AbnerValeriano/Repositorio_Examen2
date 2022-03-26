using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Accesos;
using Datos.Entidades;

namespace Datos.Accesos
{
    public class UsuariosDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=Examen2_AbneValeriano; Uid=root; Pwd=Terminator_9865;";
        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuario Login(string codigo, string clave)
        {
            Usuario user = null;

            try
            {
                string sql = "SELECT * FROM Usuarios WHERE Codigo = @Codigo AND Clave = @Clave;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Clave", clave);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuario();
                    user.Codigo = reader[0].ToString();
                    user.Nombre = reader[1].ToString();
                    user.Clave = Convert.ToInt32(reader[2]);
                    user.Estado = Convert.ToBoolean(reader[3]);


                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return user;
        }
        public DataTable ListarUsuarios()
        {
            DataTable listaUsuariosDT = new DataTable();

            try
            {
                string sql = "SELECT * FROM Usuarios;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listaUsuariosDT.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return listaUsuariosDT;
        }

    }
}

