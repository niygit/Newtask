using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Bmw:Car
    {
        public Bmw(string model, string brand, int maxSpeed):base(model,brand,maxSpeed)
        {

        }
        public override void ShowMaxSpeed()
        {
            Console.WriteLine(this.MaxSpeed / 2);
        }
        public override void ShowBrand()
        {
            Console.WriteLine(this.Brand + this.Model);
        }
    }
}
