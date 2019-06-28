using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.Fire();
        }
    }

    delegate void D();

    interface I
    {
        int A12 { get; }
        void F();
    }

    class A : I
    {
        public event D E;
        private int a1 = 7;

        public virtual int A12
        {
            get { return a1; }
        }
        public A()
        {
            E += F;
        }

        public virtual void F()
        {
            Console.WriteLine($"{((A)this).A12 + 1}");
        }

        public void Fire()
        {
            E();
        }
    }

    class B : A, I
    {
        private int a1 = 8;

        public B()
        {
            E += F;
        }
        public int A12 { get { return a1; } }

        public void F()
        {
            Console.WriteLine($"{((I)this).A12 + 2}");
        }
    }
}
