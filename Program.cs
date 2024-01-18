using Mission2_DiceRoll;
using System;

// Patrick Nieves - Dice Roll Simulator
// class for outputting and receiving input; as shown in Crash Course videos
internal class Program
{
    public static void Main()
    {
        //interact with user to display game and receive input
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n");

        System.Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        //declare DiceSimulator.cs class in Program.cs and pass numberOfRolls
        DiceSimulator ds = new DiceSimulator(numberOfRolls);

        //call GetResults function from DiceSimulator.cs
        int[] DiceResult = ds.GetResults();

        //write game info
        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");

        //adjusts for the 2 subtraction from adding the dice roll results and display numberOfRolls
        int totalRolls = DiceResult.Length - 2;
        System.Console.WriteLine($"Total number of rolls = {numberOfRolls}.\n");

        //iterate through and perform output calculation
        for (int i = 0; i < DiceResult.Length; i++)
        {
            int percentage = (int)DiceResult[i] * 100 / numberOfRolls;
            string asterisks = new string('*', percentage);
            System.Console.WriteLine($"{i + 2}: {asterisks}");
        }

        //final output concluding the dice rolling
        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}

