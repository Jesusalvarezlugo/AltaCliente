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
            string nombreCliente;
            string apellidosCliente;
            string dniCliente;
            string fechaNacimientoCliente;
            string emailCliente;
            int tlfCliente;
            string fchAltaCliente;

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
        }


    }
}
