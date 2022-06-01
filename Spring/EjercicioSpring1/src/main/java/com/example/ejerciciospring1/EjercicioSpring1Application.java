package com.example.ejerciciospring1;

import com.example.ejerciciospring1.entities.Laptop;
import com.example.ejerciciospring1.repositories.LaptopRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.ApplicationContext;

@SpringBootApplication
public class EjercicioSpring1Application {

    public static void main(String[] args) {
        ApplicationContext context= SpringApplication.run(EjercicioSpring1Application.class, args);
        LaptopRepository repository= context.getBean(LaptopRepository.class);
        Laptop laptop1 = new Laptop(null,"Laptop 1");
        repository.save(laptop1);
    }

}
