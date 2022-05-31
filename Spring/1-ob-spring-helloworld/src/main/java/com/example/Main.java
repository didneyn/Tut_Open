package com.example;

import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class Main {
    public static void main(String[] args) {

        ApplicationContext context = new ClassPathXmlApplicationContext("beans.xml");

        //Concepto 1 Obtener Beans de spring
        // Normal Object
        Calculadora service = new Calculadora();

        // Object Spring
        Calculadora calculator = (Calculadora) context.getBean("calculatorService");

        String texto = calculator.HolaMundo();
        System.out.println("texto = " + texto);

        Calculadora calculator2 = (Calculadora) context.getBean("calculatorService");

        texto = calculator.HolaMundo();
        System.out.println("texto = " + texto);

        //Concepto 2 cargar un bean dentro de otro
        //cargar un bean dentro de otro bean
        GestorFacturas gestorFacturas = (GestorFacturas) context.getBean("gestorFacturas");
        System.out.println(gestorFacturas.calculatorService.HolaMundo());

        //Concepto 3 scope o alcance
        //por defecto son singleton, se crea un objeto y se usa para toda la aplicacion
        //el scope prototype se crea uno nuevo cada vez que se usa

    }
}
