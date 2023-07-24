using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Mercedes:Car
    {
        public Mercedes(string model,string brand,int maxSpeed):base(model,brand,maxSpeed)
        {

        }
        public override void ShowMaxSpeed()
        {
            Console.WriteLine(this.MaxSpeed);
        }
        public override void ShowBrand()
        {
            Console.WriteLine(this.Model+this.Brand);
        }
    }
}
