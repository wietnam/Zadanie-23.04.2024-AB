using System;

namespace Algorytmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[100];
            Random rand = new Random();

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = rand.Next(1, 1001);
            }

            Console.WriteLine("Tablica losowych liczb:");
            foreach (int liczba in tablica)
            {
                Console.Write(liczba + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Podaj liczbę do wyszukania:");
            int szukanaLiczba = int.Parse(Console.ReadLine());

            int wynikLiniowe = WyszukiwanieLiniowe(tablica, szukanaLiczba);
            Console.WriteLine(wynikLiniowe != -1 ? $"Liczba {szukanaLiczba} znaleziona na pozycji {wynikLiniowe}." : $"Liczba {szukanaLiczba} nie została znaleziona.");

            int wynikLinioweZWartownikiem = WyszukiwanieLinioweZWartownikiem(tablica, szukanaLiczba);
            Console.WriteLine(wynikLinioweZWartownikiem != -1 ? $"Liczba {szukanaLiczba} znaleziona na pozycji {wynikLinioweZWartownikiem}." : $"Liczba {szukanaLiczba} nie została znaleziona.");
        }

        static int WyszukiwanieLiniowe(int[] tablica, int szukanaLiczba)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] == szukanaLiczba)
                {
                    return i;
                }
            }
            return -1; 
        }

        static int WyszukiwanieLinioweZWartownikiem(int[] tablica, int szukanaLiczba)
        {
            int[] tablicaZWartownikiem = new int[tablica.Length + 1];
            Array.Copy(tablica, tablicaZWartownikiem, tablica.Length);
            tablicaZWartownikiem[tablica.Length] = szukanaLiczba;

            int i = 0;
            while (tablicaZWartownikiem[i] != szukanaLiczba)
            {
                i++;
            }

            return i == tablica.Length ? -1 : i; 
        }
    }
}
