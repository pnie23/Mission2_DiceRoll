using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2_DiceRoll
{
    // declare class containing array declaration and dice roll simulation methods
    internal class DiceSimulator
    {
        //declare array of integers called DiceResult
        private int[] DiceResult;

        //declare method for storing numberOfRolls into DiceResult
        public DiceSimulator(int numberOfRolls)
        {
            DiceResult = new int[11];
            
            //call the simulaterolls method to begin rolling the dice
            SimulateRolls(numberOfRolls);
        }

        //roll the dice method
        private void SimulateRolls(int numberOfRolls)
        {
            Random random = new Random();

            //for loop to roll the dice for the user inputted number of rolls
            for (int i = 0; i < numberOfRolls; i++)
            {
                //roll a random number between 1 and 6
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;

                // store roll result in the DiceResult array; subtract 2 to make sure the array always starts the indexing from 0
                DiceResult[sum - 2]++;
            }
        }

        //method for gathering dice roll results and return DiceResult to methods that call this method
        public int[] GetResults()
        {
            return DiceResult;
        }
    }
}
