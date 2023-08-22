using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog : Animal
    {
        public Dog(string name, string sex, int age) : base(name, sex, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " says 'Woof'");
            Console.ReadKey();
        }
    }
}
