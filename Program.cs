using mission2;

internal class Program
{
    private static void Main(string[] args) 
    {
        

        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would like to simulate?: ");

        int numRolls = int.Parse(System.Console.ReadLine());
        RollDice rd = new RollDice(numRolls);
        int[] results = rd.roll();

        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each '*' represents 1% of the total numer of rolls.");
        System.Console.WriteLine("Total number of rolls = " + numRolls);

        for (int i = 0; i < results.Length - 1; i++)
        {
            string stars = "";
            float percentageToAdd = ((float)results[i] / numRolls) * 100;
            for (int j = 0; j < percentageToAdd; j++)
            {
                stars += "*";
            }

            string percentageString = percentageToAdd.ToString("0.0"); // Format the percentage with two decimal places

            if ((i+2) < 10)
            {
                System.Console.WriteLine("(" + percentageString + "%)\t" + " " + (i + 2) + ": " + stars);
            }
            else
            {
                System.Console.WriteLine("(" + percentageString + "%)\t" + (i + 2) + ": " + stars);
            }
        }
        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");


    }
}