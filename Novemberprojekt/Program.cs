using System;
using System.Threading;

namespace Novemberprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Dish dish = new Dish();
            Jury jury = new Jury();
            
            bool play = true;

            
            while (play == true)
            {
                

                Console.WriteLine("Welcome to Master Chef!");

                Sleep(3000);
                
                Console.WriteLine("You will get a dish to make" +
                "\nThis dish will have a random taste" +
                "\nand if you're lucky the jury will like the dish you made");

                Sleep(10000);

                Console.WriteLine("You decided to make a " + dish.GetDish() + "! Let's hope the jury likes it");

                Sleep(4000);

                jury.JuryJudment();


                Sleep(10000);

                Console.WriteLine("Would you like to try and impress the jury again?" +
                "\n[yes] or [no]");

                string playAgainAns = Console.ReadLine().ToLower();

                while (playAgainAns != "yes" && playAgainAns != "no")
                {
                    Console.Clear();
                    Console.WriteLine("Would you like to try and impress the jury again?" +
                    "\n[yes] or [no]");
                    playAgainAns = Console.ReadLine().ToLower();
                }

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


            


            

            Console.ReadLine();
            
        }


        private static void Sleep(int i)
        {

            Thread.Sleep(i);
            Console.Clear();



        }
    }
}
