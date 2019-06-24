﻿using System;

namespace MulticastDelegate
{
    class Program
    {
        static void WriteProgressToConsole(int percentComplete)
        {
            Console.WriteLine(percentComplete);
        }

        static void WriteProgressToFile(int percentComplete)
        {
            System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());
        }

        static void Main(string[] args)
        {
            ProgressReporter p = WriteProgressToConsole;
            p += WriteProgressToFile;
            Util.HardWork(p);
        }
    }

    public delegate void ProgressReporter(int percentComplete);

    public class Util
    {
        public static void HardWork(ProgressReporter p)
        {
            for (int i = 0; i <= 10; i++)
            {
                p(i * 10); // Invoke delegate
                System.Threading.Thread.Sleep(200); // Simulate hard work
            }
        }
    }
}
