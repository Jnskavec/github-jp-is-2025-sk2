string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel ******");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jan Prskavec *****************");
    Console.WriteLine("************** 06.11.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("================================================");





    // Deklarace pole (array)
    int[] MyRandNumbs = new int[n];

    //příprava pro využití třídy Random
    Random RandNumb = new Random();
    // Random RandNumb = new Random(15);


    Console.WriteLine();   
    Console.WriteLine("Náhodná čísla: ");
    for (int i = 0; i < n; i++)


    {
        MyRandNumbs[i] = RandNumb.Next(lowerBound, upperBound + 1); // generování čísla a uložení do pole
        Console.WriteLine(MyRandNumbs[i]); // výpis čísla z pole
    }
    {
        MyRandNumbs[i] = RandNumb.Next(lowerBound, upperBound);
        Console.WriteLine("{0}", MyRandNumbs[i]);
    }



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    Console.ReadLine();
}