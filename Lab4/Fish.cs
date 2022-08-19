using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public abstract class Fish
    {
        public string Title { get; set; }
        public double Length { get; set; }

        protected Fish(string title, double length)
        {
            Title = title;
            Length = length;
        }

        public abstract void Eat();
    }
}
