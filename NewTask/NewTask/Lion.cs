using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    internal class Lion:Animal
    {
        public Lion(string name):base(name)
        {

        }
        public override void Eat()
        {
            Console.WriteLine("Aslan Et yeyir");
        }
        public  void Run()
        {
            Console.WriteLine("Qacir");
        }
    }
}
