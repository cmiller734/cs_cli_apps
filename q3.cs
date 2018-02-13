using System;
using System.Linq;
using System.Collections.Generic;

public class Q3 //reads input .txt file from same directory it's in
{
    public void init()
    {
        String filePath = "./input_file.txt"; //change this line if input file is elsewhere
        string[] fileLines = returnFileLines(filePath);
        int joinArrLength = parseFile(fileLines).num;
        string[] poundArr = parseFile(fileLines).poundArr;
        Array.Sort(poundArr, StringComparer.InvariantCulture);
        Console.WriteLine(joinArrLength);
        testFile(poundArr);

        /*Random rnd = new Random();
        int maxNumLines = 10; //# strings to display 
        int[] lineArr = Enumerable.Range(0, rnd.Next(2, maxNumLines)).ToArray(); //# of lines of #'s that will be displayed
        int[] joinArr = Enumerable.Range(0, rnd.Next(2, lineArr.Length)).ToArray(); //# of lines of #'s that will be joined
        
        int maxVal = 0;
        int minVal = 0;

        returnStrList(lineArr, rnd);*/

    }
   
    public string[] returnFileLines(String filePath)
    {
        string[] tmpArr;
        try
        {
            tmpArr = System.IO.File.ReadAllLines(@filePath);
        }
        catch (Exception e)
        {
            Console.WriteLine("Could not read file - Error type: " + e.GetType());
            tmpArr = new string[] { };
        }
        return tmpArr;
    }

    public (int num, string[] poundArr) parseFile(string[] fileLines)
    {
        int num = 0;
        List<String> poundList = new List<String>();
        foreach (string i in fileLines)
        {
            if (i.Contains("#"))
            {
                poundList.Add(i);
            }
            else
            {
                num = Int32.Parse(i);
            }
        }
        return (num, poundList.ToArray());
    }

    public void testFile(string[] fileLines)
    {
        foreach (string i in fileLines)
        {
            Console.WriteLine(i);
        }
    }
    /* public static List<String> returnStrList(Array lineArr, Random rnd)
     {
         List<String> poundStrArr = new List<String>();
         int maxPoundNum = 10; //max # of pound chars to join together on a line
         String poundString = "";
         foreach (int a in lineArr)
         {
             int[] tmpArr = Enumerable.Range(0, rnd.Next(1, maxPoundNum)).ToArray();
             foreach (int b in tmpArr)
             {
                 poundString += "#";
             }
         poundStrArr.Add(poundString);
         }
         return poundStrArr;
     }*/
}

