class Program
{
    static void Main(string[] args)
    {
        /* Kontynuj to zadanie */ 
        int n = 2;
        double wyznacznik = 0;
        double odwrotnosc = 0;
        double a1 = 0;
        double a2 = 0;
            double a3 = 0;
            double a4 = 0;
        double[,] macierz = new double[n, n];
        double[,] odwrotna = new double[n, n];
        double[,] dopelnien = new double[n, n];
        double[,] transponowana = new double[n, n];

        
        
        
        
        for (int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
        Console.WriteLine($"Podaj wartość a({i + 1},{j + 1})");
                macierz[i, j] = Convert.ToDouble(Console.ReadLine());

               

            }

        }
        Console.WriteLine("Podstawowa: ");
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {

                Console.Write($"{macierz[i, j], 4}");

            }
            Console.WriteLine();
        }
        
        for (int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                dopelnien[i, j] = Math.Pow(-1, i + j) * macierz[1 - i, 1 - j];
                /* dopelnien[i, j] = ((-1) * (-1)) * macierz[i, 0];
                dopelnien[i, j] = (-1) * macierz[i, j]; */
                

            }

        }
        Console.WriteLine("Dopełnień");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                
                Console.Write($"{dopelnien[i, j], 4}");

            }
            Console.WriteLine();
        }

        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                transponowana[i, j] = dopelnien[j, i];

            }


        }
        Console.WriteLine("Transponowana: ");
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write($"{transponowana[i, j], 4}");

            }
            Console.WriteLine();
        }
        
        
        
        
        
        wyznacznik = macierz[0, 0] * macierz[1, 1] - macierz[0, 1] * macierz[1, 0];
        Console.WriteLine($"{wyznacznik:F2}");
        
        odwrotnosc = 1 / wyznacznik;
        Console.WriteLine($"{odwrotnosc:F2}");
        
        
        for (int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                odwrotna[i, j] = odwrotnosc * transponowana[i, j];
            }
        }
        Console.WriteLine("Odwrotność: ");
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                Console.Write($"{odwrotna[i, j],4}");
            }
            Console.WriteLine();
        }
       /* Console.WriteLine($"{dopelnien}"); */
        
            
    }








}