using System;

namespace AnimalesPilaresdePOO
{
     class Peces:Animal
    {

        public string NombrePez { get; set; }
        public int NumeroAletas { get; set; }

        public string Color { get; set; }

        public void Nadar()
        {
            Console.WriteLine("EL ANIMAL PUEDE: Nadar");
        }
    }
}