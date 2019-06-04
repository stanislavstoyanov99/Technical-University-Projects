//using System;
//using System.IO;
//using System.Linq;

//namespace MinMaxValue
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Iterative way
//            StreamReader reader = new StreamReader("file.txt");

//            using (reader)
//            {
//                int max = int.MinValue;
//                int min = int.MaxValue;

//                string line;
//                while ((line = reader.ReadLine()) != null)
//                {
//                    var element = line?.Split(new String[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse) ?? new int[] { };

//                    foreach (var number in element)
//                    {
//                        if (number > max)
//                        {
//                            max = number;
//                        }

//                        if (number < min)
//                        {
//                            min = number;
//                        }
//                    }
//                }

//                Console.WriteLine("The biggest element is: {0}", max);
//                Console.WriteLine("The smallest element is: {0}", min);
//            }
//        }
//    }
//}

using System;
using System.IO;
using System.Linq;

namespace MinMaxValue
{
    class Program
    {
        static double[] max = new double[] { 0, 0, 0 };
        static int counter = 0;

        static void Main(string[] args)
        {
            //Recursion way
            StreamReader reader = new StreamReader("file.txt");

            using (reader)
            {

                //int min = int.MaxValue;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    var element = line?.Split(new String[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse) ?? new int[] { };

                    int i = 0;
                    max[counter] = MaxValue(element.OfType<double>().ToArray(), i);

                    Console.WriteLine("The biggest element is: {0}", max[counter]);


                    counter++;
                }
                //foreach (var number in element)
                //{
                    //if (number > max)
                    //{
                    //    max = number;
                    //}

                    //if (number < min)
                    //{
                    //    min = number;
                    //}
                //}

                
                //Console.WriteLine("The smallest element is: {0}", min);
            }
        }
        static double MaxValue(double[] arr, int i)
        {
            if (i == arr.Length)
            {
                return max[counter];
            }
            if (arr[i] > max[counter])
            {
                max[counter] = arr[i];
                return MaxValue(arr, i + 1);
            }
            else
            {
                return max[counter];
            }
        }
    }
}
