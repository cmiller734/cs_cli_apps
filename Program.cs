using System;

namespace explorica
{
    class Program
    {
        private static int minStar = 0;
        private static int[] minStarArr = new int[minStar];
        private static int numLines = 6;
        private static int[] linesArr = new int[numLines];
        private static string spaceString = "";
        private static string starString = "*";
        private static string finalString = "";
        static void Main(string[] args)
        {
            Console.WriteLine("Starting program...");
        }
        public void function()
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
        Program prog = new Program();
        Program.function();
    }
}

