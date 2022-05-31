package com.example;

import org.springframework.stereotype.Component;

@Component
public class Calculadora {

    public Calculadora() {
        System.out.println("Ejecutando Constructor");
    }

    public String HolaMundo(){
        return "Hola Mundo!";
    }
}
