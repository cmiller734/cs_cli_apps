using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting program...");
            Q1 q1 = new Q1();
            q1.init();
            Console.WriteLine("--------------------------------");
            Q2 q2 = new Q2();
            q2.init();
            Console.WriteLine("--------------------------------");
            Q3 q3 = new Q3();
            q3.init();
            Console.WriteLine("--------------------------------");
            Console.Write("Program finished!");
        }
    }

