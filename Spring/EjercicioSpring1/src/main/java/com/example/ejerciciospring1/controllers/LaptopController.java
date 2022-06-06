package com.example.ejerciciospring1.controllers;

import com.example.ejerciciospring1.entities.Laptop;
import com.example.ejerciciospring1.repositories.LaptopRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;

@RestController
@RequestMapping("/api/laptops")
public class LaptopController {

    @Autowired
    LaptopRepository repository;

    @GetMapping
    public ResponseEntity<List<Laptop>> findAll (){
        return ResponseEntity.ok(repository.findAll());
    }

    @GetMapping("/{id}")
    public ResponseEntity<Optional<Laptop>> findOneById (@PathVariable Long id){
        if(id == null){
            return ResponseEntity.badRequest().build();
        }

        Optional<Laptop> laptop = repository.findById(id);
        if(!laptop.isPresent()){
            return ResponseEntity.notFound().build();
        }

        return ResponseEntity.ok(repository.findById(id));
    }

    @PostMapping
    public ResponseEntity save (@RequestBody Laptop laptop){

        if(laptop.getId()!=null){
            return ResponseEntity.badRequest().build();
        }

        Laptop result = repository.save(laptop);

        return ResponseEntity.ok().body(result);
    }

    @PutMapping
    public ResponseEntity update (@RequestBody Laptop laptop){
        if(laptop.getId() == null){
            return ResponseEntity.badRequest().build();
        }
        if( !repository.existsById(laptop.getId()) ){
            return ResponseEntity.notFound().build();
        }
        Laptop result = repository.save(laptop);
        return ResponseEntity.ok().body(result);
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Optional<Laptop>> deleteOneById (@PathVariable Long id){

        if(id == null){
            return ResponseEntity.badRequest().build();
        }
        if( !repository.existsById(id) ){
            return ResponseEntity.notFound().build();
        }

        repository.deleteById(id);

        return ResponseEntity.noContent().build();
    }
    @DeleteMapping
    public ResponseEntity<Optional<Laptop>> deleteAll (){
        repository.deleteAll();
        return ResponseEntity.noContent().build();
    }
}
