using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadej celé číslo: ");
        string vstup = Console.ReadLine();

        int a = 0;
        int b = 1;

        foreach (char znak in vstup)
        {
            if (Char.IsDigit(znak))
            {
                int cifra = znak - '0'; // převod znaku na číslo
                a += cifra;
                b *= cifra;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Součet číslic: {a}");
        Console.WriteLine($"Součin číslic: {b}");
    }
}