using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
     
            static void Main(string[] args)
            {
                int n = 10;
                char[,] Arr = new char[n, 2 * n];
                ClearArray(Arr, n);
                DrawX(Arr, n);
                //DrawG(Arr, n);
                PrintArray(Arr, n);
            }

            public static void ClearArray(char[,] Arr, int n)
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j <n; j++)
                        Arr[i, j] = ' ';
            }

            public static void PrintArray(char[,] Arr, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n * 2; j++)
                    { 
                        Console.Write(Arr[i, j]); 
                    }
                        Console.WriteLine();
                }
            }

            public static void DrawX(char[,] Arr, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Arr[i, i] = '*';
                }
                int d = n - 1, c = n - 1;
                while (d >=0)
                {
                    Arr[d, c] = '*';
                    d--;
                    c++;
                }
            }

        }
    }

