using System;
using System.Collections.Generic;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NonPredatorFish fish = new NonPredatorFish("Salmon", 1.5);
            PredatorFish predator = new PredatorFish("White shark", 6.3);          

            Fish fish1 = new PredatorFish("White shark", 6.3);

            Sea sea = new Sea("Black Sea");

            sea.AddFish(fish);
            sea.AddFish(predator);

            Fish[] fish2 = new Fish[] { fish, predator };

            foreach (Fish item in fish2)
            {
                item.Eat();
            }

            FeedFish(fish);
            FeedFish(predator);
        }

        static void FeedFish(Fish fish)
        {
            fish.Eat();
        }
    }
}
