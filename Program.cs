Pasaje NuevoViaje1 = new Pasaje("Santo Domingo - San Pedro", "Platinum", 17, 5);
Pasaje NuevoViaje2 = new Pasaje("Santo Domingo - Santiago", "Gold", 12, 3);

Console.WriteLine("Ruta:\t\t\t" + NuevoViaje1.ruta);
Console.WriteLine("Clase:\t\t\t" + NuevoViaje1.categoria);
Console.WriteLine("Asientos Llenos:\t" + NuevoViaje1.asientosLlenos);
Console.WriteLine("Asientos Disponibles:\t" + NuevoViaje1.asientosDisponibles);
NuevoViaje1.CalculoDePrecio();
Console.WriteLine("Precio:\t\t\t" + NuevoViaje1.precio);

Console.WriteLine("");

Console.WriteLine("Ruta:\t\t\t" + NuevoViaje2.ruta);
Console.WriteLine("Clase:\t\t\t" + NuevoViaje2.categoria);
Console.WriteLine("Asientos Llenos:\t" + NuevoViaje2.asientosLlenos);
Console.WriteLine("Asientos Disponibles:\t" + NuevoViaje2.asientosDisponibles);
NuevoViaje2.CalculoDePrecio();
Console.WriteLine("Precio:\t\t\t" + NuevoViaje2.precio);