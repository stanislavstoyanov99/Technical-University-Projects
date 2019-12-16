import java.util.Iterator;

public class LinkedList<T> implements Iterable<T> {
    private Node head;

    public void insertFront(Integer newData) {
        Node newNode = new Node(newData);
        newNode.next = head;
        head = newNode;
    }

    public void insertLast(Integer newData) {
        Node newNode = new Node(newData);

        if (head == null) {
            head = newNode;
            return;
        }

        Node lastNode = getLastNode();
        lastNode.next = newNode;
    }

    public void printList() {
        Node current = head;

        while (current != null) {
            System.out.println(current.data);
            current = current.next;
        }
    }

    private Node getLastNode() {
        Node temp = head;

        while (temp.next != null) {
            temp = temp.next;
        }

        return temp;
    }

    public int size() {
        int size = 0;
        Node temp = head;

        while (temp.next != null) {
            size++;
            temp = temp.next;
        }

        return size + 1;
    }

    @Override
    public Iterator<T> iterator() {
        return new Iterator<T>() {
            Node current = head;

            @Override
            public boolean hasNext() {
                return current != null;
            }

            @Override
            public T next() {
                if (hasNext()) {
                    T data = (T)current.data;
                    current = current.next;
                    return data;
                }

                return null;
            }
        };
    }
}
