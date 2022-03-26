using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Pedidos
    {
        public string Identidad { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        public Pedidos()
        {
        }

        public Pedidos(string identidad, string nombre, string codigo, int cantidad, string descripcion, DateTime fecha)
        {
            Identidad = identidad;
            Nombre = nombre;
            Codigo = codigo;
            Cantidad = cantidad;
            Descripcion = descripcion;
            Fecha = fecha;
        }
    }
}
