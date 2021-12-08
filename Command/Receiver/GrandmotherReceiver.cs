using System;

namespace Command.Receiver
{
    public class GrandmotherReceiver
    {
        public void CookChocolateCake()
        {
            Console.WriteLine("Yes! Grandmother is cooking a chocolate cake...\n");

            MakeTheCakeBatter();
            AddYeast();
            PutTheCakeBatterInTheOver();

            Console.WriteLine("\nWOW! We have a chocolate cake!");
        }

        private static void MakeTheCakeBatter()
        {
            Console.WriteLine("1. Grandmother is making the cake batter...");
        }

        private static void AddYeast()
        {
            Console.WriteLine("2. Grandmother is adding yeast to the cake batter...");
        }

        private static void PutTheCakeBatterInTheOver()
        {
            Console.WriteLine("3. Grandmother is putting the cake batter in the oven...");
        }
    }
}