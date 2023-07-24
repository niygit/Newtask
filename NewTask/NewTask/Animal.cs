using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public abstract  void Eat();
        public Animal(string name)
        {
            Name = name;
        }

        //public virtual void ShowEating()
        //{
        //    Console.WriteLine(this.Eat);
        //}
    }
}