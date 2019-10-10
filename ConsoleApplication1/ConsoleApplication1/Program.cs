using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine('A');
            //
            char c = 'A';
            Console.WriteLine(c);
            //
            short s = 65;
            Console.WriteLine((char)s);
            //
            c = (char)s;
            Console.WriteLine(c);
            //
            Print_a_2_z();
            Print_a_2_97();
        }

        public static void Print_a_2_z()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.Write(c + " ");
            }


            Console.WriteLine();

            for (char c = 'z'; c >= 'a'; c--)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            for (char c = 'A'; c <= 'Z'; c++)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            // for (int c = 97; c <= 122; c++) 
            //{
            //   Console.Write((char)c);
            // }
        }

        public static void Print_a_2_97()
        {
            int num;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            int ascii = num;
            Console.Write("test" + num);

        }
    }
}
