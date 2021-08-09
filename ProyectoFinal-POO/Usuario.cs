public class Usuario: Persona
{
    public string CodigoUsuario { get; set; }

    public Usuario(int codigo, string nombre, string codigoUsuario)
    {
        Codigo = codigo;
        Nombre = nombre;
        CodigoUsuario = codigoUsuario;
    }
}