using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Sea
    {
        public string Title { get; set; }
        public List<Fish> Fish { get; set; }

        public Sea(string title)
        {
            Title = title;
            Fish = new List<Fish>();
        }

        public void AddFish(Fish fish)
        {
            Fish.Add(fish);
        }
    }
}
