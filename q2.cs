using System;

public class Q2
{
    private static int minStar = 0;
    private static int numLines = 6;
    private string spaceString = "";
    private string finalString = "";
    private string starString = "*";

    private int[] minStarArr = new int[minStar];
    private int[] linesArr = new int[numLines]; 

    public void init()
    {
        foreach (int i in linesArr)
        {
            foreach (int j in linesArr)
            {
                spaceString += " ";
            }
            if (i != 0)
            {
                foreach (int a in minStarArr)
                {
                    starString += "**";
                }
            }
            finalString = spaceString + starString + spaceString;
            Console.Write(finalString);
            numLines--;
            minStar++;
        }
    }
}


