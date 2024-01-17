using System;

// Patrick Nieves - Dice Roll Simulator
// declare class containing array declaration and dice roll simulation methods
internal class DiceSimulator
{
    private int[] DiceResult;

    public DiceSimulator(int numberOfRolls)
    {
        DiceResult = new int[11];
        SimulateRolls(numberOfRolls);
    }

    //roll the dice method
    private void SimulateRolls(int numberOfRolls)
    {
        Random random = new Random();

        //for loop to roll the dice for the user inputted number of rolls
        for (int i = 0; i < numberOfRolls; i++)
        {
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;

            // store roll result in the DiceResult array; subtract 2 to maintain in the limits of the array
            DiceResult[sum - 2]++;
        }
    }

    public int[] GetResults()
    {
        return DiceResult;
    }
}
//class for outputting and receiving input; as shown in Crash Course videos
internal class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n");

        System.Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        DiceSimulator ds = new DiceSimulator(numberOfRolls);
        int[] DiceResult = ds.GetResults();

        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");

        int totalRolls = DiceResult.Length - 2;
        System.Console.WriteLine($"Total number of rolls = {numberOfRolls}.\n");

        for (int i = 0; i < DiceResult.Length; i++)
        {
            int percentage = DiceResult[i] * 100 / numberOfRolls;
            string asterisks = new string('*', percentage);
            System.Console.WriteLine($"{i + 2}: {asterisks}");
        }

        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}

