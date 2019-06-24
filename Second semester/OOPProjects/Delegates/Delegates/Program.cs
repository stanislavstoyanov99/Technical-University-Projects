using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new EventExample();
            obj.OnPrinting += PrintingHandler;
            obj.Print("Hello, world!");
        }

        static void PrintingHandler(string s)
        {
            Console.WriteLine("OnPrinting called");
        }
    }

    class Example
    {
        public delegate void MyDelegate(string s);
        public void Print(string s) { Console.Write(s); }
        public void PrintLine(string s) { Console.WriteLine(s); }

        public void TestDelegate()
        {
            MyDelegate d = new MyDelegate(Print);
            d("Hello, ");
            d("world!");
        }
    }

    public class EventExample
    {
        public delegate void MyEventDelegate(string eventDescr);
        public event MyEventDelegate OnPrinting;

        public void Print(string s)
        {
            if (OnPrinting != null)
            {
                OnPrinting(s);
                Console.WriteLine(s);
            }
        }
    }
}
