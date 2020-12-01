using System;

namespace Novemberprojekt
{
    //Inherits the traits from "Stats"
    public class Jury: Stats
    {
        //Takes in the class "Dish"
        Dish dish = new Dish();


        
        //A constructor that generates the likes of the jury
        public Jury()
        {
            salty = generator.Next(0, 2);
            sweet = generator.Next(0, 2);
            sour = generator.Next(0, 2);
            bitter = generator.Next(0, 2);
            umami = generator.Next(0, 2);
        }

        //Compares the tastes of the dish and the jurys likes to see if the dish was good
        public void JuryJudment()
        {
            int like = 0;


            if (salty == dish.salty)
            {
                Console.WriteLine("The jury likes the saltyness of the dish.");
                like++;
            }
            if (sweet == dish.sweet)
            {
                Console.WriteLine("The jury likes the sweetness of the dish.");
                like++;
            }
            if (sour == dish.sour)
            {
                Console.WriteLine("The jury likes the sourness of the dish.");
                like++;
            }
            if (bitter == dish.bitter)
            {
                Console.WriteLine("The jury likes the bitterness of the dish.");
                like++;
            }
            if (umami == dish.umami)
            {
                Console.WriteLine("The jury likes the umami of the dish.");
                like++;
            }

            Console.WriteLine("The jury gives you a " + like + "/5 for your dish");

        }
        
    }
}
