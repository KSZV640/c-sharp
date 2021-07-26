using System;

namespace AnimalesPilaresdePOO
{
    class Loro:Aves

    {
        public string Comida { get; set; }
        public void Hablar()
        {
            comunicacion();
        }

        private void comunicacion()
        {
                Console.WriteLine("PARTICULARIDAD DEL ANIMAL: Puede Hablar");
        }
    }
}