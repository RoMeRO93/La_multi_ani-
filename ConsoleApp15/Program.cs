using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var currentYear = DateTime.Now.Year;
        var birthYear = 1993;
        int age = currentYear - birthYear;

        Console.WriteLine("Ai implinit " + age + " de ani!");

        if (age == 30)
        {
            Console.WriteLine("La multi ani!");
        }
        else if (age < 30)
        {
            int yearsLeft = 30 - age;
            Console.WriteLine("Mai ai de asteptat " + yearsLeft + " ani!");
        }
        else
        {
            Console.WriteLine("Ai trecut de 30 de ani!");
        }
    }
}
