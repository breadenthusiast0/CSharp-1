using System.Data.SqlTypes;

class Pasaje
{
    public string ruta;
    public string categoria;
    public int asientosDisponibles;
    public int asientosLlenos;

    public Pasaje(string Ruta, string Categoria, int AsientosDisponibles, int AsientosLlenos)
    {
        ruta = Ruta;
        categoria = Categoria;
        asientosDisponibles = AsientosDisponibles;
        asientosLlenos = AsientosLlenos;
    }
    public double precio;
    public void CalculoDePrecio()
    {
        if (categoria == "Gold")
        {
            if (ruta == "Santo Domingo - Santiago")
            {
                precio = asientosLlenos * 1335;
            }

            if (ruta == "Santo Domingo - San Pedro")
            {
                precio = asientosLlenos * 665;
            }
        }

        if (categoria == "Platinum")
        {
            if (ruta == "Santo Domingo - Santiago")
            {
                precio = asientosLlenos * 2000;
            }

            if (ruta == "Santo Domingo - San Pedro")
            {
                precio = asientosLlenos * 1000;
            }
        }
    }
}
