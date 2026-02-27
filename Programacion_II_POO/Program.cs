using System.ComponentModel;
using Estructuras_Objetos;

Console.WriteLine("Hello, World!");

Numero num1 = new Numero(7);
Numero num2 = new Numero(-2);
num2.ponerValor(-2);
Console.WriteLine(num1.obtenervalor());
Console.WriteLine(num2.obtenervalor());
Console.WriteLine(num1.num_primo());
Console.WriteLine(num2.num_primo());
Console.WriteLine(num1.cantidad_digitos());
Console.WriteLine(num2.cantidad_digitos());

Numero num3 = new Numero(7483);
int burbuja   = num3.OrdenarDigitosBurbuja();
int seleccion = num3.OrdenarDigitosSeleccion();
Console.WriteLine($"Dígitos Bubble Sort:    {burbuja}");
Console.WriteLine($"Dígitos Selection Sort: {seleccion}");

// Convertir a literal
Numero num4 = new Numero(7483);
Console.WriteLine($"Literal: {num4.ConvertirALiteral()}");



//instancia vs constructor
