using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProInmuebles
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            DatosEmpleados date = new DatosEmpleados();
            
            Console.WriteLine("PROVENTAS DE INMUEBLES");
            Console.Write("\n");
            Console.WriteLine(" DATOS DEL VENDEDOR");
            string texto = Console.ReadLine();
            Console.WriteLine(" EMPLEADO" );
            Console.WriteLine($" NOMBRE: {date.nombre} {date.apellido} EDAD: {date.edad} CARGO: {date.cargo}");
            Console.Write("\n");
            Console.WriteLine("INGRESE LOS DATOS DEL CLIENTE ");
            string Cliente = Console.ReadLine();

            DatosCliente datec = new DatosCliente();

            Console.WriteLine("INGRESE EL DUI ");
            datec.Dui = Console.ReadLine();
            Console.WriteLine("INGRESE EL NOMBRE ");
            datec.nombre = Console.ReadLine();
            Console.WriteLine("INGRESE EL APELLIDO ");
            datec.apellido = Console.ReadLine();
            Console.WriteLine("INGRESE EL NUMERO DE TELEFONO ");
            datec.telefono = Console.ReadLine();
            Console.WriteLine("INGRESE LA DIRRECCION ");
            datec.direccion = Console.ReadLine();
            Console.WriteLine("los datos ingresados son:" + datec.Dui  + datec.nombre  + datec.apellido + datec.telefono + datec.direccion);
            string datos = Console.ReadLine();

            TipoContrato contrato = new TipoContrato();

            Console.WriteLine(" CON TIPO DE CONTRATO" + datec.Dui + datec.nombre + contrato.direcionInmu + contrato.caracteristicas + contrato.formaPago);
            string contra = Console.ReadLine();


        }
    }

    public class DatosEmpleados
    {
        public string id;
        public string nombre =" Victor ";
        public string apellido ="Monge \n";
        public int edad = 19 ;
        public string cargo ="Gerente \n";

    }

    public class DatosCliente
    {
        private string dui;
        public string Dui
        {
            get { return dui; }
            set { dui = value; }
        }

        public string nombre;
        public string apellido;
        public string telefono ;
        public string direccion ;
    }

    public class TipoContrato
    {
        public string cliente;
        public string direcionInmu = " Av. Norte, calle las flores,col. las Brisas,chalatenango, Chalatenango \n";
        public string caracteristicas = " Alquiler de casas, departamentos u oficinas \n";
        public string formaPago = " via Bancaria \n";



    }

    public class metodos: DatosCliente
    {
        public void information()
        {


            DatosCliente dateC = new DatosCliente();

            Console.WriteLine("Ingrese los datos del cliente");
            Console.WriteLine("DUI");
            dateC.Dui = Console.ReadLine();
            Console.WriteLine("Nombre");
            dateC.nombre = Console.ReadLine();
            Console.WriteLine("Apellido");
            dateC.apellido = Console.ReadLine();
            Console.WriteLine("Telefono");
            dateC.telefono = Console.ReadLine();
            Console.WriteLine("Direccion");
            dateC.direccion = Console.ReadLine();
            string recoleccionDatosClientes = Console.ReadLine();
        }
    
    }
}
