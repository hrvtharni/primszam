using System;

class Program
{
    static bool Prim(int szam)
    { 
        if (szam < 2)
            return false;

        for (int i = 2; i < szam; i++)
        {
            if (szam % i == 0)
                return false;
        }
        return true;
    }
    static void Main()
    {
        Console.WriteLine("Adj meg egy számot:");
        int szam = Convert.ToInt32(Console.ReadLine());

        if (Prim(szam))
        {
            Console.WriteLine("A megadott szám prím");
        }
        else
        {
            Console.WriteLine("A megadott szám nem prím");
        }
        
        Console.ReadKey();
    }
}
