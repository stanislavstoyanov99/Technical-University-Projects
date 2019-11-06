namespace LinkedList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();

            myList.InsertFront(5);
            myList.InsertFront(10);
            myList.InsertLast(15);

            Node<int> newNode = new Node<int>(30);

            myList.InsertAfter(newNode, 20);

            myList.PrintNodes();
        }
    }
}
