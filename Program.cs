using Mission2;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    private static void Main()
    {
        DiceRoll dr = new DiceRoll();
        System.Console.WriteLine("Welcome to the dice throwing simulator!\r\nHow many dice rolls would you like to simulate?: ");
        string input = System.Console.ReadLine();

        if (int.TryParse(input, out int numRolls))
        {
            System.Console.WriteLine($"You entered {numRolls} rolls.");
            int[] results = dr.Roll(numRolls); 

            for (int i = 0; i < results.Length; i++) 
            {
                if (results[i] > 0)
                {
                    double percentage = ((double)results[i]/numRolls)*100;
                    double rounded = Math.Round((double)results[i]);

                    Console.Write($"{i + 2}: ");

                    for (int j = 0; percentage > j; j++)
                    {
                        Console.Write("*");
                    }
                Console.WriteLine();
                }
            }
        }
        else
        {
            System.Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        System.Console.WriteLine("\nThanks for rolling the dice! See ya!");
    }
}