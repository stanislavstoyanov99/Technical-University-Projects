using System;

class Program
{
    public struct Person
    {
        public string name;
        public int identifyNumber;
    }
    static void Main(string[] args)
    {
        Person[] people = new Person[3];
        for (int i = 1; i <= 3; i++)

        {
            people[i].name = Console.ReadLine();
            people[i].identifyNumber = int.Parse(Console.ReadLine());
        }
    }
}
