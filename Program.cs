public class PracticaPOO {
    public static void Main(String[] args) {
        Garaje garaje = new Garaje();
        Coche coche1 = new Coche("Toyota", "Corolla");
        Coche coche2 = new Coche("Ford", "Focus");

        coche1.setMotor(new Motor(150));
        coche2.setMotor(new Motor(120));

        Random rand = new Random();

        for (int i = 0; i < 2; i++) {
            if (garaje.aceptarCoche(coche1, "aceite")) {
                double importe_averia = rand.NextDouble() * 100;
                coche1.acumularAveria(importe_averia);
                coche1.getMotor().setLitros_de_aceite(coche1.getMotor().getLitros_de_aceite() + 10);
                garaje.devolverCoche();
            }
            if (garaje.aceptarCoche(coche2, "frenos")) {
                double importe_averia = rand.NextDouble() * 100;
                coche2.acumularAveria(importe_averia);
                garaje.devolverCoche();
            }
        }

        Console.WriteLine("Información del coche 1:");
        Console.WriteLine("Marca: " + coche1.getMarca());
        Console.WriteLine("Modelo: " + coche1.getModelo());
        Console.WriteLine("Litros de aceite: " + coche1.getMotor().getLitros_de_aceite());
        Console.WriteLine("Precio acumulado de averías: " + coche1.getPrecio_acumulado_averias());

        Console.WriteLine();

        Console.WriteLine("Información del coche 2:");
        Console.WriteLine("Marca: " + coche2.getMarca());
        Console.WriteLine("Modelo: " + coche2.getModelo());
        Console.WriteLine("Precio acumulado de averías: " + coche2.getPrecio_acumulado_averias());

        Console.WriteLine();

        Console.WriteLine("Número de coches atendidos en el garaje: " + garaje.getNum_coches_atendidos());
    }
}
