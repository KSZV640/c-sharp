public class Alumno: Persona
{
    public string NoCarnet { get; set; }

    public Alumno(int id, string nombre, string noCarnet)
    {
        Id = id;
        Nombre = nombre;
        NoCarnet = noCarnet;
    }
    
}