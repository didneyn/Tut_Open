package com.example.obrestdatajpa.services;

import com.example.obrestdatajpa.entities.Book;
import org.junit.jupiter.api.Test;

import java.time.LocalDate;

import static org.junit.jupiter.api.Assertions.*;

class BookPriceCalculatorTest {

    @Test
    void calculatePrice() {
        BookPriceCalculator calculator = new BookPriceCalculator();
        Book book = new Book(1L,"Ek selir de kis anillos","Autor",1000,49.99, LocalDate.now(),true);

        double price = calculator.calculatePrice(book);
        System.out.println("price = " + price);
        assertTrue(price>0);

        assertEquals(57.980000000000004,price);
    }
}