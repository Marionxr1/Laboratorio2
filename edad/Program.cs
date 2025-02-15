using System;

class Program
{
    static void Main()
    {
        // Pedir al usuario que ingrese su edad
        Console.WriteLine("Introduce tu edad:");
        int edad = int.Parse(Console.ReadLine());

        // Determinar la categoría utilizando el switch
        string categoria;

        switch (edad)
        {
            case int n when (n < 12):
                categoria = "Niño";
                break;
            case int n when (n >= 12 && n <= 17):
                categoria = "Adolescente";
                break;
            case int n when (n >= 18 && n <= 59):
                categoria = "Adulto";
                break;
            case int n when (n >= 60):
                categoria = "Adulto mayor";
                break;
            default:
                categoria = "Edad no válida";
                break;
        }

        // Mostrar la categoría
        Console.WriteLine($"Tu categoría es: {categoria}");
    }
}

