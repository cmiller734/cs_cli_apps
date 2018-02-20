//Draws a series of patterns using Console.Write("*"), Console.Write(" "), and Console.WriteLine() only once.

using System;
using System.Linq;

public class Q2
{
    public void init()
    {
        buildStruct(Enumerable.Range(0, 6).ToArray());
        buildStruct(Enumerable.Range(0, 11).ToArray());
    }

    public static void buildStruct(Array numLinesArr)
    {
        int revLine = 5;
        int numSpaces = 10;
        int numStars = 1;
        foreach (int i in numLinesArr)
        {
            int[] numSpacesArr = Enumerable.Range(0, numSpaces).ToArray();
            foreach (int j in numSpacesArr)
            {
                Console.Write(" ");
            }
            int[] numStarsArr = Enumerable.Range(0, numStars).ToArray();
            foreach (int k in numStarsArr)
            {
                Console.Write("*");
            }
            if (i < revLine)
            {
                numSpaces--;
                numStars = numStars + 2;
            }
            else
            {
                numSpaces++;
                numStars = numStars - 2;
            }
            Console.WriteLine();
        }
    }
}

