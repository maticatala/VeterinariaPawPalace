using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota
    {
        #region Enums
        public enum Sexos
        {
            HEMBRA,
            MACHO

        }

        #endregion

        #region propiedades

        private int nroHistoriaClinica;

        public int NroHistoriaClinica
        {
            get { return nroHistoriaClinica; }
            set { nroHistoriaClinica = value; }
        }


        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private Sexos sexo;

        public Sexos Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private Cliente duenio;

        public Cliente Duenio
        {
            get { return duenio; }
            set { duenio = value; }
        }

        private Raza razaEspecie;

        public Raza RazaEspecie 
        { 
            get { return razaEspecie; }
            set { razaEspecie = value; }
        }

        #endregion

        #region Constructores

        public Mascota(int nroHistoriaClinica, DateTime fechaNacimiento, string nombre, Sexos sexo, Cliente duenio)
        {
            this.nroHistoriaClinica = nroHistoriaClinica;
            this.fechaNacimiento = fechaNacimiento;
            this.nombre = nombre;
            this.sexo = sexo;
            this.duenio = duenio;
        }

        #endregion

        #region Metodos
        public override string ToString()
        {
            return "nroHistoriaClinica:"+nroHistoriaClinica+" fechaNacimiento:"+fechaNacimiento+" nombre:"+nombre+" Sexo:"+sexo+" Dueño:"+duenio.NroDocumento;
        }

        #endregion
    }
}
