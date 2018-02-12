//Code has been written to fit the following criteria: Console.Write("*"), Console.Write(" "), Console.WriteLine()
//are used only once. To make this happen I created arrays of strings, each string being either " ", "*". or "**" to denote
//what should be what. If allowed to use unlimited Console.Writes I would write this differently but this is a solution.
using System;
using System.Linq;
using System.Collections.Generic;

public class Q2
{
    public static void logLines(int numLines, bool isRev)
    {
        int minStar = 0;
        int numFinalSpaces = 0;
        int[] numLinesArr = Enumerable.Range(0, numLines).ToArray();
        foreach (int i in numLinesArr)
        {
            List<String> spaceString = new List<String>();
            List<String> starString = new List<String>();
            starString.Add("*");
            List<String> finalString = new List<String>();

            if (isRev)
            {
                spaceString.Add(" ");
                int[] minStarArr = Enumerable.Range(0, minStar).ToArray();
                foreach (int j in minStarArr)
                {
                    spaceString.Add(" ");
                }
                if (i != 0)
                {
                    int[] linesArr = Enumerable.Range(0, numLines).ToArray();
                    foreach (int k in linesArr)
                    {
                        starString.Add("**");
                    }
                }
                finalString.AddRange(spaceString);
                finalString.AddRange(starString);
                finalString.AddRange(spaceString);
                numFinalSpaces++;
                if (i != 0)
                {
                    logLine(finalString);
                }
            } else {
                int [] linesArrAgain = Enumerable.Range(0, numLines).ToArray();
                foreach (int val in linesArrAgain) {
                    spaceString.Add(" ");
                }
                if (i != 0) {
                    int [] anArray = Enumerable.Range(0, minStar).ToArray();
                    foreach (int val in anArray) {
                        starString.Add("**");
                    }
                }
                finalString.AddRange(spaceString);
                finalString.AddRange(starString);
                finalString.AddRange(spaceString);
                logLine(finalString);
            }
            numLines--;
            minStar++;
        }
        if (isRev) {
            List<String> finalSpacesStr = new List<String>();
            finalSpacesStr.Add(" ");
            int [] anArrayTwo = Enumerable.Range(0, numFinalSpaces).ToArray();
            foreach (int val in anArrayTwo) {
                finalSpacesStr.Add(" ");
            }
            finalString = finalSpacesStr;
            
        }
    }

    public static void logLine(List<String> iterable)
    {
        foreach (string value in iterable)
        {
            if (value == " ")
            {
                Console.Write(" "); //Console.Write(" ");
            }
            else
            {
                int numStars = 0;
                if (value == "*")
                {
                    numStars = 1;
                }
                else
                {
                    numStars = numStars + 2;
                }
                int[] numStarsArr = Enumerable.Range(0, numStars).ToArray();
                foreach (int key in numStarsArr)
                {
                    Console.Write("*"); //Console.Write("*");
                }
            }
        }
        Console.WriteLine(); //Console.WriteLine
    }

    public void init()
    {
        logLines(6, false);
        logLines(6, false);
        logLines(5, true);
    }
}


