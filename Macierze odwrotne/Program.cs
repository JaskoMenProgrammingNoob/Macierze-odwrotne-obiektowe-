class Program
{
    static void Main(string[] args)
    {
        /* Kontynuj to zadanie */ 
        int n = 2;
        double wyznacznik = 0;
        double odwrotnosc = 0;
        double[,] macierz = new double[n, n];
        for (int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
        Console.WriteLine($"Podaj wartość a({i + 1},{j + 1})");
                macierz[i, j] = Convert.ToDouble(Console.ReadLine());

               

            }

        }
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {

                Console.Write($"{macierz[i, j], 4}");

            }
            Console.WriteLine();
        }
        wyznacznik = macierz[0, 0] * macierz[1, 1] - macierz[0, 1] * macierz[1, 0];
        Console.WriteLine($"{wyznacznik:F2}");
        odwrotnosc = 1 / wyznacznik;
        Console.WriteLine($"{odwrotnosc:F2}");
        
            
    }








}