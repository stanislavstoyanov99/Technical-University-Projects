using System;
using System.IO;
using System.Text;

namespace telephoneCatalogue
{
    struct Phone
    {
        public string name;
        public byte model;
    }
    class Program
    {
        public readonly int CATALOG_SIZE = 9;

        static void Main(string[] args)
        {
            char command;
            CreateCatalogIfNotExists(); //c

            do
            {
                Console.Clear();

                Console.Write("Enter command (n - new, g - get, q - quit: ");
                command = Console.ReadKey().KeyChar;

                Console.Clear();

                int position;
                Phone phone = new Phone();

                switch (command)
                {
                    case 'n':
                        Console.Write("Phone position: ");
                        position = int.Parse(Console.ReadLine());

                        Console.Write("Phone name: ");
                        phone.name = Console.ReadLine();

                        Console.Write("Phone model: ");
                        phone.model = byte.Parse(Console.ReadLine());

                        StorePhone(position, phone);

                        break;
                    case 'g':
                        Console.Write("Phone position: ");
                        position = int.Parse(Console.ReadLine());

                        phone = GetPhone(position);

                        Console.WriteLine("Phone name: " + phone.name);
                        Console.WriteLine("Phone model: " + phone.model);

                        Console.Write("Press any key to continue ...");
                        Console.ReadKey();

                        break;
                }
            }
            while (command != 'q');
        }

        public static void CreateCatalogIfNotExists (int phoneCount)
        {
            if (File.Exists("file.txt"))
            {
                return;
            }

            FileStream file = new FileStream("file.txt", FileMode.Create);
            using (file)
            {
                int catalogSize = phoneCount * (15 + 1); // PHONE_SIZE + MODEL_SIZE
                var array = new byte[catalogSize]; // contains 0 in this array
                file.Write(array, 0, array.Length);
            }
        }

        public static void StorePhone (int position, Phone phone)
        {
            FileStream file = new FileStream("file.txt", FileMode.Create);

            using (file)
            {
                file.Position = position * 16; // PHONE_SIZE + MODEL_SIZE

                byte[] nameBuffer = Encoding.UTF8.GetBytes(phone.name);
                byte[] nameBufferFixed = new byte[15];

                for (int i = 0; i < nameBuffer.Length && i < nameBufferFixed.Length; i++)
                {
                    nameBufferFixed[i] = nameBuffer[i];
                }

                file.Write(nameBufferFixed, 0, 15);
                file.Write(new byte[] { phone.model }, 0, 15);
            }
        }

        public static Phone GetPhone(int position)
        {
            Phone phone;
            FileStream file = new FileStream("file.txt", FileMode.Create);

            using (file)
            {
                file.Position = position * 16; // PHONE_SIZE + MODEL_SIZE

                byte[] nameBuffer = new byte[NAME_SIZE];
                byte[] modelBuffer = new byte[15]; // MODEL_SIZE

                file.Read(nameBuffer, 0, NAME_SIZE);
                file.Read(modelBuffer, 0, 15); // MODEL_SIZE

                phone.name = Encoding.UTF8.GetString(nameBuffer);
                phone.model = modelBuffer[0];
            }

            return phone;
        }
    }
}
