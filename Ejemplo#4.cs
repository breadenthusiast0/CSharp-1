abstract class Figura2
{
    public abstract double Area { get; }

    public void ImprimirArea()
    {
        Console.WriteLine("Area: " + Area);
    }
}

class Circulo2 : Figura2
{
    public double Radio { get; set; }

    public Circulo2(double radio)
    {
        Radio = radio;
    }

    public override double Area
    {
        get { return Math.PI * Radio * Radio; }
    }
}