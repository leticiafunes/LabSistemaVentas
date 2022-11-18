using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Factura: DocumentoComercial
    {

        public Factura(string tipo, string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, List<Item> detalle) : base (numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle) 
        {
            Tipo = tipo;
            
        }

        public string Tipo {
            get { return Tipo; }
            set
            {
                if ((value.Trim().Length < 1) || (value.Trim().Length > 1) || value == null)
                {
                    throw new Exception("Tipo con valor inválido");
                }
                Tipo = value.Trim();
            }
        }
      
    }
}
