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

            Node<int> previousNode = new Node<int>(10);

            myList.InsertAfter(previousNode, 50);

            myList.PrintNodes();
        }
    }
}
