public class Persona
{
    public string Nombre { get; set; }
    public Persona(string nombre)
    {
        Nombre = nombre;
    }

    public void Info()
    {
        Console.WriteLine("Nombre: " + Nombre + "\n");
    }
}

public class Empleado : Persona
{
    public string Posicion { get; set; }

    public Empleado(string nombre, string posicion) : base(nombre)
    {
        Posicion = posicion;
    }

    public void InfoDeEmpleado()
    {
        Console.WriteLine("Nombre: " + Nombre + " \nPosicion: " + Posicion);
    }
}