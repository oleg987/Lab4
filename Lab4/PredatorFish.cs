using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public sealed class PredatorFish : Fish
    {
        public int DangerLevel { get; set; }

        public PredatorFish(string title, double length) : base(title, length)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Eat another fish");
        }
    }
}
