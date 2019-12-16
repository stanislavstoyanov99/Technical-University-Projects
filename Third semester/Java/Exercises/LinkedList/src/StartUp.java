public class StartUp {
    public static void main(String[] args)
    {
        LinkedList<Integer> list = new LinkedList<Integer>();
        list.insertFront(5);
        list.insertFront(6);
        list.insertFront(7);
        list.insertFront(8);
        list.insertFront(9);
        list.insertFront(10);

        System.out.println(list.size());
    }
}
