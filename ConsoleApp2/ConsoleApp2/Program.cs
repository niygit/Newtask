using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = StringLength("Salamghghjj");
            Console.WriteLine(sum);
        }
        //{
        //    Mercedes mercedes = new Mercedes("A class","Benz",300);
        //    mercedes.ShowMaxSpeed();
        //    mercedes.ShowModel();
        //    Bmw bmw = new Bmw("740","M",400);
        //    bmw.ShowMaxSpeed();
        //    bmw.ShowModel();
        //    bmw.ShowBrand();
        //    mercedes.ShowBrand();
        //}       
        public static void Reverse(int a, int b)
        {
            Console.WriteLine($"First-{a},Sekond-{b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"First-{a},Sekond-{b}");
        }
        static void Sorting(int[] numbers)
        {
            if (numbers.Length > 3)
            {
                return;
            }
            foreach (var num in numbers)
            {
                Console.Write($"{num} ");
            }
            if (numbers[0] > numbers[1])
            {
                int temp = numbers[0];
                numbers[0] = numbers[1];
                numbers[1] = temp;
            }
            if (numbers[1] > numbers[2])
            {
                int temp = numbers[1];
                numbers[1] = numbers[2];
                numbers[2] = temp;
            }
            foreach (var num in numbers)
            {
                Console.Write($"{num} ");
            }
        }

        static void SortingArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static int MaxLength(int[] numbers)
        {
            int max = 0;
            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        static int Sum(int a,int b)
        {
            int result = 0;
            for (int i = a; i < b; i++)
            {
                if (i%2==1)
                {
                    result += i; 
                }
            }
            return result;
        }
        static int StringLength(string text)
        {
            int length = 0;
            foreach (var item in text)
            {
                length++;
            }
            return length;
        }
    }  
}
