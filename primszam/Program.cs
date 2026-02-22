using System;

class Program
{
    static bool Prim(int szam) // A bool függvény visszaadja, hogy igaz vagy hammis, a neve: Prim, és egy int paramétert vár, ami a szam
    { 
        if (szam < 2) // Ha a megadott szám kisebb, mint 2, akkor nem lehet prím, ezért visszatérünk hamis értékkel
            return false;

        for (int i = 2; i < szam; i++) // Egy ciklus, ami 2-től a megadott számig megy, és ellenőrzi, hogy a megadott szám osztható-e bármelyik számmal a ciklusban
        {
            if (szam % i == 0) // Ha maradék nélkül osztható, akkor nem prím, ezért visszatérünk hamis értékkel
                return false;
        }
        return true; // Ha egyik számmal sem osztható, akkor prím, ezért visszatérünk igaz értékkel
    }
    static void Main()
    {
        Console.WriteLine("Adj meg egy számot:");
        int szam = Convert.ToInt32(Console.ReadLine());

        if (Prim(szam)) // Meghívom a Prim függvényt a megadott számmal, és ha igaz értéket ad vissza, akkor kiírjuk, hogy prím, különben nem prím
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
