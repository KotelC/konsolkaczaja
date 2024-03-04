using System;

class Przeliczanie
{
    static void Main()
    {
        int n = 100;
        bool[] liczby = new bool[n + 1];

        Przelicz(liczby, n);

        Console.WriteLine("Liczby pierwsze w przedziale do 100");

        Wypisz(liczby);
    }


    static void Przelicz(bool[] liczby, int n)
    {
        for (int i = 0; i < n; i++)

        {
            liczby[i] = true;
        }


        for (int p = 2; p * p <= n;  p++)

        {
            if (liczby[p] == true)


                for (int i = p * p; i <= n; i += p)
                {
                    liczby[i] = false;
                }

        }
    }



    static void Wypisz(bool[] liczby)
    {
        for (int p = 2; p < liczby.Length; p++)
        {
            if (liczby[p] == true)
            {
                Console.Write(p + " ");

            }
        }
        Console.WriteLine();
                }


}