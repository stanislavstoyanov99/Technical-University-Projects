using System;
using System.IO;

namespace FileStreamExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("test.txt", FileMode.Open);

            for (int i = 0; i < stream.Length; i++)
            {
                char ch = (char)stream.ReadByte();
                if (ch == 'a')
                {
                    stream.Position--;
                    stream.WriteByte((byte)'_');
                }
            }

            stream.Close();
        }
    }
}
