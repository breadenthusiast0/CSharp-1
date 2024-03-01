// Ejemplo 1, Herencia basica:
Perro miPerro = new Perro();
miPerro.Comer();
miPerro.Ladrar();
Console.WriteLine("");

// Ejemplo 2, Sobrescritura de metodos:
Figura1 miFigura = new Circulo1();
miFigura.Dibujar();
Console.WriteLine("");

// Ejemplo 3, Herencia con constructor:
Empleado emp = new Empleado("Diego" , "Developer");
emp.Info();
emp.InfoDeEmpleado();
Console.WriteLine("");

// Ejemplo 4, Herencia con propiedades abstractas:
Circulo2 miCirculo = new Circulo2(5);
miCirculo.ImprimirArea();
Console.WriteLine("");

// Ejemplo 5, Herencia con interfaces:
Piano miPiano = new Piano();
miPiano.Afinar();
miPiano.Tocar();