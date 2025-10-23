using System.Runtime.InteropServices.Marshalling;

internal class Program
{
    private static void Main(string[] args)
    {
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("*********** Seřazení dvou čísel*************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine("************* Jan Prskavec *****************");
            Console.WriteLine("************** 23.10.2025 ******************");
            Console.WriteLine("********************************************");
            Console.WriteLine("********************************************");
            Console.WriteLine();


            Console.Write("Zadejte celé číslo A: ");
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
            }


            Console.Write("Zadejte celé číslo B: ");
            int b;
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu B: ");
            }

            Console.Write("Zadejte celé číslo C: ");
            int c;
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu C: ");
            }

            Console.WriteLine();

            int pom;
            // Chceme seřadit čísla vzestupně
            if (a > b)
                if (b > c)

                {
                    pom = a;
                    a = b;
                    b = pom;
                    b = c;
                    c = pom;
                    Console.WriteLine("Došlo k prohození proměnných");
                }
            Console.WriteLine();
            Console.WriteLine("==============================================================");
            Console.WriteLine($"Seřazená čísla: {a}, {b}, {c}");
            Console.WriteLine("==============================================================");
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();

        }
    }
}