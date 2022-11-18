using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Empresa
    {
        public Empresa(string nombre, string cUIT, Persona contacto, string email, string telefono, string direccion)
        {
            Nombre = nombre;
            CUIT = cUIT;
            Contacto = contacto;
            DatosParaContacto.Email = email;
            DatosParaContacto.Telefono = telefono;
            DatosParaContacto.Direccion = direccion;
        }

        public Empresa()
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
                Nombre = value.Trim();
            }
        }
        public string CUIT { get; set; }
        public Persona Contacto { get; set; }
        public DatosContacto DatosParaContacto { get; set; }
        
    }
}
