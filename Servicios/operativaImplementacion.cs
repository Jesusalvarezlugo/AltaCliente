using AltaCliente.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCliente.Servicios
{
    internal class operativaImplementacion : operativaInterfaz
    {
        public void DarAltaCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto nuevoCliente = ClienteNuevo();

            listaAntigua.Add(nuevoCliente);
        }

        private ClienteDto ClienteNuevo()
        {
           /* 
            * FORMA LARGA
            * string nombreCliente;
            string apellidosCliente;
            string dniCliente;
            string fechaNacimientoCliente;
            string emailCliente;
            int tlfCliente;
            string fchAltaCliente;

            Console.WriteLine("Introduce el id: ");
            Console.WriteLine("Introduce tu nombre: ");
            nombreCliente=Console.ReadLine();

            Console.WriteLine("Introduce tus apellidos: ");
            apellidosCliente=Console.ReadLine();

            Console.WriteLine("Introduce tu DNI: ");
            dniCliente=Console.ReadLine();

            Console.WriteLine("Introduce tu fecha de nacimiento: ");
            fechaNacimientoCliente=Console.ReadLine();

            Console.WriteLine("Introduce tu email: ");
            emailCliente=Console.ReadLine();
            Console.WriteLine("Introduzca su telefono: ");
            tlfCliente = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la fecha de alta: ");
            fchAltaCliente=Console.ReadLine();

            ClienteDto nuevoCliente = new ClienteDto(nombreCliente,apellidosCliente,dniCliente,fechaNacimientoCliente,emailCliente,tlfCliente,fchAltaCliente);
            return nuevoCliente;
           
            */

            //FORMA CORTA
            ClienteDto nuevoCliente=new ClienteDto();

            Console.WriteLine("Introduzca el id: ");
            nuevoCliente.IdCliente=Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca el nombre: ");
            nuevoCliente.NombreCliente = Console.ReadLine();

            Console.WriteLine("Introduzca los apellidos: ");
            nuevoCliente.ApellidosCliente = Console.ReadLine();

            Console.WriteLine("Introduzca la fecha de nacimiento: ");
            nuevoCliente.FechaNacimientoCliente = Console.ReadLine();

            Console.WriteLine("Introduzca el email: ");
            nuevoCliente.EmailCliente = Console.ReadLine();

            Console.WriteLine("Introduzca el telefono: ");
            nuevoCliente.TlfCliente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca la fecha de alta: ");
            nuevoCliente.FchAltaCliente = Console.ReadLine();

            return nuevoCliente;



        }


    }
}
