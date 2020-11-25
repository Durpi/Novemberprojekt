using System;
using System.Threading;

namespace Novemberprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingredient ingredient = new Ingredient();
            Jury jury = new Jury();
            
            bool play = true;

            
            while (play == true)
            {
                

                Console.WriteLine("Welcome to Master Chef!");
                Sleep();
                Console.Clear();
                Console.WriteLine("You will pick an ingredient that you like to have in your dish" +
                "\nThis ingredient will have a random taste" +
                "\nand if your lucky the jury will like the dish you made");


            }


            


            

            Console.ReadLine();
            
        }


        private static void Sleep()
        {

            Thread.Sleep(2000);



        }
    }
}
