namespace TelephoneCatalogue
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var contacts = new Tuple<string, string>[100];
            int contactsCount = 0;

            bool run = true;

            while (run)
            {
                switch (Console.ReadKey().KeyChar)
                {
                    case 'a':
                        Console.Clear();
                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Num: ");
                        string number = Console.ReadLine();
                        AddTelephoneNumber(contacts, ref contactsCount, name, number);
                        break;
                    case 'f':
                        Console.Clear();
                        string nameToFind = Console.ReadLine();

                        int i = FindTelephoneNumber(contacts, contactsCount, nameToFind);

                        if (i != -1)
                        {
                            Console.WriteLine(contacts[i].Item1 + ": " + contacts[i].Item2);
                        }

                        Console.ReadKey();
                        break;
                    case 'q':
                        run = false;
                        break;
                }
            }
        }

        private static int FindTelephoneNumber(Tuple<string, string>[] contacts, int contactsCount, string nameToFind)
        {
            int minNum = 0;
            int maxNum = contacts.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;

                if (CompareNames(contacts[mid].Item1, nameToFind) < 0)
                {
                    minNum = mid + 1;
                }
                else if (CompareNames(contacts[mid].Item1, nameToFind) > 0)
                {
                    maxNum = mid - 1;
                }
                else
                {
                    //
                }
            }

            return -1;
        }

        private static void AddTelephoneNumber(Tuple<string, string>[] contacts, ref int contactsCount, string name, string number)
        {
            contacts[contactsCount++] = new Tuple<string, string>(name, number);
        }

        private static int CompareNames(string firstName, string secondName)
        {
            if (firstName == secondName)
            {
                return 0;
            }
            else if (firstName.Length == 0 && secondName.Length > 0)
            {
                return 1;
            }
            else if (firstName.Length > 0 && secondName.Length == 0)
            {
                return -1;
            }

            // Check the first letter of names whether are equal or not
            if (firstName[0] == secondName[0])
            {
                return CompareNames(firstName.Substring(1), secondName.Substring(1));
            }
            else
            {
                return firstName[0] > secondName[0] ? 1 : -1;
            }
        }
    }
}
