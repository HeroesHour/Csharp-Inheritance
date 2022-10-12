using System;

namespace _2_Inheritance
{
    class Dier // Basisvorm (parent)
    {
        public virtual void MaakGeluid()
        {
            Console.WriteLine("Random Dierengeluid\n");
        }
    }


    class Hond : Dier // De hond is een dier (child)
    {
        public override void MaakGeluid()
        {
            //base.MaakGeluid();
            Console.WriteLine("Woof Woof\n");
        }
    }
    class Kat : Dier // De kat is een dier (child)
    {
        public override void MaakGeluid()
        {
            //base.MaakGeluid();
            Console.WriteLine("Meow\n");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Objecten aanmaken
            Dier eenDier = new Dier();
            Hond hondje = new Hond();
            Kat katje = new Kat();

            eenDier.MaakGeluid(); // Onbekend dier
            hondje.MaakGeluid(); // Hond
            katje.MaakGeluid(); // Kat

            // Merk op dat ze allemaal dezelfde functienamen hebben.
            //Indien ik de 'base' gebruikt had, dan zouden de Honden en Katten ook "Random dierengeluid" zeggen.

            Console.ReadLine();
        }
    }
}
