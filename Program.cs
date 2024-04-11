class Calculadora
{
    private List<string> historial = new List<string>();

    static void Main()
    {
        Calculadora calculadora = new Calculadora();

        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Raíz Cuadrada");
            Console.WriteLine("6. Potencia");
            Console.WriteLine("7. Ver Historial");
            Console.WriteLine("8. Salir");

            Console.Write("Ingrese su opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    calculadora.Suma();
                    break;
                case 2:
                    calculadora.Resta();
                    break;
                case 3:
                    calculadora.Multiplicacion();
                    break;
                case 4:
                    calculadora.Division();
                    break;
                case 5:
                    calculadora.RaizCuadrada();
                    break;
                case 6:
                    calculadora.Potencia();
                    break;
                case 7:
                    calculadora.MostrarHistorial();
                    break;
                case 8:
                    Console.WriteLine("Saliendo de la calculadora. ¡Hasta luego!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, intente nuevamente.");
                    break;
            }
        }
    }

    public void Suma()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num1 + num2;
        Console.WriteLine($"Resultado: {resultado}");

        string operacion = $"{num1} + {num2} = {resultado}";
        historial.Add(operacion);
    }

    public void Resta()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num1 - num2;
        Console.WriteLine($"Resultado: {resultado}");

        string operacion = $"{num1} - {num2} = {resultado}";
        historial.Add(operacion);
    }

    public void Multiplicacion()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num1 * num2;
        Console.WriteLine($"Resultado: {resultado}");

        string operacion = $"{num1} * {num2} = {resultado}";
        historial.Add(operacion);
    }

    public void Division()
    {
        Console.Write("Ingrese el dividendo: ");
        double dividendo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el divisor: ");
        double divisor = Convert.ToDouble(Console.ReadLine());

        if (divisor == 0)
        {
            Console.WriteLine("Error: División por cero.");
        }
        else
        {
            double resultado = dividendo / divisor;
            Console.WriteLine($"Resultado: {resultado}");

            string operacion = $"{dividendo} / {divisor} = {resultado}";
            historial.Add(operacion);
        }
    }

    public void RaizCuadrada()
    {
        Console.Write("Ingrese un número: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo.");
        }
        else
        {
            double resultado = Math.Sqrt(numero);
            Console.WriteLine($"Raíz cuadrada: {resultado}");

            string operacion = $"sqrt({numero}) = {resultado}";
            historial.Add(operacion);
        }
    }

    public void Potencia()
    {
        Console.Write("Ingrese la base: ");
        double baseNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el exponente: ");
        double exponente = Convert.ToDouble(Console.ReadLine());

        double resultado = Math.Pow(baseNum, exponente);
        Console.WriteLine($"Resultado: {resultado}");

        string operacion = $"{baseNum} ^ {exponente} = {resultado}";
        historial.Add(operacion);
    }

    public void MostrarHistorial()
    {
        Console.WriteLine("\nHistorial de Operaciones:");
        foreach (string operacion in historial)
        {
            Console.WriteLine(operacion);
        }
    }
}