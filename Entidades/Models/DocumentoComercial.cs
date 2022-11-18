using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public abstract class DocumentoComercial
    {
        protected DocumentoComercial(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, List <Item> detalle)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Direccion = direccion;
            CondicionIVA = condicionIVA;
            CondicionVenta = condicionVenta;
            Detalle = detalle;

            foreach (Item item in detalle)
            {
                Total = Total + item.Importe;
            }
                
            }

        public string Numero
        {
            get { return Numero; }
            set
            {
                if ((value.Trim().Length < 13 || (value.Trim().Length > 13) || value == null))
                {
                    throw new Exception("Numero con valor inválido");

                }
                Numero = value;
            }
        }
        public DateTime Fecha { get; set; }
        public string Cliente
        {
            get { return Cliente; }
            set
            {
                if ((value.Trim().Length < 1 || (value.Trim().Length > 100) || value == null))
                {
                    throw new Exception("Cliente con valor inválido");

                }
                Cliente = value;
            }
        }
        public string Direccion {
            get { return Direccion; }
            set
            {
                if ((value.Trim().Length < 15 || (value.Trim().Length > 100) || value == null))
                {
                    throw new Exception("Direccion con valor inválido");

                }
                Direccion = value;
            }
        }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public List <Item>  Detalle { get; set; }
        private decimal Total { get; }
        
        public string Metodo() { return ""; }
       
    }
}
