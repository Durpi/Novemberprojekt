using System;

namespace Novemberprojekt
{
    public class Stats
    {
        //Makes the variables that "Dish" and "Jury" both use

        //Static because of not wanting the same number generated
        public static Random generator = new Random();
        
        public int salty;
        public int sweet;
        public int bitter;
        public int sour;
        public int umami;
    }
}
