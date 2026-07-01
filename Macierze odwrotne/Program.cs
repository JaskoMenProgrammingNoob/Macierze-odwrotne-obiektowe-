using System.ComponentModel.Design;
class Macierze
{

    /* Kontynuj to zadanie */
    int n = 2;
    double wyznacznik = 0;
    double odwrotnosc = 0;
    double a1 = 0;
    double a2 = 0;
    double a3 = 0;
    double a4 = 0;
    double[,] macierz  = new double[2, 2];
    double[,] odwrotna = new double[2, 2];
    double[,] dopelnien =  new double[2, 2];
    double[,] transponowana  = new double[2, 2];

  

    public void czytaj_dane()
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine($"Podaj wartość a({i + 1},{j + 1})");
                macierz[i, j] = Convert.ToDouble(Console.ReadLine());



            }

        }
    }
    public void przetworz_dane() {

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                dopelnien[i, j] = Math.Pow(-1, i + j) * macierz[1 - i, 1 - j];
                /* dopelnien[i, j] = ((-1) * (-1)) * macierz[i, 0];
                dopelnien[i, j] = (-1) * macierz[i, j]; */


            }

        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                transponowana[i, j] = dopelnien[j, i];

            }


        }

        wyznacznik = macierz[0, 0] * macierz[1, 1] - macierz[0, 1] * macierz[1, 0];
        switch (wyznacznik)
        {
            case 0:
                Console.WriteLine("Wyznacznik = 0, brak macierzy odwrotnej");
                break;
            default:
                odwrotnosc = 1 / wyznacznik;
                break;

        }


       
       




        /* Console.WriteLine($"{wyznacznik:F2}"); */

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                odwrotna[i, j] = odwrotnosc * transponowana[i, j];
            }
        }
        /* Console.WriteLine($"{dopelnien}"); */

    }
    public void wyswietl_dane()
    {
        switch (wyznacznik)
        {

            case 0:
                Console.WriteLine("Podstawowa: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {

                        Console.Write($"{macierz[i, j],4}");

                    }
                    Console.WriteLine();
                }
                break;
            default:
                Console.WriteLine("Podstawowa: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {

                        Console.Write($"{macierz[i, j],4}");

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Dopełnień");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {

                        Console.Write($"{dopelnien[i, j],4}");

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Transponowana: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{transponowana[i, j],4}");

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Odwrotność: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{odwrotna[i, j],5:F1}");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"Wyznacznik: {wyznacznik}");
                Console.WriteLine($"Odwrotność: {odwrotnosc}");
                break;

        }
        
    }
        
    static void Main(string[] args)
    {

        Macierze macierze = new Macierze();
        macierze.czytaj_dane();
        macierze.przetworz_dane();
        macierze.wyswietl_dane();




    }
    }


