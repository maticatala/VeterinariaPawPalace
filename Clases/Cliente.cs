using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente
    {
        String nroDocumento;
        String nombre;
        String apellido;
        Domicilio domicilio;

        public Cliente(string nroDocumento, string nombre, string apellido, Domicilio domicilio)
        {
            this.nroDocumento = nroDocumento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
        }

        public string NroDocumento { get => nroDocumento; set => nroDocumento = value; }

        public override string ToString()
        {
            return "nroDocumento:"+nroDocumento+" nombre:"+nombre+" apellido:"+apellido+" "+domicilio;
        }


    }
}
