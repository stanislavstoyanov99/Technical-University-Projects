package com.javacodegeeks.snippets.enterprise.hibernate.service;

import java.util.List;

import com.javacodegeeks.snippets.enterprise.hibernate.dao.BookDao;
import com.javacodegeeks.snippets.enterprise.hibernate.model.Book;

public class BookService {

	private static BookDao bookDao;

	public BookService() {
		bookDao = new BookDao();
	}

	public void persist(Book entity) {
		bookDao.openCurrentSessionwithTransaction();
		bookDao.persist(entity);
		bookDao.closeCurrentSessionwithTransaction();
	}

	public void update(Book entity) {
		bookDao.openCurrentSessionwithTransaction();
		bookDao.update(entity);
		bookDao.closeCurrentSessionwithTransaction();
	}

	public Book findById(String id) {
		bookDao.openCurrentSession();
		Book book = bookDao.findById(id);
		bookDao.closeCurrentSession();
		return book;
	}

	public void delete(String id) {
		bookDao.openCurrentSessionwithTransaction();
		Book book = bookDao.findById(id);
		bookDao.delete(book);
		bookDao.closeCurrentSessionwithTransaction();
	}

	public List<Book> findAll() {
		bookDao.openCurrentSession();
		List<Book> books = bookDao.findAll();
		bookDao.closeCurrentSession();
		return books;
	}

	public void deleteAll() {
		bookDao.openCurrentSessionwithTransaction();
		bookDao.deleteAll();
		bookDao.closeCurrentSessionwithTransaction();
	}

	public BookDao bookDao() {
		return bookDao;
	}
}
