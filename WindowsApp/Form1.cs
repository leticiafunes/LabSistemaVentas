using Entidades.Models;
using System.Reflection;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ClienteIndividuo clienteindividuo;
        Factura factura;
        Producto producto;
        Empresa proveedor;
        Remito remito;
        Vendedor vendedor;
        Empresa clienteEmpresa;


        private void btnGenerarClases_Click(object sender, EventArgs e)
        {
            Persona elContacto;
            Persona elContacto2;
            Empresa proveedor1;
            List<Item> detalle;
            Item item1;
            Item item2;
            Item item3;

            try
            {
          
           
                elContacto = new Persona("Nombre", "Apellido", "lmail@mail.com", "e4342323", "direccón");
                elContacto2 = new Persona("Sr. Jorge", "Rojas", "ardetroya@gmail.com", "e4342323", "direccón");
                proveedor1 = new Empresa("ProveedorNombre", "23-5465456-7", elContacto, "elmail@gmail.com", "45674333443", "direccion");
                detalle = new List<Item>();
                item1 = new Item(2, "notebook", 2000, 4000);
                item2 = new Item(1, "teclado", 5, 5);
                item3 = new Item(10, "mouse", 10, 100);
                detalle.Add(item1);
                detalle.Add(item2);
                detalle.Add(item3);

                clienteindividuo = new ClienteIndividuo("Cliente 1", "Apellido 1", "27-25678987-4", "email1@gmail.com", "2615456789", "calle1");
                factura = new Factura("A", "0", Convert.ToDateTime("22/02/2022"), "Cliente 1", "Direccion 1", "Responsable No Inscripto", "Contado", detalle);
                producto = new Producto("Mercaderia1", "Saldos", 10000, 20, 2100, proveedor1, "Almacen", "Limpeza");
                proveedor = new Empresa("Proveedor1", "23-987654-0", elContacto, "email@gmail.com", "55555555", "calle 879");
                remito = new Remito("0", Convert.ToDateTime("22-6-2022"), "Clliente 1", "direccion 1", "REsponsable inscripto", "Contado", detalle);
                vendedor = new Vendedor("Vendedor 1", "Apellido 1", "23456789", "letyfunes@email.com", "345654444", "direccion 1");
                clienteEmpresa = new Empresa("Cliente1", "26-555654-0", elContacto2, "email@gmail.com", "55555555", "calle 23455");

            }
            catch {
                MessageBox.Show("ingrese valores válidos para las clases");
            
            }
          



        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {


            listDatos.Items.Add("CLIENTE INDIVIDUO");
            PropertyInfo[] properties = typeof(ClienteIndividuo).GetProperties();
          
            foreach (PropertyInfo p in properties)
            {
                listDatos.Items.Add(p.Name + "  -> " + p.GetValue(clienteindividuo));
               
            }

           // listDatos.Items.Add( clienteindividuo.Mostrar("C L I E N T E - I N D I V I D U O"));
           // listDatos.Items.Add( clienteindividuo.Mostrar());



            listDatos.Items.Add("F A C T U R A");
            properties = typeof(Factura).GetProperties();

            foreach (PropertyInfo p in properties)
            {
                listDatos.Items.Add(p.Name + "  -> " + p.GetValue(factura));

            }

            listDatos.Items.Add("P R O D U C T O");
            properties = typeof(Producto).GetProperties();

            foreach (PropertyInfo p in properties)
            {
                listDatos.Items.Add(p.Name + "  -> " + p.GetValue(producto));

            }

            listDatos.Items.Add("P R O V E E D O R");
            properties = typeof(Empresa).GetProperties();

            foreach (PropertyInfo p in properties)
            {
                listDatos.Items.Add(p.Name + "  -> " + p.GetValue(proveedor));

            }

            listDatos.Items.Add("R E M I T O");
            properties = typeof(Remito).GetProperties();

            foreach (PropertyInfo p in properties)
            {
                listDatos.Items.Add(p.Name + "  -> " + p.GetValue(remito));

            }


            listDatos.Items.Add("V E N D E D O R");
            properties = typeof(Vendedor).GetProperties();

            foreach (PropertyInfo p in properties)
            {
                listDatos.Items.Add(p.Name + "  -> " + p.GetValue(vendedor));

            }


            listDatos.Items.Add("C L I E N T E   E M P R E S A");
            properties = typeof(Empresa).GetProperties();

            foreach (PropertyInfo p in properties)
            {
                listDatos.Items.Add(p.Name + "  -> " + p.GetValue(clienteEmpresa));

            }


        }
    }
}