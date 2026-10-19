namespace Topics_7_1___Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            bool done = false;
            string playerChoice, quitChoice, cpuChoice;
            int chips = 50, bet, cpuChoiceNum;
            int rock = 1, paper = 2, scissors = 3;

            Console.WriteLine("Welcome to: ROCK, PAPER, SCISSORS!");
            Console.WriteLine("If you somehow don't know what Rock Paper Scissors is, then go find out and then return!");
            Console.WriteLine();
            Console.WriteLine("We'll give you 50 chips to start! On the house!");
            Console.WriteLine();
            while (!done)
            {
                Console.WriteLine("You have " + chips + " chips!");
                Console.WriteLine();
                Console.Write("Your bet is: ");
                while (!Int32.TryParse(Console.ReadLine(), out bet) || bet <= 0 || bet > chips)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid bet. Please type another bet. ");
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("You've made a bet of " + bet + "! Now, you gotta choose rock (type \"rock\"), paper (type \"paper\"), or scissors (type \"scissors\")!");
                Console.WriteLine();
                playerChoice = Console.ReadLine();
                while (playerChoice.ToLower() != "rock" && playerChoice.ToLower() != "paper" && playerChoice.ToLower() != "scissors")
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice. Please choose again.");
                    Console.WriteLine();
                    playerChoice = Console.ReadLine();

                }
                if (playerChoice.ToLower() == "rock")
                {
                    Console.WriteLine();
                    Console.WriteLine("You've chosen... rock!");
                    Console.WriteLine();
                }
                else if (playerChoice.ToLower() == "paper")
                {
                    Console.WriteLine();
                    Console.WriteLine("You've chosen... paper!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You've chosen... scissors!");
                    Console.WriteLine();
                }

                cpuChoiceNum = generator.Next(1, 4);

                if (cpuChoiceNum == rock)
                {
                    cpuChoice = "rock";
                }
                else if (cpuChoiceNum == paper)
                {
                    cpuChoice = "paper";
                }
                else
                {
                    cpuChoice = "scissors";
                }


                if (cpuChoice == "rock")
                {
                    Console.WriteLine("The dealer has chosen... rock!");
                    Console.WriteLine();
                }
                else if (cpuChoice == "paper")
                {
                    Console.WriteLine("The dealer has chosen... paper!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The dealer has chosen... scissors!");
                    Console.WriteLine();
                }
                if (playerChoice == "rock" && cpuChoice == "scissors" || playerChoice == "paper" && cpuChoice == "rock" || playerChoice == "scissors" && cpuChoice == "paper")
                {
                    Console.WriteLine("You won! You get " + bet + " chips!");
                    chips = chips + bet;
                    Console.WriteLine();
                }
                else if (playerChoice == "rock" && cpuChoice == "paper" || playerChoice == "paper" && cpuChoice == "scissors" || playerChoice == "scissors" && cpuChoice == "rock")
                {
                    Console.WriteLine("You lose! You lose " + bet + " chips!");
                    chips = chips - bet;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Ooh! It's a tie! Go again!");
                    Console.WriteLine();
                }
                Console.WriteLine("Do you wish to quit? (Yes or No)");
                Console.WriteLine();
                quitChoice = Console.ReadLine();
                while (quitChoice.ToLower() != "yes" && quitChoice.ToLower() != "no")
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice. Please choose again.");
                    Console.WriteLine();
                    quitChoice = Console.ReadLine();


                }
                if (quitChoice == "yes")
                {
                    Console.WriteLine();
                    Console.WriteLine("Awh! Thats too bad! See ya!");
                    done = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("That's great! Let's continue!");
                    Console.WriteLine();
                }
                if (chips <= 0)
                {
                    Console.WriteLine("Oof! You're outta chips! See ya!");
                    done = true;
                }
            }
            Console.WriteLine("Come again soon!");
            Console.WriteLine("(Restart the program to play again.)");
        }
    }
}