using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public  class Categoria
    {
        public  Categoria(string nombre)
        {
            Nombre = nombre;
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

    }
}
