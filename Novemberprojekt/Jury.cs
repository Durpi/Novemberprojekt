using System;

namespace Novemberprojekt
{
    public class Jury: Stats
    {
        Ingredient ingredient = new Ingredient();

        

        public Jury()
        {
            salty = generator.Next(0, 2);
            sweet = generator.Next(0, 2);
            sour = generator.Next(0, 2);
            bitter = generator.Next(0, 2);
            umami = generator.Next(0, 2);
        }

        public void JuryJudment()
        {

            if (salty == ingredient.salty)
            {
                Console.WriteLine("The jury likes the saltyness of the dish.");
            }
            if (sweet == ingredient.sweet)
            {
                Console.WriteLine("The jury likes the sweetness of the dish.");
            }
            if (sour == ingredient.sour)
            {
                Console.WriteLine("The jury likes the sourness of the dish.");
            }
            if (bitter == ingredient.bitter)
            {
                Console.WriteLine("The jury likes the bitterness of the dish.");
            }
            if (umami == ingredient.umami)
            {
                Console.WriteLine("The jury likes the umami of the dish.");
            }

        }
        
    }
}
