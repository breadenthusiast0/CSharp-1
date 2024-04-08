public class HamburguesaPremium : Hamburguesa
{
    private const decimal PrecioAdicionalPremium = 5;

    public HamburguesaPremium(string tipoPan, string tipoCarne, decimal precioBase) : base(tipoPan, tipoCarne, precioBase + PrecioAdicionalPremium)
    {
    }

    public override void AgregarIngrediente(string ingrediente, decimal precioAdicional)
    {
        Console.WriteLine("No se pueden agregar ingredientes adicionales a la hamburguesa Premium.");
    }

        public virtual void AgregarExtra(string extra, decimal precioAdicional)
    {
        IngredientesAdicionales.Add(extra);
        PrecioBase += precioAdicional;
    }

    public override void MostrarPrecio()
    {
        Console.WriteLine("Hamburguesa Premium:");
        base.MostrarPrecio();
    }

    public override void MostrarPrecioFinal()
    {
        foreach (var extra in IngredientesAdicionales)
        {
            Console.WriteLine($"Extra adicional: {extra}");
        }
        Console.WriteLine($"Precio final: {PrecioBase:C}");
    }
}