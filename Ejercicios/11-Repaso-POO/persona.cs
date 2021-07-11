using System;

public abstract class Persona 
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }

    private void EnviarCorreo()
    {
    }

    private void EnviarMensajedeWhatsapp()
    {
    }

    public void EnviarMensaje()
    {
        Console.WriteLine("Mensaje...");
        EnviarCorreo();
        EnviarMensajedeWhatsapp();
    }

    public void EnviarMensaje(string nombre)
    {
        Console.WriteLine("Mensaje para: " + nombre);
        EnviarCorreo();
        EnviarMensajedeWhatsapp();
    }

    public void EnviarMensaje(string de, string para, string mensaje)
    {
        Console.WriteLine("Mensaje de " + de + " para: " + para + ", mensaje:" + mensaje);
        EnviarCorreo();
        EnviarMensajedeWhatsapp();
    }
}
