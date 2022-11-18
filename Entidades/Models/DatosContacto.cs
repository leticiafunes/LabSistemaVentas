using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class DatosContacto
    {
        public DatosContacto(string email, string direccion, string telefono) {
            Email = email;
            Direccion = direccion;
            Telefono = telefono;

        }
        public string Email
        {
            get { return Email; }
            set
            {
                if ((value.Trim().Length < 7) || (value.Trim().Length > 50) || value == null)
                {
                    throw new Exception("Mail con valor inválido");

                }
                Email = value;
            }
        }
        public string Direccion
        {
            get { return Direccion; }
            set
            {
                if ((value.Trim().Length < 15) || (value.Trim().Length > 100)|| value == null)
                {
                    throw new Exception("Direccion con valor inválido");

                }
                Direccion = value;
            }
        }

        public string Telefono
        {
            get { return Telefono; }
            set
            {
                if ((value.Trim().Length < 15) || (value.Trim().Length > 15))
                {
                    throw new Exception("Teléfono con valor inválido");

                }
                Telefono = value;
            }
        }

        public Empresa Empresa;
    }
}
