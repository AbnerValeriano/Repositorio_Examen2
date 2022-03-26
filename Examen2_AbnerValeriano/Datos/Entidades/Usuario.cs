using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Usuario
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Clave { get; set; }

        public bool Estado { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigo, string nombre, int clave, bool estado)
        {
            Codigo = codigo;
            Nombre = nombre;
            Clave = clave;
            Estado = estado;
        }
    }
}