using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2
{
    internal class RollDice
    {
        int totalNumRolls;
        int rollsLeft;
        int dice1;
        int dice2;
        int sum;
        int[] combinations;

        public RollDice(int numRolls) {
            combinations = new int[11];
            totalNumRolls = numRolls;
            rollsLeft = numRolls;
        }
        public int[] roll()
        {
            System.Random random = new System.Random();

            while (rollsLeft > 0)
            {
                dice1 = random.Next(1, 7);
                dice2 = random.Next(1, 7);
                sum = dice1 + dice2;

                /* Console.WriteLine("Dice sum is " + sum); */

                combinations[sum - 2]++;

                /* for (int i = 0; i < combinations.Length; i++)
                {
                    Console.WriteLine(combinations[i]);
                }
                 */
                rollsLeft--;
            }

            return combinations;

        }
    }
}
