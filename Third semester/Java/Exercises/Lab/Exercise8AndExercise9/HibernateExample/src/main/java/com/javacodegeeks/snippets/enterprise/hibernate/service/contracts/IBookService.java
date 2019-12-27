package com.javacodegeeks.snippets.enterprise.hibernate.service.contracts;

import java.util.List;

import com.javacodegeeks.snippets.enterprise.hibernate.model.Book;

public interface IBookService {
    void persist(Book entity);

    void update(Book entity);

    Book findById(String id);

    void delete(String id);

    List<Book> findAll();

    public void deleteAll();
}
