using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Producto
    {
        public Producto(string nombre, string descripcion, decimal precioCosto, double margen, double iVA, Empresa proveedor, string categoria, string subCategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCosto = precioCosto;
            Margen = margen;
            IVA = iVA;
            Proveedor = proveedor;
            Categoria = categoria;
            SubCategoria = subCategoria;
        }

        public Producto()
        {
        }

        public string Nombre
        {
            get { return Nombre; }
            set
            {
                if ((value.Trim().Length < 1) || (value.Trim().Length > 50) || value == null)
                {
                    throw new Exception("Nombre con valor inválido");

                }
                Nombre = value;
            }
        }
        public string Descripcion {
            get { return Descripcion; }
            set
            {
                if ( (value.Trim().Length > 500))
                {
                    throw new Exception("Descripcion con valor inválido");

                }
                Descripcion = value;
            }
        }
        public decimal PrecioCosto {
            get { return PrecioCosto; }
            set
            {
                if ( value is > (decimal) 0.1 || value == null)
                {
                    throw new Exception("PrecioCosto con valor inválido");

                }
                PrecioCosto = value;
            }
        }
        public double Margen { get; set; }
        public static double IVA { get; set; }
        public decimal PrecioBruto
        {
            get
            {
                return PrecioCosto + Convert.ToDecimal(this.Margen);
            }
        }
        public decimal PrecioVenta
        {
            get
            {
                return PrecioBruto + Convert.ToDecimal(1 + IVA);
            }
        }

        public Empresa Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }


      



    }
    }
