using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        public class Program
        {
            static void Main(string[] args)
            {
                //2ci tapsiriq
                int a = 15;
                if (a % 3 == 0)
                {
                    Console.WriteLine("Bu eded 3 e bolunur");
                }
                else if (a % 7 == 0)
                {
                    Console.WriteLine("Bu eded 7e bolunur");
                }
                else
                {
                    Console.WriteLine("");
                }

                //3cu tapsiriq
                int hava = 20;
                if (hava < 15)
                {
                    Console.WriteLine("Hava soyuqdur");
                }
                else if (hava > 15)
                {
                    Console.WriteLine("Hava istidir");
                }


                //4cu tapsiriq
                int n = 6;
                int m = 8;
                if (n % 2 == 0 && m % 2 == 0)
                {
                    Console.WriteLine(m + n);
                }

                //5ci tapsiriq
                int t = 15;
                int p = 30;
                if (t == 30 || p == 30 || t + p == 30)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

            }

            //1ci tapsiriq
            public static int Func()
            {
                int[] number = { 1, 8, 10, 15, 20, 12, 3, 7 };
                int sum = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] % 2 == 0)
                    {
                        Console.WriteLine(sum += number[i] * number[i]);
                    }
                    Console.WriteLine(number[i] += number[i]);
                }
                return Func();
            }
        }
    }


