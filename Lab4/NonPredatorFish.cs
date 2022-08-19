using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class NonPredatorFish : Fish
    {
        public NonPredatorFish(string title, double length) : base(title, length)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Eat seabreed");
        }
    }
}
