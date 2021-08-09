using System;
using System.Collections.Generic;
public class DatosdePrueba
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Usuario> ListadeUsuarios { get; set; }
    public List<Venta> ListadeVentas { get; set; }

    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeUsuarios = new List<Usuario>();
        cargarUsuario();

        ListadeVentas = new List<Venta>();
    }

    private void cargarProductos()
    {
        Producto p1 = new Producto(1, "Camiseta",    250);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2, "Jeans",       550);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3, "Blazer",      700);
        ListadeProductos.Add(p3);
        
        Producto p4 = new Producto(4, "Zapatos",    1000);
        ListadeProductos.Add(p4);
    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1,       "Juana Rios",          "01");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2,       "Paola Lopez",         "02");
        ListadeClientes.Add(c2);
        
        Cliente c3 = new Cliente(3,       "Marlen Cruz",         "03");
        ListadeClientes.Add(c3);
    }

    private void cargarUsuario()
    {
        Usuario u1 = new Usuario(1,     "Jose Ruiz" ,              "01");
        ListadeUsuarios.Add(u1);

        Usuario u2 = new Usuario(2,     "Margarita Perez",          "02");
        ListadeUsuarios.Add(u2);
    }

    public void ListarProductos()
    {
        Console.Clear();
         Console.WriteLine("=====================================================================");
        Console.WriteLine("                      Lista de Productos                              ");
        Console.WriteLine("======================================================================");
        Console.WriteLine("");
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo +   " | "   + producto.Descripcion +    " | "    + producto.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
         Console.WriteLine("=========================================================");
        Console.WriteLine("                 Lista de Clientes                        ");
        Console.WriteLine("==========================================================");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo +   " | "   + cliente.Nombre +   " | "   + cliente.Telefono);
        }

        Console.ReadLine();
    }

    public void ListarUsuario()
    {
        Console.Clear();
         Console.WriteLine("=========================================================");
        Console.WriteLine("                    Lista de Usuarios                     ");
        Console.WriteLine("==========================================================");
        Console.WriteLine("");
        
        foreach (var usuario in ListadeUsuarios)
        {
            Console.WriteLine(usuario.Codigo +    " | "    + usuario.Nombre +   " | "    + usuario.CodigoUsuario);
        }

        Console.ReadLine();
    }

    public void CrearVenta()
    {
        Console.WriteLine("=================================================================");
        Console.WriteLine("                       Ingreso de Ventas                         ");
        Console.WriteLine("=================================================================");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del Usuario: ");
        string CodigoUsuario = Console.ReadLine();

        Usuario usuario = ListadeUsuarios.Find(v => v.Codigo.ToString() == CodigoUsuario);
        if (usuario == null) 
        {
            Console.WriteLine("Usuario no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Usuario: " + usuario.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListadeVentas.Count + 1;

        Venta nuevaventa = new Venta(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, usuario);
        ListadeVentas.Add(nuevaventa);

        while(true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaventa.AgregarProducto(producto);
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }
        Console.WriteLine("");
        Console.WriteLine("=================================================================");
        Console.WriteLine("           SubTotal de la Venta es de: " + nuevaventa.Subtotal   );
        Console.WriteLine("           Impuesto sobre venta (15%): " + nuevaventa.Impuesto   );
        Console.WriteLine("           Total de la venta es de: " + nuevaventa.Total         );
        Console.WriteLine("=================================================================");
        Console.ReadLine();
        
    }

    public void ListarVentas()
    {
        Console.Clear();
        Console.WriteLine("==========================================================");
        Console.WriteLine("                      Reporte de Ventas                   ");
        Console.WriteLine("==========================================================");
        Console.WriteLine("");  
        Console.WriteLine(" Codigo     |     Cliente    |   Usuario    |   Total     ");
        Console.WriteLine("==========================================================");
        Console.WriteLine("");  

        foreach (var venta in ListadeVentas)
        {
            Console.WriteLine(venta.Codigo +   " | "    + venta.Cliente +  " | "   + venta.Total);
            Console.WriteLine(venta.Cliente.Nombre + " | " + venta.Usuario.Nombre);
            
            foreach (var detalle in venta.ListaVentaDetalle)
            {
                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
            }

            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}