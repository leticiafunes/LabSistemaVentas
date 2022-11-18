using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{


    public class ClienteIndividuo : Persona
    {
        public ClienteIndividuo(string nombre, string apellido, string cuit, string email, string telefono, string direccion) : base(nombre, apellido, email, telefono, direccion)
        {

            CUIT = cuit;

        }
        public ClienteIndividuo() : base("", "", "", "", "")
        {

            CUIT = "";

        }


        public string CUIT {
           
                get { return CUIT; }
                set
            {
                    if ((value.Trim().Length < 11) || (value.Trim().Length > 11) || value == null)
                    {
                        throw new Exception("CUIT con valor inválido");

                    }
                    CUIT = value;
                }
            }
        
        public string Mostrar()
        {
            string texto = "";
            texto =  "Cliente Individuo";

            PropertyInfo[] properties = typeof(ClienteIndividuo).GetProperties();

            foreach (PropertyInfo p in properties)
            {
                texto = texto + p.Name + "  -> " + p.GetValue(this) + Environment.NewLine ;

            }
            return texto;



        }

    }
}
