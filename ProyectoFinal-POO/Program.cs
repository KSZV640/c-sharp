 using System;

namespace Pos
{
    class Program
    {
        static void Main(string[] args)
        {
             string opcion = "";
            DatosdePrueba pos = new DatosdePrueba();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=========================================================================");
                Console.WriteLine("                                Sistema de POS                           ");
                Console.WriteLine("                                Boutique Kallys                          ");
                Console.WriteLine("=========================================================================");
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("");
                Console.WriteLine("1 - Listado de Usuarios");
                Console.WriteLine("2 - Listado de Productos");
                Console.WriteLine("3 - Listado de Clientes");
                Console.WriteLine("4 - Ingreso de venta");
                Console.WriteLine("5 - Reporte de ventas");
                Console.WriteLine("");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": 
                        pos.ListarUsuario();
                        break;
                    
                    case "2": 
                        pos.ListarProductos();
                        break;
                    
                    case "3": 
                        pos.ListarClientes();
                        break;
                    
                    case "4": 
                        pos.CrearVenta();
                        break;

                    case "5": 
                        pos.ListarVentas();
                        break;
                                
                    default:
                    break;
                }

                if (opcion == "0") {
                    break;
                }
            }            
        }
    }
}
