using System.Reflection;

namespace Entidades.Models
{
    public class Persona
    {
        public Persona(string nombre, string apellido, string email, string telefono, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            DatosParaContacto.Email = email;
            DatosParaContacto.Telefono = telefono;
            DatosParaContacto.Direccion = direccion;
        }

        public string Nombre {
            get { return Nombre; }
            set {
                if ((value.Trim().Length < 1) || (value.Trim().Length > 50) || value == null) 
                        { throw new Exception ("Cadena con valor inválido"); }
                Nombre = value.Trim();
            } }
        public string Apellido
        {
            get { return Apellido; }
            set
            {
                if ((value.Trim().Length < 1) || (value.Trim().Length > 50) || value == null)
                { throw new Exception("Cadena con valor inválido"); }
                Apellido = value.Trim();
            }
        }

        public DatosContacto DatosParaContacto {get; set;}

       

    }
}
