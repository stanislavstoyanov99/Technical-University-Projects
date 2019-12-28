package linkedlist;

import linkedlist.contracts.ILinkedList;

import java.util.Iterator;

public class LinkedList<T> implements Iterable<T>, ILinkedList {
    private Node head;

    public void insertFront(Integer newData) {
        Node newNode = new Node(newData);
        newNode.next = head;
        head = newNode;
    }

    public void remove(Integer data) {
        if (head == null) {
            return;
        }

        Node current = head;

        // If head needs to be removed
        if (data == 0) {
            head = current.next;
            return;
        }

        // Find previous node of the node to be deleted
        for (int i = 0; current != null && i < data - 1; i++) {
            current = current.next;
        }

        // If position is more than number of nodes
        if (current == null || current.next == null) {
            return;
        }

        // linkedlist.Node temp -> next is the node to be deleted
        // Store pointer to the next node to be deleted
        Node next = current.next.next;

        current.next = next;  // Unlink the deleted node from list
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
