package linkedlist.contracts;

public interface ILinkedList {
    void insertFront(Integer newData);

    void remove(Integer data);

    void insertLast(Integer newData);

    void printList();

    int size();
}
