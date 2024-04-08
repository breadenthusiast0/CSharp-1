public class Hamburguesa
{
    public string TipoPan { get; }
    public string TipoCarne { get; }
    public decimal PrecioBase { get; set; }

    protected List<string> IngredientesAdicionales = new List<string>();

    public Hamburguesa(string tipoPan, string tipoCarne, decimal precioBase)
    {
        TipoPan = tipoPan;
        TipoCarne = tipoCarne;
        PrecioBase = precioBase;
    }
    public virtual void MostrarPrecio()
    {
        Console.WriteLine($"Tipo de pan: {TipoPan}");
        Console.WriteLine($"Tipo de carne: {TipoCarne}");
        Console.WriteLine($"Precio base: {PrecioBase:C}");

        foreach (var ingrediente in IngredientesAdicionales)
        {
            Console.WriteLine($"Ingrediente adicional: {ingrediente}");
        }
    }

    public virtual void AgregarIngrediente(string ingrediente, decimal precioAdicional)
    {
        if (IngredientesAdicionales.Count < 4)
        {
            IngredientesAdicionales.Add(ingrediente);
            PrecioBase += precioAdicional;
        }
        else
        {
            Console.WriteLine("No se pueden agregar más de 4 ingredientes adicionales.");
        }
    }

    public virtual void MostrarPrecioFinal()
    {
        foreach (var ingrediente in IngredientesAdicionales)
        {
            Console.WriteLine($"Ingrediente adicional: {ingrediente}");
        }
        Console.WriteLine($"Precio final: {PrecioBase:C}");
    }
}