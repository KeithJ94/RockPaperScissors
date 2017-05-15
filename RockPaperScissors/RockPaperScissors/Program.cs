using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] game = { "Rock", "Paper", "Scissors" };


            Console.WriteLine("Enter Rock/Paper/Scissors");
      game: Random rnd = new Random();
            int index = rnd.Next(game.Count());
            var name = game[index];

            string input = Console.ReadLine();
            //Draw
            if((input == "Rock"|| input == "rock") && name == "Rock")
            {
                Console.WriteLine("The Computer chose " + name);
                Console.WriteLine("Pick again");
                goto game;
            }
            else if((input=="Scissors"||input=="scissors") && name == "Scissors")
            {
                Console.WriteLine("The Computer chose " + name);
                Console.WriteLine("Pick again");
                goto game;
            }
            else if ((input == "Paper" || input == "paper") && name == "Paper")
            {
                Console.WriteLine("The Computer chose " + name);
                Console.WriteLine("Pick again");
                goto game;
            }
            //Draw

            //You Win
            if((input == "Rock" || input == "rock") && name == "Scissors")
            {
                Console.WriteLine("The Computer chose " + name);
                Console.WriteLine("You Won Rock beats Scissors");
            }
            else if((input == "Scissors" || input == "scissors") && name == "Paper")
            {
                Console.WriteLine("The Computer chose " + name);
                Console.WriteLine("You Won Scissors beats Paper");
            }
            else if((input == "Paper" || input == "paper") && name == "Rock")
            {
                Console.WriteLine("The Computer chose " + name);
                Console.WriteLine("You Won Paper beats Rock");
            }
            //You Win


            //You Lose
            if (name == "Rock" && (input == "Scissors" || input == "scissors"))
            {
                Console.WriteLine("The Computer chose " + name);
                Console.WriteLine("You Lose Rock beats Scissors");
                Console.WriteLine("Try Again");
                goto game;
            }
            else if(name == "Scissors" && (input == "Paper" || input == "paper"))
            {
                Console.WriteLine("The Computer chose " + name);
                Console.WriteLine("You Lose Scissors beats Paper");
                Console.WriteLine("Try Again");
                goto game;
            }
            else if (name == "Paper" && (input == "Rock" || input == "rock"))
            {
                Console.WriteLine("The Computer chose " + name);
                Console.WriteLine("You Lose Paper beats Rock");
                Console.WriteLine("Try Again");
                goto game;
            }
            //You Lose

        }
    }
}
