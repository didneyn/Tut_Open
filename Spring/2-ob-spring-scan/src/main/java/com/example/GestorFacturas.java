package com.example;

import org.springframework.stereotype.Component;

@Component
public class GestorFacturas {

    Calculadora calculatorService;

    
    public GestorFacturas(Calculadora calculatorService) {
        System.out.println("Ejecutando constructor GestorFacturas");
        this.calculatorService = calculatorService;
    }



}
