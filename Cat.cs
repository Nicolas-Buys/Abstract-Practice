using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Cat : Animal
    {
        public Cat(string name, string sex, int age) : base(name, sex, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " Meows");
            Console.ReadKey();
        }
    }
}
