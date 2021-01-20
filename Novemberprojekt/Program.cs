using System;
using System.Threading;

namespace Novemberprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //I use a bool to continue the game loop
            bool play = true;

            //A while loop to let the player decide if they want to play again
            while (play == true)
            {
                
                //I take in the classes here to reset the Jury constructor after each playthrough
                //The Dish class takes in here to keep the classes together
                Jury jury = new Jury();
                Dish dish = new Dish();

                

                Console.WriteLine("Welcome to Master Chef!");

                Sleep(3000);
                
                Console.WriteLine("You will get a dish to make" +
                "\nThis dish will have a random taste" +
                "\nand if you're lucky the jury will like the dish you made");

                Sleep(10000);

                //Runs the GetDish() and writes the text it returns
                Console.WriteLine("You decided to make a " + dish.GetDish() + "! Let's hope the jury likes it");

                Sleep(4000);

                //Runs JuryJudment()
                jury.JuryJudment(dish);


                Sleep(10000);

                //Play again or not
                Console.WriteLine("Would you like to try and impress the jury again?" +
                "\n[yes] or [no]");

                string playAgainAns = Console.ReadLine().ToLower();

                //So they can only continue if they write yes or no
                while (playAgainAns != "yes" && playAgainAns != "no")
                {
                    Console.Clear();
                    Console.WriteLine("Would you like to try and impress the jury again?" +
                    "\n[yes] or [no]");
                    playAgainAns = Console.ReadLine().ToLower();
                }

                //Determines if the Play loop continues
                if (playAgainAns == "yes")
                {
                    Console.WriteLine("Then let's go again");
                    Sleep(2000);
                }
                else if (playAgainAns == "no")
                {
                    Console.WriteLine("Hope you come again!");
                    Sleep(2000);
                    play = false;

                }



            }

            

            
            
        }


        //I need to put this a lot in my code so i put it together
        //Takes in how long the sleep will be
        private static void Sleep(int i)
        {

            Thread.Sleep(i);
            Console.Clear();



        }
    }
}
