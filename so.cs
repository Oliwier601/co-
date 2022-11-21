// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Zad 1");
//Console.WriteLine("Podaj początek drogi:");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Podaj koniec drogi:");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine("Podaj długość skoku:");
//int c = int.Parse(Console.ReadLine());
//if (b - a > c * 5)
//{
//    Console.WriteLine("Tak trafi na koniec.");
//    Console.WriteLine("Do przekroczenia końca zostało " + ((b - a - c * 5) / c) + " skoków.");
//}
//else if ((b - a) % 5 == 0)
//{
//    Console.WriteLine("Bajtożabka trafiła do końca na piątym skoku.");
//}
//else
//{
//    Console.WriteLine("Nie.");
//}
/*Console.WriteLine("Zad 2");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
	if ()
	{

	}
}*/
//Console.WriteLine("Zad 3");
int n = int.Parse(Console.ReadLine());
if (n % 2 == 1)
{
    for (int i = 1; i < n + 1; i++)
{
        for (int j = 1; j < n + 1; j++)
        {
            if ( i == j || i + j == n + 1)
            {
                Console.Write("*");
            }
            else if (i == j || i + j == n + 1)
            {
                Console.WriteLine("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
}
}
else Console.WriteLine("Liczba jest parzysta.");
