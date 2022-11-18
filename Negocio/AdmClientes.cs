using Entidades.Models;
using System.Collections.Generic;

namespace Negocio
{
    public static class AdmClientes
    {
        public static List<ClienteIndividuo> ListarClienteIndviduo() {
            List<ClienteIndividuo> lista = new List<ClienteIndividuo>();
            return lista;
        }
        public static ClienteIndividuo ListarClienteIndviduo(string cuit) {

            ClienteIndividuo cliente = new ClienteIndividuo();
            return cliente;


        }


        public static List<Empresa> ListarClienteEmpresa() {
            List <Empresa> clientes = new List<Empresa>();
            return clientes;
        }
        public static Empresa ListarClienteEmpresa(string cuit)
        {
            Empresa cliente = new Empresa();
            return cliente;
        }


        public static void Agregar(ClienteIndividuo cliente)
        {

        }
        public static void Modificar(ClienteIndividuo cliente)
        {

        }
        public static void Eliminar(ClienteIndividuo cliente)
        {

        }

        public static void Agregar(Empresa cliente)
        {

        }
        public static void Modificar(Empresa cliente)
        {

        }
        public static void Eliminar(Empresa cliente)
        {

        }



    }
}