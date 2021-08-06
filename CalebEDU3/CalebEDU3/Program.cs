using System;
using System.Linq;

namespace CalebEDU3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] puanlar = new int[10];
            puanlar[0] = 5;
            puanlar[9] = 55;*/

            /*int[] puanlar = { 100, 200, 300, 400, 500 };

            Console.WriteLine(puanlar[0]);*/





            /*Console.WriteLine("boyutu ne kadar olsun");
            int byt = Int32.Parse(Console.ReadLine());

            int[] puanlar = new int[byt];

            for (int i = 0; i < puanlar.Length; i++)
            {
                puanlar[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < puanlar.Length; i++)
            {
                Console.Write(puanlar[i] + " ");
            }*/





            /*int[] puanlar = { 10, 20, 30, 40, 50, 60 };
            Console.WriteLine("Hangi sayıyı arıyorsun?");
            int aranan = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < puanlar.Length; i++)
            {
                if(puanlar[i] == aranan)
                {
                    Console.WriteLine($"We found it is in {i}. index");
                }
            }

            Console.WriteLine(Array.IndexOf(puanlar, aranan));*/



            /*int[] puanlar1 = { 12, 42, 31, 55, 16, 23 };
            int[] puanlar2 = { 12, 42, 31, 55, 16, 23 };

            Console.WriteLine(Enumerable.SequenceEqual(puanlar1, puanlar2));
            

            for (int i = 0; i < puanlar1.Length; i++)
            {
                Console.WriteLine(puanlar1[i]);
            }*/



            /*int[,] puanlar1 = new int[3, 4];
            puanlar1[0, 2] = 5;
            Console.WriteLine(puanlar1[0, 2]);*/



            /*int[][] puanlar=        //jagged array
            {
                new int[]{ 3, 14, 32, 11 },
                new int[]{ 8, 44, 96, 22, 5, 52},
                new int[]{ 2, 36, 25}
            };

            Console.WriteLine(puanlar[1][5]);*/



            /*int[][] puanlar =           //iteration through jagged array
            {
                new int[]{ 3, 14, 32, 11 },
                new int[]{ 8, 44, 96, 22, 5, 52},
                new int[]{ 2, 36, 25}
            };

            for (int i = 0; i < puanlar.Length; i++)
            {
                for (int j = 0; j < puanlar[i].Length; j++)
                {
                    Console.Write(puanlar[i][j] + " ");
                }
                Console.WriteLine();
            }*/



            /*int[ , ] puanlar =           //iteration through 2d array
            {
                 { 3, 14, 32, 11 },
                 { 8, 44, 96, 22 },
                 { 2, 36, 25, 14 }
            };

            for (int i = 0; i < puanlar.GetLength(0); i++)
            {
                for (int j = 0; j < puanlar.GetLength(1); j++)
                {
                    Console.Write(puanlar[i, j] + " ");
                }
                Console.WriteLine();
            }*/


        }
    }
}
