using System;

namespace ConsoleApp2
{
    class Program
    {
        private static int counter;

        static void Main(string[] args)
        {
            /*isi kecil-kecil dlu, 350 ga selesai selesai prosesnya*/
            PrintCombinations(10);
            Console.WriteLine("total possibility: " + counter.ToString());
        }
        
        public static void PrintCombinations(int n)
        {
            PrintRest("", 0, n, n - 1);
        }
        private static void PrintRest(string listStart, int startSum, int n, int max)
        {
            int[] coins = new int[] { 1, 5, 10, 25, 50, 100, 200 };
            
            for (int i = 0; i < coins.Length-1; i++)
            {
                string list = listStart.Length > 0
                    ? listStart + " + " + coins[i].ToString()
                    : coins[i].ToString();
                int sum = startSum + coins[i];
                if (sum == n)
                {
                    /*buat ngeprint combination*/
                    Console.WriteLine(list);
                    /*counter untuk hitung jumlah combination*/
                    counter++;
                }
                else if (sum < n)
                { 
                    PrintRest(list, sum, n, coins[i]);
                }
            }
        }
    }
}
