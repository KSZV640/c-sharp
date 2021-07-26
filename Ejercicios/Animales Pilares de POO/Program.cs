using System;

namespace AnimalesPilaresdePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Mamifero m1 = new Mamifero();
            m1.idAnimal = 1;
            m1.TipoAnimal = "Perro";
            Perro p1 = new Perro("Firulais", 4, "Es Grande");


            Console.WriteLine("---------------***Animales Mamiferos***-------------");
            Console.WriteLine("Tipo de Animal: " + m1.TipoAnimal);
            Console.WriteLine("Nombre: " + p1.Nombre );
            Console.WriteLine("Numero de Patas: " + p1.NPatas);
            Console.WriteLine("El Animal es Domestico? :" + p1.ESdomestico);
            p1.ladrar();
            Console.WriteLine("");
            Console.WriteLine("");

            Mamifero m2 = new Mamifero();
            m2.idAnimal = 2;
            m2.TipoAnimal = "Gato";
            Gato g1 = new Gato("Michi", 4, "Es Pequeño", "Es Gordito");

            Console.WriteLine("Tipo de Animal: " + m2.TipoAnimal);
            Console.WriteLine("Nombre: " + g1.Nombre );
            Console.WriteLine("Numero de Patas: " + g1.NPatas);
            Console.WriteLine("Peso del Animal: " + g1.Peso);
            Console.WriteLine("El Animal es Domestico? :  " + g1.domestico);
            g1.Maullar();
            Console.WriteLine("********************************************");


            Aves a1 = new Aves();
            a1.idAnimal = 1;
            a1.TipoAnimal = "Ave";
            Aguila ag1 = new Aguila();
            ag1.NombreAve = "Aguila";
            ag1.ColorPlumaje = "Blanco y Negro";
            ag1.Habitat = "Montañas";
            ag1.tipoAguila = "Águila Calva";

            Console.WriteLine("-------------------**AVES**------------------------");
            Console.WriteLine("Tipo de Animal: " + a1.TipoAnimal);
            Console.WriteLine("Nombre: " + ag1.NombreAve );
            Console.WriteLine("Color del Plumaje:  " + ag1.ColorPlumaje);
            Console.WriteLine("El Hábitat del Animal es:  " + ag1.Habitat);
            ag1.VolarAlto();
            ag1.Tamano();
            Console.WriteLine("");
            Console.WriteLine("");

            Aves a2 = new Aves();
            a2.idAnimal = 2;
            a2.TipoAnimal = "Ave";
            Loro L1 = new Loro();
            L1.NombreAve = "Loro";
            L1.ColorPlumaje = "Verde";
            L1.Habitat = "Selva ";
            L1.Comida= "Semillas";

            Console.WriteLine("Tipo de Animal: " + a2.TipoAnimal);
            Console.WriteLine("Nombre: " + L1.NombreAve );
            Console.WriteLine("Color del Plumaje:  " + L1.ColorPlumaje);
            Console.WriteLine("El Hábitat del Animal es:  " + L1.Habitat);
            Console.WriteLine("Se alimenta de: " + L1.Comida);
            L1.Volar();
            L1.Tamano();
            Console.WriteLine("*******************************************");

            Peces p = new Peces();
            p.idAnimal = 1;
            p.TipoAnimal = "Acuatico";
            PezGlobo gl1 = new PezGlobo();
            gl1.NombrePez = "Pez Globo";
            gl1.Color = "Amarillo y verdoso .";
            gl1.NumeroAletas = 2;
            gl1.Alimentacion = "Caracoles, insectos, larvas ";
            

            Console.WriteLine("-------------------**ACUATICOS**------------------------");
            Console.WriteLine("Tipo de Animal: " + p.TipoAnimal);
            Console.WriteLine("Nombre: " + gl1.NombrePez );
            Console.WriteLine("Color del Pez:  " + gl1.Color);
            Console.WriteLine("Numero de Aletas:  " + gl1.NumeroAletas);
            Console.WriteLine("Se Alimenta de: " + gl1.Alimentacion);
            gl1.Nadar();
            gl1.caracteristica();

        }
    }
}
