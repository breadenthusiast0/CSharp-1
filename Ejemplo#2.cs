public class Figura1
{
    public virtual void Dibujar()
    {
        Console.WriteLine("Dibujando una figura...");
    }
}

public class Circulo1 : Figura1
{
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un circulo...");
    }
}