using System;
using System.Linq;
using System.Collections.Generic;

namespace CalebEDU4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> puanlar = new List<int>() { 5, 7, 1, 37, 73, 12, 8, 5, 37};

            Console.WriteLine(Convert.ToString(puanlar.Contains(5)));
            Console.WriteLine(Convert.ToInt32(puanlar.IndexOf(5)));
            Console.WriteLine(puanlar.LastIndexOf(5));

            for(int i = 0; i < puanlar.Count; i++)
            {
                Console.Write(puanlar[i] + " ");
            }*/



            /*List<int> puanlar1 = new List<int>() { 5, 7, 1, 37, 73, 12, 8, 5, 37 };
            List<int> puanlar2 = new List<int>() { 5, 7, 1, 37, 73, 12, 8, 5, 37 };

            Console.WriteLine(Convert.ToString(Enumerable.SequenceEqual<int>(puanlar1, puanlar2)));*/



            /*List<int> puanlar1 = new List<int>() { 5, 7, 1, 37, 73, 12, 8, 5, 37, 26, 61, 21 };

            for (int i = 0; i < puanlar1.Count; i++)
            {
                Console.Write(puanlar1[i] + " ");
            }*/



            /*List<int> puanlar1 = new List<int>() { 5, 7, 1, 37, 73, 12, 8, 5, 37, 26, 61, 21 };

            foreach (int puan in puanlar1)
            {
                Console.Write(puan + " ");
            }*/



            /*List<List<int>> puanlar = new List<List<int>>() 
            {
                new List<int>() { 5, 1, 4, 9},
                new List<int>() { 12, 5, 9, 21},
                new List<int>() { 23, 26, 61, 1},
                new List<int>() { 8, 32, 19, 4}
            };

            foreach (List<int> i in puanlar)
            {
                foreach (int j in i)
                {
                    Console.Write(j + "\t");
                }
                Console.WriteLine();
            }*/



            /*List<int>   puanlar1 = new List<int>() { 5, 7, 1, 37, 73, 12, 8, 5, 37, 26, 61, 21 };

            int[][]     puanlar2 = 
            {
                new int[] { 5, 1, 4, 9},
                new int[] { 12, 5, 9, 21},
                new int[] { 23, 26, 61, 1},
                new int[] { 8, 32, 19, 4}
            };

            int[] myArr = puanlar1.ToArray();       //Convertion of List to Array
            List<int[]> myList = puanlar2.ToList(); //Conversion of Array to List

            //Also we can conver just 1 array inside puanlar2 array
            List<int> myList2 = puanlar2[0].ToList();

            //Arrays inside a List
            List<int[]> puanlar3 = new List<int[]>()
            {
                new int[] { 5, 1, 4, 9},
                new int[] { 12, 5, 9, 21},
                new int[] { 23, 26, 61, 1},
                new int[] { 8, 32, 19, 4}
            };*/



            List<int> puanlar1 = new List<int>() { 5, 7, 1, 37, 73, 12, 8, 5, 37, 26, 61, 21 };
            
            puanlar1.Sort();
            puanlar1.Reverse();
            

            foreach (int i in puanlar1)
            {
                Console.Write(i + " ");
            }
        }
    }
}
