using Mission2;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    private static void Main()
    {
        DiceRoll dr = new DiceRoll(); // diceroll constructor
        
        // starting input (how many dice rolls do you want)
        System.Console.WriteLine("Welcome to the dice throwing simulator!\r\nHow many dice rolls would you like to simulate?: ");
        string input = System.Console.ReadLine();

        // converts the input into a variable called numRolls of type int
        if (int.TryParse(input, out int numRolls))
        {
            System.Console.WriteLine($"You entered {numRolls} rolls.");
            int[] results = dr.Roll(numRolls); // an int array called results that takes what the Roll method returns

            for (int i = 0; i < results.Length; i++) // for loop to loop through each element in the array
            {
                if (results[i] > 0)
                {
                    // percentage calculation
                    double percentage = ((double)results[i] / numRolls) * 100;
                    Console.Write($"{i + 2}: ");

                    // printing out the stars
                    for (int j = 0; j < Math.Round(percentage); j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(); // next line down
                }
            }
        }
        else
        {
            // error handling
            System.Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        // closing statement
        System.Console.WriteLine("\nThanks for rolling the dice! See ya!");
    }
}