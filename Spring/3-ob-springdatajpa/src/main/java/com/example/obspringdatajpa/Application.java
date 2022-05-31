package com.example.obspringdatajpa;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.ApplicationContext;

@SpringBootApplication
public class Application {

    public static void main(String[] args) {
        ApplicationContext context = SpringApplication.run(Application.class, args);

        CocheRepository repository = context.getBean(CocheRepository.class);

        System.out.println("El num de coches en base de datos es: " + repository.count());

        Coche toyota = new Coche(null, "Toyota", "Prius", 2010);
        repository.save(toyota);

        System.out.println("El num de coches en base de datos es: " + repository.count());

        System.out.println(repository.findAll());
    }

}
