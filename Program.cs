using mission2;

internal class Program
{
    private static void Main(string[] args)
    {
        // Welcome message
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?: ");

        // Get user input for the number of dice rolls
        int numRolls = int.Parse(System.Console.ReadLine());
        RollDice rd = new RollDice(numRolls);
        int[] results = rd.roll();

        // Display simulation results header
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + numRolls);

        // Display results with percentage representation using '*' characters
        for (int i = 0; i < results.Length - 1; i++)
        {
            string stars = "";

            // Calculate the percentage for each result
            float percentageToAdd = ((float)results[i] / numRolls) * 100;

            // Generate a string of '*' characters based on the calculated percentage
            for (int j = 0; j < percentageToAdd; j++)
            {
                stars += "*";
            }

            // Format and display the result with percentage and '*' representation
            string percentageString = percentageToAdd.ToString("0.0");

            if ((i + 2) < 10)
            {
                System.Console.WriteLine("(" + percentageString + "%)\t" + " " + (i + 2) + ": " + stars);
            }
            else
            {
                System.Console.WriteLine("(" + percentageString + "%)\t" + (i + 2) + ": " + stars);
            }
        }

        // Farewell message
        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}
