using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaCliente.Dto
{
    internal class ClienteDto
    {
        //Atributos

        string nombreCliente;
        string apellidosCliente;
        string dniCliente;
        string fechaNacimientoCliente;
        string emailCliente;
        int tlfCliente;
        string fchAltaCliente;
        string fchBajaCliente;
        

        

        //Getters Y Setters
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
       
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        

        //Constructores

        public ClienteDto()
        {

        }

        public ClienteDto(string nombreCliente, string apellidosCliente, string dniCliente,string fechaNacimientoCliente,  string emailCliente, int tlfCliente,string fchAltaCliente)
        {
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.dniCliente = dniCliente;
            
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            
        }

        //toString

        public string toString()
        {
            string objetoString = this.nombreCliente+" "+this.apellidosCliente+"\n"+this.dniCliente+"\n"
                                  +this.emailCliente+" "+this.tlfCliente;

            return objetoString;
        }
          
    }
}
