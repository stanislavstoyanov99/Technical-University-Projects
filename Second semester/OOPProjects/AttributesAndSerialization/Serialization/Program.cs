using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormatter formatter = new BinaryFormatter();
            Triangle triangle = new Triangle(4, 5, 10);

            triangle._triangles.Add(triangle);

            using (Stream stream = new FileStream("data.db", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, triangle._triangles);
            }

            using (Stream stream = new FileStream("data.db", FileMode.Open, FileAccess.Read))
            {
                triangle._triangles = (List<Triangle>)formatter.Deserialize(stream);
            }
        }
    }
}
