package com.example.obrestdatajpa.controllers;

import com.example.obrestdatajpa.entities.Book;
import com.example.obrestdatajpa.repositories.BookRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpHeaders;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;


@RestController
public class BookController {

    @Autowired
    BookRepository repository;

    @GetMapping("/api/books")
    public List<Book> findAll(){
        return repository.findAll();
    }

    @GetMapping("/api/books/{id}")
    public ResponseEntity<Book> findById(@PathVariable Long id){
        Optional<Book> book = repository.findById(id);
        if(!book.isPresent()){
            return ResponseEntity.notFound().build();
        }

        return ResponseEntity.ok(book.get());
    }

    @PostMapping("/api/books")
    public Book create(@RequestBody Book book, @RequestHeader HttpHeaders headers){
        System.out.println(headers.get("User-Agent"));
        return repository.save(book);
    }



}
