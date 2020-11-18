using System;
using System.Collections.Generic;


namespace Novemberprojekt
{
    public class Ingredient: Stats
    {

        
        private List<string> ingredientName = new List<string>() {"beef", "pork", "chicken", "rice", "pasta", "potato", "union"};
        

        private int i;

        

        public string GetIngredient()
        {

            i = generator.Next(0, ingredientName.Count);

            IngredientValue();

            return ingredientName[i];

        }

        private void IngredientValue()
        {

            salty = generator.Next(0, 1);
            sweet = generator.Next(0, 1);
            sour = generator.Next(0, 1);
            bitter = generator.Next(0, 1);
            umami = generator.Next(0, 1);
            
        }


    }
}
