using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int MaxSpeed { get; set; }
        public Car(string model,string brand,int maxSpeed)
        {
            Model = model;
            Brand = brand;
            MaxSpeed = maxSpeed;
        }
        public abstract void ShowMaxSpeed();

        public void ShowModel()
        {
            Console.WriteLine(this.Model);
        }
        public virtual void ShowBrand()
        {
            Console.WriteLine(this.Brand);
        }
    }
}
