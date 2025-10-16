string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Součet cifer ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jan Prskavec *****************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    int suma = 0;
    int numberBackup = number;
    int digit;

    //Pokud je vstup záporný, tak ho změníme na kladný
    if (number < 0)
    {
        number = -number;
    }

    while ()
    {
        digit = numberBackup % 10; // určí se nám zbytek
        number = (number - digit) / 10;
        Cobsole.WriteLine("Hodnota zbytku: {0}", digit)
        suma = suma + digit;

    }
    
    // Musíme poslední cifru vypsat
    Console.WriteLine("Poslední zbytek = {0}", number)

    // Musíme poslední cifru přičíst
    suma = suma + number;

    Console.WriteLine();
    Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}