using System;
using System.Collections.Generic;


namespace Novemberprojekt
{
    //Inherits the traits from "Stats"
    public class Dish: Stats
    {

        //List of potential dishes
        private List<string> dishName = new List<string>() {"beef soup", "pork soup", "chicken soup", "rice soup", "pasta soup", "potato soup", "bacon soup"};
        
        //I keep track of all variables by putting them on the top
        private int i;

        
        //The function picks a random dish from "dishName" and returns it
        //It also runs "DishValue" to reset it's values when a new dish gets made
        public string GetDish()
        {

            i = generator.Next(0, dishName.Count);

            DishValue();

            return dishName[i];

        }

        //Generates the tastes of the dish
        private void DishValue()
        {

            salty = generator.Next(0, 2);
            sweet = generator.Next(0, 2);
            sour = generator.Next(0, 2);
            bitter = generator.Next(0, 2);
            umami = generator.Next(0, 2);
            
        }


    }
}
