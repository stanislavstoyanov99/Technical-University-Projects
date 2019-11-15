using System;

namespace Tree
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Tree<char> tree = new Tree<char>('A',
                new Tree<char>('B', new Tree<char>('E'), new Tree<char>('F')),
                new Tree<char>('C', new Tree<char>('G'), new Tree<char>('H')));
        }
    }
}
