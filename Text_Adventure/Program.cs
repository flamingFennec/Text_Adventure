using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cookin();
        }

        public static void Cookin()
        {
            Console.WriteLine("What type of breakfast do you like to cook?");
            string Breakfast = Console.ReadLine();
            Console.WriteLine("Your stove has 5 settings. You have to turn the knob to pick. What setting do you turn it to?");

            try
            {
                double stoveTurn = double.Parse(Console.ReadLine());

                if (stoveTurn == 5)
                {
                    Console.WriteLine("You burned the crud out of your food. Which proceeded to start a huge fire, resulting in your house being burnt down.");
                    Dieded();
                }
                else if (stoveTurn < 5)
                {
                    if (stoveTurn < 3)
                    {
                        Console.WriteLine("Your breakfast cooked too slow and you were left with nothing to eat.");
                        Dieded();
                    }
                    else if (stoveTurn >= 3)
                    {
                        Console.WriteLine($"Your {Breakfast} is sizzling away on the stove.");
                    }
                }
                else
                {
                    Console.WriteLine($"You tried to turn your stove to {stoveTurn} in your tired haze and broke the handle off your stove. You were left with no food to eat.");
                    Dieded();
                }

                Flipin();
            }
            catch (FormatException)
            {
                Console.WriteLine("You somehow ripped the stove knob off violently, your hand smacked you in the face with such force that it put an indent in your head.");
                Dieded();
            }
        }

        static void Dieded()
        {
            Console.WriteLine("Because of which, you died. Try again.");
            Cookin();
        }

        static void Flipin()
        {
            Console.WriteLine("You have to flip your food.");
            Random random = new Random();
            int result = random.Next(2);

            if (result == 0)
            {
                Console.WriteLine($"Your food hit you in the face while trying to flip it.");
                Dieded();
            }
            else
            {
                Console.WriteLine("Your food flipped successfully.");
                Console.ReadKey();
            }
        }
    }
}
