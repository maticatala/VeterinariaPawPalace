using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Mascota
    {
        private int nroHistoriaClinica;
        private DateTime fechaNacimiento;
        private string nombre;
        private Sexo sexo;
        private Cliente dueño;

        public Mascota(int nroHistoriaClinica, DateTime fechaNacimiento, string nombre, Sexo sexo, Cliente dueño)
        {
            this.nroHistoriaClinica = nroHistoriaClinica;
            this.fechaNacimiento = fechaNacimiento;
            this.nombre = nombre;
            this.sexo = sexo;
            this.dueño = dueño;
        }

        public override string ToString()
        {
            return "nroHistoriaClinica:"+nroHistoriaClinica+" fechaNacimiento:"+fechaNacimiento+" nombre:"+nombre+" Sexo:"+sexo+" Dueño:"+dueño.NroDocumento;
        }
    }
}
