//Prints the numbers 1-100. For multiples of 3, prints 'cli_apps' instead of the number. For multiples of 5, prints 'C#' instead of the number.
//For multiples of both 3 and 5, prints 'cli_apps C#'.

using System;
using System.Linq;

public class Q1
{
    public void init()
    {
        int[] intArr = Enumerable.Range(0, 100).ToArray();
        foreach (int i in intArr)
        {
            bool isMultipleThree = i % 3 == 0;
            bool isMultipleFive = i % 5 == 0;
            if (isMultipleThree && isMultipleFive)
            {
                Console.WriteLine("cli_apps C#");
            }
            else
            {
                if (isMultipleThree)
                {
                    Console.WriteLine("cli_apps");
                }
                else
                {
                    if (isMultipleFive)
                    {
                        Console.WriteLine("C#");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}


