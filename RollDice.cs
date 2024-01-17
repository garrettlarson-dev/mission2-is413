using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2
{
    // Class responsible for simulating dice rolls
    internal class RollDice
    {
        // Fields to store information about the dice rolls
        int totalNumRolls;
        int rollsLeft;
        int dice1;
        int dice2;
        int sum;
        int[] combinations;

        // Constructor to initialize the RollDice object with the total number of rolls
        public RollDice(int numRolls)
        {
            // Initialize array to store combinations and set the total number of rolls
            combinations = new int[11];
            totalNumRolls = numRolls;
            rollsLeft = numRolls;
        }

        // Method to simulate dice rolls and return an array with combinations
        public int[] roll()
        {
            // Create a random number generator
            System.Random random = new System.Random();

            // Simulate dice rolls until there are no rolls left
            while (rollsLeft > 0)
            {
                // Generate random numbers for two dice
                dice1 = random.Next(1, 7);
                dice2 = random.Next(1, 7);

                // Calculate the sum of the two dice
                sum = dice1 + dice2;

                // Increment the corresponding combination in the array
                combinations[sum - 2]++;

                // Decrease the number of rolls left
                rollsLeft--;
            }

            // Return the array containing the combinations of dice rolls
            return combinations;
        }
    }
}
