//Using a given input file structure, determines the minimum and maximum length of N number of '#' strings joined together. N is the number at the top of input_file.txt in root dir.

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class Q3 //reads input .txt file from same directory it's in
{
    public void init()
    {
        int minVal = 0;
        int maxVal = 0;
        string[] fileLines = returnFileLines("./input_file.txt"); //change this line if input file is elsewhere
        int[] joinArr = new int[parseFile(fileLines).num];
        string[] poundArr = parseFile(fileLines).poundArr;
        Array.Sort(poundArr);
        for (int a = 0; a < joinArr.Length; a++)
        {
            minVal += poundArr[a].Length;
            maxVal += poundArr[(poundArr.Length - a) - 1].Length;
        }
        Console.WriteLine("Min: " + minVal + " | " + "Max: " + maxVal);
    }
   
    public string[] returnFileLines(String filePath)
    {
        string[] tmpArr;
        try
        {
            tmpArr = System.IO.File.ReadAllLines(@filePath);
        }
        catch (IOException e)
        {
            Console.WriteLine("File Read Error: ");
            throw e;
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
                if (int.TryParse(i, out int temp))
                {
                    num = temp;
                } else {
                    Console.WriteLine("File Parsing Error: ");
                    throw new InvalidCastException();
                }
            }
        }
        return (num, poundList.ToArray());
    }
}

