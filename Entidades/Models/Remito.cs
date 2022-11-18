using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{

    public class Remito: DocumentoComercial
    {

        public Remito(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, List<Item> detalle) : base(numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle) { }

    }
}
