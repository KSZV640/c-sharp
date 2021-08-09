using System;
using System.Collections.Generic;

public class Venta
{
    public int Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public string NumerodeOrden { get; set; }
    public Cliente Cliente { get; set; }
    public Usuario Usuario { get; set; }
    public List<VentaDetalle> ListaVentaDetalle { get; set; }
    public double Total { get; set; }
    public double Subtotal { get; set; }
    public double Impuesto { get; set; }

    public Venta(int codigo, DateTime fecha, string numeroOrden, Cliente cliente, Usuario usuario)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumerodeOrden = numeroOrden;
        Cliente = cliente;
        Usuario = usuario;
        ListaVentaDetalle = new List<VentaDetalle>();
    }

    public void AgregarProducto(Producto producto)
    {
        int nuevoCodigo = ListaVentaDetalle.Count + 1;
        int cantidad = 1;

        VentaDetalle o = new VentaDetalle(nuevoCodigo, 1, producto);
        ListaVentaDetalle.Add(o);

       
        Subtotal += cantidad * producto.Precio;
        Impuesto+= Subtotal * 0.15;
        Total += Subtotal + Impuesto;

    }
}