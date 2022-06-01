package com.example.ejerciciospring1.repositories;

import com.example.ejerciciospring1.entities.Laptop;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Component;
import org.springframework.stereotype.Repository;

@Component
@Repository
public interface LaptopRepository extends JpaRepository<Laptop, Long> {
}
