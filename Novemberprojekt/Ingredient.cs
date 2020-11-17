using System;
using System.Collections.Generic;


namespace Novemberprojekt
{
    public class Ingredient
    {

        private static Random generator = new Random();
        private List<string> ingredientName = new List<string>() {"beef", "pork", "chicken", "rice", "pasta", "potato", "union"};
        private int salty;
        private int sweet;
        private int bitter;
        private int sour;
        private int umami;

        private int i;

        

        public string GetIngredient()
        {

            i = generator.Next(0, ingredientName.Count);

            return ingredientName[i];

        }

        public void IngredientValue()
        {
            
        }


    }
}
