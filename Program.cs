using System;

namespace explorica
{
    public class Program
    {
        private static int minStar = 0;
        private static int[] minStarArr = new int[minStar];
        private static int numLines = 6;
        private static int[] linesArr = new int[numLines];
        private static string spaceString = "";
        private static string starString = "*";
        private static string finalString = "";
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting program...");
            
            Program prog = new Program();
            
            Program2 prog2 = new Program2(); 
            if(prog2 != null)
            {
                
            }
        }
        public void MyFunction()
        {
            foreach (int i in linesArr)
            {
                foreach (int j in linesArr)
                {
                    spaceString += " ";
                }// linesArr loop
                if (i != 0)
                {
                    foreach (int a in minStarArr)
                    {
                        starString += "**";
                    }// minStarArr loop
                }// 1 != 0 check
                finalString = spaceString + starString + spaceString;
                Console.Write(finalString);
                numLines--;
                minStar++;
            }
        }
    }
}

