using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdmProductos
    {
        public static List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

           


            return lista;
        }

        public static List<Producto> Listar(Categoria categoria)
        {
            List<Producto> lista = new List<Producto>();
            return lista;
        }

        public static List<Producto> Listar(Categoria categoria, Categoria subcategoria)
        {
            List<Producto> lista = new List<Producto>();
            return lista;
        }

        public static Producto Listar(string nombre)
        {
            Producto producto = new Producto();
            return producto;
        }

        public static void Agregar (Producto producto)
        {
          
        }

        public static void Modificar(Producto producto)
        {

        }

        public static void Eliminar (Producto producto)
        {

        }



    }
}
