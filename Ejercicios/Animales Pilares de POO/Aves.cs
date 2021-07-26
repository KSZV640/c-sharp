using System;
namespace AnimalesPilaresdePOO
{
     class Aves: Animal
    {

        public string NombreAve { get; set; }

        public string ColorPlumaje { get; set; }

        public string Habitat { get; set; }
        
        public void Volar()
        {
            Console.WriteLine("PUEDE VOLAR");
        }

        public void Tamano()
        {
            if (NombreAve == "Aguila" )
            {
                Avegrande();
            }
            else
            {
                Avepequena();
            }
        }

        private void Avegrande()
        {
            Console.WriteLine("El Ave es grande");
        }

        private void Avepequena()
        {
            Console.WriteLine("El Ave es pequeña");
        }
    }
}