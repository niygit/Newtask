using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    internal class Eagle:Animal
    {
        public Eagle(string name):base(name)
        {

        }
        public override void Eat()
        {
            Console.WriteLine(" Qartal Baliq yeyir");
        }
        public  void Fly()
        {
            Console.WriteLine("Ucur");
        }
    }
}
