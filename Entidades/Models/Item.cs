using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Item
    {
        private const double V = 0.1;

        public Item(int cantidad, string desripcion, int precioUnitario, decimal importe)
        {
            Cantidad = cantidad;
            Desripcion = desripcion;
            PrecioUnitario = precioUnitario;
            Importe = importe;
        }

        public int Cantidad
        {
            get { return Cantidad; }
            set
            {
                if ((value  < 1) || (value > 1) || value == null)
                {
                    throw new Exception("Cantidad con valor inválido");
                }
                Cantidad = value;
            }
        }
        public string Desripcion
        {
            get { return Desripcion; }
            set
            {
                if ((value.Trim().Length < 15 || (value.Trim().Length > 100) || value == null))
                {
                    throw new Exception("Desripcion con valor inválido");

                }
                Desripcion = value;
            }
        }
        public decimal PrecioUnitario
        {
            get { return PrecioUnitario; }
            set
            {
                if (value is > (decimal)0.1 || value == null)
                {
                    throw new Exception("Precio Unitario con valor inválido");

                }
                PrecioUnitario = value;
            }
        }
        public decimal Importe { get; }

    }
}
