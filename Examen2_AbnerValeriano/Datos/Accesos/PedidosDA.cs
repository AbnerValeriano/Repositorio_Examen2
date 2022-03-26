using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class PedidosDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=Examen2_AbneValeriano; Uid=root; Pwd=Terminator_9865;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public int InsertarPedidos(Pedidos pedidos)
        {
            int idPedido = 0;
            try
            {
                string sql = "INSERT INTO Pedidos (Identidad, Nombre, Codigo, Cantidad, Descripcion, Fecha) VALUES (@Identidad, @Nombre, @Codigo, @Cantidad, @Descripcion, @Fecha); ";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Identidad", pedidos.Identidad);
                cmd.Parameters.AddWithValue("@Nombre", pedidos.Nombre);
                cmd.Parameters.AddWithValue("@Codigo", pedidos.Codigo);
                cmd.Parameters.AddWithValue("@Cantidad", pedidos.Cantidad);
                cmd.Parameters.AddWithValue("@Descripcion", pedidos.Descripcion);
                cmd.Parameters.AddWithValue("@Fecha", pedidos.Fecha);
                idPedido = Convert.ToInt32(cmd.ExecuteScalar());


                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return idPedido;
        }
        public DataTable ListarPedidos()
        {
            DataTable lista = new DataTable();

            try
            {
                string sql = "SELECT * FROM Pedidos;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                lista.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return lista;
        }
    }
}
