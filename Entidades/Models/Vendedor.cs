using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Vendedor: Persona
    {
        public Vendedor (string nombre, string apellido, string dNI, string email, string telefono, string direccion): base (nombre, apellido, email, telefono, direccion)
        {
          
            DNI = dNI;
            
        }

     
        public string DNI { get; set; }
      
    }
}

