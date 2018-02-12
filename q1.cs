using System;
using System.Linq;

public class Q1
{
    public void init()
    {
        int[] arr = Enumerable.Range(0, 100).ToArray();
        foreach (int i in arr)
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


