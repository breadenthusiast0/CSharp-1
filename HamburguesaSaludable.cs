public class HamburguesaSaludable : Hamburguesa
{
    public HamburguesaSaludable(string tipoPan, string tipoCarne, decimal precioBase) : base(tipoPan, tipoCarne, precioBase)
    {
    }

    public override void MostrarPrecio()
    {
        Console.WriteLine("Hamburguesa Saludable:");
        base.MostrarPrecio();
    }
}
