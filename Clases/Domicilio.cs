using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Domicilio
    {
        private string calle;
        private int altura;

        public Domicilio(string calle, int altura)
        {
            this.calle = calle;
            this.altura = altura;
        }

        public override string ToString()
        {
            return "calle:"+calle+" altura:"+altura;
        }
    }
}
