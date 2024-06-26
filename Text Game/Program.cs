
namespace TextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("click to enter the Game(press Enter)");
            Console.ReadKey();//simulate click to inter the game
            
            Console.WriteLine("choose one of te boxes 1, 2 or 3");
            string choise = Console.ReadLine();//user choose the box

            if (choise == "1")
            {
                Console.WriteLine("how many finger in 2 hand");
                string finger = Console.ReadLine();//user answer the question

                if (finger == "10")
                {
                    Console.WriteLine("correct,how many finger in 10 hands");
                    string fingers = Console.ReadLine();

                    if (fingers == "50")
                    {
                        Console.WriteLine("correct,you Won");
                    }
                    else
                    {
                        Console.WriteLine("Wrong, you lose");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong, you lose");
                }
            }
            else if (choise =="2")
            {
                Console.WriteLine("You are Lucky, you won");
            }
            else if (choise == "3")
            {
                Console.WriteLine("You have a bad Luck, you Lose");
            }
            Console.WriteLine("Game Over");
        }
    }
}


