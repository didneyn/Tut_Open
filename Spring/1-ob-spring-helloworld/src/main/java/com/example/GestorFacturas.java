package com.example;

public class GestorFacturas {

    Calculadora calculatorService;

    public GestorFacturas(Calculadora calculatorService, String nombre) {
        System.out.println("Ejecutando constructor GestorFacturas");
        this.calculatorService = calculatorService;
    }



}
