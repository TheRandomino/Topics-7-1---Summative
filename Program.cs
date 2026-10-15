namespace Topics_7_1___Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            bool done = false;
            string playerChoice, quitYesNo, cpuChoice;
            int chips = 50, bet, cpuChoiceNum;


            Console.WriteLine("Welcome to: ROCK, PAPER, SCISSORS!");
            Console.WriteLine("If you somehow don't know what Rock Paper Scissors is, then go find out and then return!");
            Console.WriteLine();
            Console.WriteLine("We'll give you 50 chips to start! On the house!");
            Console.WriteLine();
            while (!done)
            {
                Console.Write("Your bet: ");
                while (!Int32.TryParse(Console.ReadLine(), out bet) || bet <= 0 || bet > chips )
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid bet. Please type another bet. ");
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("You've made a bet of " + bet + "! Now, you gotta choose rock (type \"r\"), paper (type \"p\"), or scissors (type \"s\")!");



            }
        }
    }
}