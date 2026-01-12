// Madison Diefenbach 
// Dice Simulator Assignment

using System; 

namespace DiceSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate?");

            int numRolls;
            while (!int.TryParse(Console.ReadLine(), out numRolls) || numRolls <= 0)
            {
                Console.Write("Please enter a positive whole number: ");
            }

            DiceRoller roller = new DiceRoller();
            int[] results = roller.RollDice(numRolls);

            Console.WriteLine();
            Console.WriteLine("Dice Rolling Simulation Results");
            Console.WriteLine("Each \"*\" represets 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numRolls}.");
            Console.WriteLine();

            for (int sum = 2; sum <= 12; sum ++)
            {
                int count = results[sum];
                double percentage = (count / (double)numRolls) * 100;

                // 1 star per 1%
                int stars = (int)Math.Round(percentage, MidpointRounding.AwayFromZero);

                Console.Write($"{sum}: ");
                Console.WriteLine(new string('*', stars));
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        }
    }
}