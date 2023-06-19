using Clases;

namespace VeterinariaPawPalace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("12341234", "matias", "perez", new Domicilio("pacheco", 201));
            Console.WriteLine(c1);
            Mascota m1 = new Mascota(1, DateTime.Now, "pepe", Sexo.MACHO, c1);
            Console.WriteLine(m1);
        }
    }
}