using System;

namespace AnimalesPilaresdePOO
{
    class Perro:Mamifero
    {
        public bool ESdomestico { get; set; }
      public Perro(string nombre, int nPatas, string tamano)
      {
          Nombre = nombre;
          NPatas = nPatas;
          Tamano = tamano;
          ESdomestico=true;

      }

      public void ladrar()
      {
          Console.WriteLine("EL SONIDO DEL ANIMAL ES:  Gua Gua");
      }

    }
}