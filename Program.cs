using System;

namespace Error
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                 string level;
                Console.WriteLine("Choose a level between Easy,Intermediate and Hard. 1 for easy, 2 for Intermediate, 3 for Hard");
                Console.Write("What level woould you like to play: ");
                var levelchose = int.Parse(Console.ReadLine());
                if (levelchose == 1)
                {
                    level = "Easy";
                }
                else if (levelchose == 2)
                {
                    level = "Intermediate";
                }
                else if (levelchose == 3)
                {
                    level = "Hard";   
                }
                else
                {
                   level = "";
                }
                if (level == "Easy")
                {
                    Game(6,1,10);
                }
                if (level == "Intermediate")
                {
                    Game(4,1,20);
                }
                if (level == "Hard")
                {
                    Game(3,1,50);
                }
            
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + "Chose either 1, 2 or 3.");
            }
        }    
                public static void Game (int trials, int Min, int Max)
                {
                    Random random = new Random();
                    int guess = random.Next(Min,Max);
                    int Trials = 1;
                    Console.Write("Enter a guess: ");
                    int Guess = int.Parse(Console.ReadLine());
                    do
                    {
                        if(Trials == trials)
                        {
                            Console.WriteLine($"Sorry you Loose the number was {guess}");
                            break;
                        }
                        if (Guess != guess)
                        {
                            Console.Write("Sorry, Wrong number, try again: ");
                            Guess = int.Parse(Console.ReadLine());
                            Trials++;
                        }
                        if (Guess == guess)
                        {
                            Console.WriteLine($"Hey you won, the number was {guess}");
                            break;
                        }
                    } while (Guess != guess);
                } 
        
    }
}
