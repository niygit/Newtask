using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int dif = Difference(new int[] { 6, 5, 9, 3, 10 });
            //Console.WriteLine(dif);


            //2ci
            //int res= CutEded(3, 9);
            // Console.WriteLine(res);


            //3 cu 
            //Simple(7);

            Lion lion = new Lion("Aslan");
            lion.Eat();
            lion.Run();
            SayName(lion);

            Console.WriteLine("////////////////////////");

            Eagle eagle = new Eagle("Qartal");
            eagle.Eat();
            eagle.Fly();
            SayName(eagle);
        }
        static void SayName(Animal animal)
        {
            Console.WriteLine(animal.Name);
        }
        public static int Difference(int[] numbers)
        {
            int largest = numbers[0];
            int smallest = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }
            return largest - smallest;

        }
        //2 ci tapsiriq
        public static int CutEded(int a,int b)
        {
            int sum = 0;
            for (int i =a; i < b; i++)
            {
                if (i%2==0)
                {
                    sum++;
                }
            }
            return sum;
        }
        //3 cu tapsiriq
        public static void Simple(int reqem)
        {
            if (reqem %2==0)
            {
                if (reqem>2)
                {
                    Console.WriteLine("Murekkeb eded");
                }
            }
           else if (reqem==1)
            {
                Console.WriteLine("Ne sade ne murekkeb");
            }
            else
            {
                Console.WriteLine("Sade");
            }
        }
    }
}

