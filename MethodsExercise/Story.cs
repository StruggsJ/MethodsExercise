using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
   internal class Story
    {
        public static string CharacterName ()
        {
            Console.WriteLine("What is your name?");
            string? myName = Console.ReadLine();
            return myName;
        }

        public static string FavoriteColor ()
        {
            Console.WriteLine("What is your favorite color?");
            string? myColor = Console.ReadLine();
            return myColor;
        }

        public static string FavoriteAnimal ()
        {
            Console.WriteLine("What is your favorite animal?");
            string? myAnimal = Console.ReadLine();
            return myAnimal;
        }

        public static string FavoriteBand ()
        {
            Console.WriteLine("What is your favorite band?");
            string? myBand = Console.ReadLine();
            return myBand;
        }
    }
}
