using System;

namespace exceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FuncaDoodleDoo());
        }
        static int FuncaDoodleDoo()
        {
            int num = 0;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    if (i == 1)
                    {
                        continue;
                    }
                    if (i == 2)
                    {
                        throw new Exception();
                    }
                    if (i == 3)
                    {
                        break;
                    }
                }
                catch
                {
                    num--;
                }
                finally
                {
                    num++; // 1 2 1 2 3 4
                }
                num++; // 2
            }
            return num; // num = ?
        }
    }
}
