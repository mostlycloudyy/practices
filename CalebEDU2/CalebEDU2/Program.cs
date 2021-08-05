using System;

namespace CalebEDU2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 9; i >= 0; i--)
            {
                
                for(int j = i; j >= 0; j--)
                {
                    if (j < 4) continue;
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
