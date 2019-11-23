package com.javacodegeeks.snippets.enterprise.hibernate;

import com.javacodegeeks.snippets.enterprise.hibernate.model.Book;
import com.javacodegeeks.snippets.enterprise.hibernate.service.BookService;

import java.util.List;

public class App {
    public static void main(String[] args) {
        BookService bookService = new BookService();
        Book firstBook = new Book("1", "The Brothers Karamazov", "Fyodor Dostoevsky");
        Book secondBook = new Book("2", "War and Peace", "Leo Tolstoy");
        Book thirdBook = new Book("3", "Pride and Prejudice", "Jane Austen");

        System.out.println("*** Persist - start ***");
        bookService.persist(firstBook);
        bookService.persist(secondBook);
        bookService.persist(thirdBook);

        List<Book> books = bookService.findAll();
        System.out.println("Books Persisted are: ");
        for (Book b : books) {
            System.out.println("-" + b.toString());
        }
        System.out.println("*** Persist - end ***");
        System.out.println("*** Update - start ***");

        firstBook.setTitle("The Idiot");
        bookService.update(firstBook);
        System.out.println("Book Updated is =>" + bookService.findById(firstBook.getId()).toString());
        System.out.println("*** Update - end ***");
        System.out.println("*** Find - start ***");

        String firstId = firstBook.getId();
        Book anotherBook = bookService.findById(firstId);
        System.out.println("Book found with id " + firstId + " is =>" + anotherBook.toString());

        System.out.println("*** Find - end ***");
        System.out.println("*** Delete - start ***");

        String thirdId = thirdBook.getId();
        bookService.delete(thirdId);
        System.out.println("Deleted book with id " + thirdId + ".");
        System.out.println("Now all books are " + bookService.findAll().size() + ".");
        System.out.println("*** Delete - end ***");
        System.out.println("*** FindAll - start ***");

        List<Book> books2 = bookService.findAll();
        System.out.println("Books found are: ");
        for (Book b : books) {
            System.out.println("-" + b.toString());
        }
        System.out.println("*** FindAll - end ***");
        System.out.println("*** DeleteAll - start ***");

        bookService.deleteAll();
        System.out.println("Books found are now " + bookService.findAll().size());
        System.out.println(("*** DeleteAll - end ***"));
    }
}
