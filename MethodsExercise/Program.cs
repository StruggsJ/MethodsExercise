namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
         #region StoryMethod

           string storyName = Story.CharacterName();
           string storyColor = Story.FavoriteColor();
           string storyAnimal = Story.FavoriteAnimal();
           string storyBand = Story.FavoriteBand();

           Console.WriteLine($"Your name is {storyName} and your favorite color is {storyColor}.");
           Console.WriteLine($"You have a pet {storyAnimal} who you share your music collection with from {storyBand}, " +
               $"your favorite band.\n");
            #endregion

            #region Math

            MathOperator.AddNumber();
            
            MathOperator.SubtractNumber();
            
            MathOperator.MultiplyNumber();
          
            MathOperator.ModuloNumber();
            

         #endregion
        }
    }
}
