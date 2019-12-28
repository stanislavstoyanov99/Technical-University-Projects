package linkedlist;

import java.util.Random;
import java.util.ArrayList;
import java.util.Collections;

public class StartUp {
    public static void main(String[] args)
    {
        /*
        linkedlist.LinkedList<Integer> list = new linkedlist.LinkedList<Integer>();
        list.insertFront(5);
        list.insertFront(6);
        list.insertFront(7);
        list.insertFront(8);
        list.insertFront(9);
        list.insertFront(10);

        list.insertLast(20);
        list.insertFront(2);

        list.remove(0);

        list.printList();
        System.out.println("List total elements: " + list.size());

         */

        // Ready ArrayList
        ArrayList<String> elements = new ArrayList<String>();
        Random random = new Random();

        for (int i = 0; i < 100; i++) {
            elements.add("pesho" + random.nextInt(100));
        }

        Collections.sort(elements);

        elements.remove(0);
        elements.add("pesho");

        for (var element:elements) {
            System.out.println(element);
        }
    }
}
