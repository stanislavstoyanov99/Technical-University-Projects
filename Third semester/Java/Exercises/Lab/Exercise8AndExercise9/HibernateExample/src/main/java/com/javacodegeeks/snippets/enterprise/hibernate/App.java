package com.javacodegeeks.snippets.enterprise.hibernate;

import java.util.List;

import com.javacodegeeks.snippets.enterprise.hibernate.model.Book;
import com.javacodegeeks.snippets.enterprise.hibernate.service.BookService;

public class App {

	public static void main(String[] args) {
		BookService bookService = new BookService();

		Book firstBook = new Book("1", "The Brothers Karamazov", "Fyodor Dostoevsky");
		Book secondBook = new Book("2", "War and Peace", "Leo Tolstoy");
		Book thirdBook = new Book("3", "Pride and Prejudice", "Jane Austen");

		/*System.out.println("*** Persist - start ***");

		bookService.persist(firstBook);
		bookService.persist(secondBook);
		bookService.persist(thirdBook);

		List<Book> books = bookService.findAll();

		System.out.println("Books Persisted are :");

		for (Book book : books) {
			System.out.println("-" + book.toString());
		}

		System.out.println("*** Persist - end ***");
		*/

		/*
		System.out.println("*** Update - start ***");

		firstBook.setTitle("The Idiot");
		bookService.update(firstBook);

		Book foundBook = bookService.findById(firstBook.getId());

		System.out.println("Book Updated is => " + foundBook.toString());
		System.out.println("*** Update - end ***");

		*/

		/*
		System.out.println("*** Find - start ***");

		String firstBookId = firstBook.getId();
		Book foundBook = bookService.findById(firstBookId);
		System.out.println("Book found with id " + firstBookId + " is => " + foundBook.toString());
		System.out.println("*** Find - end ***");

		*/

		/*
		System.out.println("*** Delete - start ***");

		String thirdBookId = thirdBook.getId();
		bookService.delete(thirdBookId);
		System.out.println("Deleted book with id " + thirdBookId + ".");
		System.out.println("Now all books are " + bookService.findAll().size() + ".");
		System.out.println("*** Delete - end ***");

		*/

		/*
		System.out.println("*** FindAll - start ***");

		List<Book> allBooks = bookService.findAll();

		System.out.println("Books found are :");

		for (Book book : allBooks) {
			System.out.println("-" + book.toString());
		}

		System.out.println("*** FindAll - end ***");

		*/

		System.out.println("*** DeleteAll - start ***");

		bookService.deleteAll();

		System.out.println("Books found are now " + bookService.findAll().size());
		System.out.println("*** DeleteAll - end ***");

		System.exit(0);
	}

	/** Table Creation Statement as SQL:
	 CREATE TABLE `library`.`book` ( id VARCHAR(50) NOT NULL, title
	 VARCHAR(50) default NULL, author VARCHAR(50) default NULL, PRIMARY KEY
	 (id) );
	 */
}
