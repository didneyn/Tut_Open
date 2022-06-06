package com.example.obrestdatajpa.controllers;

import com.example.obrestdatajpa.entities.Book;
import com.example.obrestdatajpa.repositories.BookRepository;
import lombok.extern.slf4j.Slf4j;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpHeaders;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;
import java.util.logging.Logger;


@RestController
@Slf4j
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
        //return book.map(ResponseEntity::ok).orElseGet(()-> ResponseEntity.notFound().build());
    }

    @PostMapping("/api/books")
    public ResponseEntity<Book> create(@RequestBody Book book, @RequestHeader HttpHeaders headers){
        System.out.println(headers.get("User-Agent"));
        if(book.getId() != null){
            log.warn("trying to create a book with id");
            return ResponseEntity.badRequest().build();
        }
        Book result = repository.save(book);
        return ResponseEntity.ok(result);
    }

    @PutMapping("/api/books")
    public ResponseEntity<Book> update (@RequestBody Book book){
        if(book.getId()==null){
            log.warn("trying to update a non existent book");
            return ResponseEntity.badRequest().build();
        }
        if(!repository.existsById(book.getId())){
            log.warn("trying to update a non existent book");
            return ResponseEntity.notFound().build();
        }

        Book result = repository.save(book);
        return ResponseEntity.ok(result);
    }

    @DeleteMapping("/api/books/{id}")
    public ResponseEntity<Book> delete(@RequestParam Long id){
        if(!repository.existsById(id)){
            log.warn("trying to delete a non existent book");
            return ResponseEntity.notFound().build();
        }

        repository.deleteById(id);

        return ResponseEntity.noContent().build();
    }

    @DeleteMapping("/api/books")
    public ResponseEntity<Book> deleteAll (){
        log.info("Rest Request for delete all books");
        repository.deleteAll();
        return ResponseEntity.noContent().build();
    }


}
