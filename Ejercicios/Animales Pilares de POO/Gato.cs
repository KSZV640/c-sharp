using System;

namespace AnimalesPilaresdePOO
{
    class Gato:Mamifero
    {
        public string Peso { get; set; }
        public bool domestico { get; set; }

        public Gato(string nombre, int nPatas, string tamano, string peso)
        {
            Nombre = nombre;
            NPatas = nPatas;
            Tamano = tamano;
            Peso = peso;
            domestico = true;
        }
        public void Maullar()
        {
            Console.WriteLine ("EL SONIDO DEL ANIMAL ES:  Miau Miau Miau");
        }
    }
}