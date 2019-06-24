using System;
using System.Collections.Generic;
using System.Linq;

namespace CarProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSpeedAutomobile1 = int.Parse(Console.ReadLine());
            int engineCapacityAutomobile1 = int.Parse(Console.ReadLine());
            string brandAutomobile1 = Console.ReadLine();
            string modelAutomobile1 = Console.ReadLine();

            int maxSpeedAutomobile2 = int.Parse(Console.ReadLine());
            int engineCapacityAutomobile2 = int.Parse(Console.ReadLine());
            string brandAutomobile2 = Console.ReadLine();
            string modelAutomobile2 = Console.ReadLine();

            Automobile automobile1 = new Automobile(maxSpeedAutomobile1, engineCapacityAutomobile1, brandAutomobile1, modelAutomobile1);
            Automobile automobile2 = new Automobile(maxSpeedAutomobile2, engineCapacityAutomobile2, brandAutomobile2, modelAutomobile2);

            Console.WriteLine(automobile1.Brand);
            Console.WriteLine(automobile1.Model);
            Console.WriteLine(automobile1.MaxSpeed);
            Console.WriteLine(automobile1.CapacityInKw);
            Console.WriteLine(automobile1.StartEngine());
            Console.WriteLine(automobile1.CurrentSpeed);
            Console.WriteLine(automobile1.Accelerate());
            Console.WriteLine(automobile1.CurrentSpeed);
            Console.WriteLine(automobile1.Brake());
            Console.WriteLine(automobile1.CurrentSpeed);
            Console.WriteLine(automobile1.StopEngine());
            Console.WriteLine(automobile1.CurrentSpeed);

            List<string> shapes = new List<string>();

            shapes.Where(x => x.Describe());
        }
    }
}
