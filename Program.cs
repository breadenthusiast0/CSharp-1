int llamadasTotales = 0;
double facturaTotal = 0;

while (true)
{
    Console.WriteLine("Para registrar una nueva llamada:");

    Console.WriteLine("indique el codigo de franja para el origen de la llamada (1, 2, 3): ");
    int valor1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("indique el codigo de franja para el destino de la llamada (1, 2, 3): ");
    int valor2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("indique la duracion de la llamada (en segundos): ");
    int valor3 = Convert.ToInt32(Console.ReadLine());

    Llamada llamadaNueva = new Llamada(valor1, valor2, valor3);
    llamadasTotales += 1;

    llamadaNueva.Facturacion();
    facturaTotal += llamadaNueva.factura;
    
    Console.WriteLine("Llamadas totales: " + llamadasTotales);
    Console.WriteLine("Factura total: " + facturaTotal);
}