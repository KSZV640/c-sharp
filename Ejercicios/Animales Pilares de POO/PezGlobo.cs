using System;

namespace AnimalesPilaresdePOO
{
    class PezGlobo:Peces
    {
        public string Alimentacion { get; set; }
        public void caracteristica()
        {
            inflarse();
        }

        private void inflarse()
        {
            Console.WriteLine("PARTICULARIDAD DEL ANIMAL: Se infla");
        }
    }
}