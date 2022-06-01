package com.example.ejerciciospring1.controllers;

import com.example.ejerciciospring1.entities.Laptop;
import com.example.ejerciciospring1.repositories.LaptopRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/laptops")
public class LaptopController {

    @Autowired
    LaptopRepository repository;

    @GetMapping
    public ResponseEntity<List<Laptop>> findAll (){
        return ResponseEntity.ok(repository.findAll());
    }

    @PostMapping
    public ResponseEntity save (@RequestBody Laptop laptop){
        repository.save(laptop);
        return ResponseEntity.ok().body(laptop);
    }
}
