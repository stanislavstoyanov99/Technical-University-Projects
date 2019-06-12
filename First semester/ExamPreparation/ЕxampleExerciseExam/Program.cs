using System;
using System.IO;

namespace ЕxampleExerciseExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\ТУ - програмиране\\ExamPreparation\\ЕxampleExerciseExam\\bin\\Debug\\file.txt";
            string [] file = File.ReadAllLines(path);

            int[,] array = new int[3, 3];
            int n, k, v = -1;

            for (int i = 0; i < file.Length; i++)
            {
                string text = "";
                for (int j = 0; j < file[i].Length; j++)
                {
                    if (file[i][j].ToString() == Environment.NewLine)
                    {
                        break;
                    }
                    if (file[i][j] != '\t')
                    {
                        text += file[i][j];
                    }
                    else
                    {
                        if (n == -1)
                        {
                            n = int.Parse(text);
                        }
                        else if (k == -1)
                        {
                            k = int.Parse(text);
                        }
                        else
                        {
                            v = int.Parse(text);
                        }
                        text = "";
                    }
                }
            }
            array[n, k] = v;

            // string [] nums = s[i].Split("\t");
            // n = int.Parse(nums[0]);
        }
    }
}
