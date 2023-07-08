using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Raza
    {
        #region Propiedades

        private int cod;
        public int Cod { get => cod; set => cod = value; }

        private string nombre;
        public string Nombre { get => nombre; set => nombre = value; }

        private Especie especieRaza;
        public Especie EspecieRaza { get => especieRaza; set => especieRaza = value;}

        #endregion
    }
}
