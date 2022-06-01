package com.example;

public class Tipos {
    public static void main(String[] args) {
        // 1. numericos


        // 1.1 enteros
        byte variable1 = 5;
        System.out.println("variable1 = " + variable1);
        short variable2 = 10;
        System.out.println("variable2 = " + variable2);
        int variable3 = 30;
        System.out.println("variable3 = " + variable3);
        long variable4 = 100;
        System.out.println("variable4 = " + variable4);
        long numeroTelefono = 666555444;
        System.out.println("numeroTelefono = " + numeroTelefono);
        // long precio = null;

        // 1.2 decimales
        float variable5 = 5.5f;
        System.out.println("variable5 = " + variable5);
        double variable6 = 10.5d;
        System.out.println("variable6 = " + variable6);
        variable6 = 20.5d;
        System.out.println("variable6 = " + variable6);
        double precioSilla = 49.99;
        System.out.println("precioSilla = " + precioSilla);

        // 2. booleano
        boolean variable7 = false;
        System.out.println("variable7 = " + variable7);
        boolean variable8 = true;
        System.out.println("variable8 = " + variable8);

        // 3. texto
        char variable9 = 'a';
        System.out.println("variable9 = " + variable9);
        String variable10 = "Lorem ipsum dolor sit amet.....";
        System.out.println("variable10 = " + variable10);
    }
}
