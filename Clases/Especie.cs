using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Especie
    {
        #region Propiedades

        private int cod;
        public int Cod { get => cod; set => cod = value; }

        private string nombre;
        public string Nombre { get => nombre; set => nombre = value; }

        #endregion
    }
}
