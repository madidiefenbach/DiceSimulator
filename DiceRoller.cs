using System;

namespace DiceSimulator
{
    public class DiceRoller
    {
        private readonly Random _random = new Random();
        // This method simulates rolling two dice numRolls times
        // and returns an array where indexes 2..12 store counts.
        public int[] RollDice(int numRolls)
        {
            int[] results = new int[13]; // 0...12
            
            for (int i = 0; i < numRolls; i++)
            {
                int die1 = _random.Next(1, 7); // 1-6
                int die2 = _random.Next(1, 7); // 1-6
                int sum = die1 + die2;

                results[sum]++;
            }
            return results;
        }
    }
}
