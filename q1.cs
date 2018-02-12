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
                Console.WriteLine("Explorica Tours");
            }
            else
            {
                if (isMultipleThree)
                {
                    Console.WriteLine("Explorica");
                }
                else
                {
                    if (isMultipleFive)
                    {
                        Console.WriteLine("Tours");
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


