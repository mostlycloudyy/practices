using System;

namespace CalebEDU1                         //a namespace - used for organization
{
    class Program                           //a class - has members (such as method)
    {
        static void Main(string[] args)     //a method - contains a block of code
        {
            Console.WriteLine(Person.x);

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            int l = 0;
            bool o = false;
            while (true)
            {
                //Console.WriteLine("kac?");
                //int l = Int32.Parse(Console.ReadLine());
                
                for (int u = l; u < 15; u+=2) Console.WriteLine("");

                for (int i = 0; i <= l; i++)
                {
                    
                    for (int j = 0; j <= l; j++)
                    {
                        if (i == j)
                        {
                            for (int u = l; u < 10; u++) Console.Write(" ");
                            Console.Write("\\");
                            for (int k = 0; k < (l - i); k++)
                            {
                                if (i == 0)
                                {
                                    Console.Write('\u203E');
                                    Console.Write('\u203E');
                                }
                                else
                                {
                                    Console.Write("  ");
                                }
                            }
                            Console.Write("/");
                            Console.Write("\n");
                            break;
                        }
                        Console.Write(" ");
                    }
                }
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                if (!o)
                {
                    l+=2;
                    if (l == 12) o = true;
                }
                if (o)
                {
                    l-= 2;
                    if (l == 0) o = false;
                }
            }
        }
    }
}

//namespace -> classes -> members -> method -> statements