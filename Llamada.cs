class Llamada
{
    public int origen;
    public int destino;
    public int duracion;

    public Llamada(int Origen, int Destino, int Duracion)
    {
        origen = Origen;
        destino = Destino;
        duracion = Duracion;
    }
    public double factura;
    public void Facturacion()
    {
        if (origen == destino)
        {
            factura = duracion * 0.15;
        }

        if (origen != destino)
        {
            switch(origen)
            {
                case 1:
                    factura = duracion * 0.20;
                    break;
                case 2:
                    factura = duracion * 0.25;
                    break;
                case 3:
                    factura = duracion * 0.30;
                    break;
            }
        }
    }
}