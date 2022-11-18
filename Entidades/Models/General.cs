using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Funcionalidades
    {

        public string ImprimirPropiedades () {
            string propiedades = "";
            Object objeto = this;

            PropertyInfo[] properties = typeof(Object).GetProperties();
            foreach (PropertyInfo p in properties)
            {
                //Console.writeline("Propiedad: " + p.Name);
                //Console.writeline("Valor: " + property.GetValue(obj));
            }

            return "";
        }
    }
}
