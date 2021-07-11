using System;

namespace holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
 
            Console.Clear();
            
            Console.Write("Ingrese su nombre: ");
            
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
        }
    }
}
