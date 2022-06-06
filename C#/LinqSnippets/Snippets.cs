﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqSnippets;
public class Snippets
{

    static public void BasicLinQ()
    {

        string[] cars =
        {
                "VW Golf",
                "VW California",
                "Audi A3",
                "Audi A5",
                "Fiat Punto",
                "Seat Ibiza",
                "Seat León"
            };

        //Select *
        var carList = from car in cars select car;

        foreach (var car in carList)
        {
            Console.WriteLine(car);
        }
        //Select where car is 'Audi'
        var audiList = from car in cars where car.Contains("Audi") select car;

        foreach (var audi in audiList)
        {
            Console.WriteLine(audi);
        }
    }

    static public void LinqNumbers()
    {

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var processedNumberList =
            numbers
                .Select(num => num * 3) //numeros multiplicados por 3
                .Where(num => num != 9) // numero diferente del 9
                .OrderBy(num => num); // orden ascendente
    }

    static public void SearchEamples()
    {

        List<string> textList = new List<string>
            {
                "a",
                "bx",
                "c",
                "d",
                "e",
                "cj",
                "f",
                "c"
            };

        // primer elemento
        var first = textList.First();

        // primer elemento igual a c
        var cText = textList.First(text => text.Equals("c"));

        // primer elemento con letra j
        var jText = textList.First(text => text.Contains("j"));

        // primer elemento con letra z por defecto
        var firstOrDefaultText = textList.FirstOrDefault(text => text.Contains("z"));

        // ultimo elemento conla letra z por dedecto
        var lastOrDefaultText = textList.LastOrDefault(text => text.Contains("z"));

        // valor unico que no este en a o b
        var uniqueTexts = textList.Single();
        var uniqueorDefaultTexts = textList.SingleOrDefault();

        int[] evenNumbers = { 0, 2, 4, 6, 8 };
        int[] otherEvenNumbers = { 0, 2, 6 };

        // noesta 4 y 8
        var myEvenNumbers = evenNumbers.Except(otherEvenNumbers);

    }

    static public void MultipleSelects()
    {

        string[] myOpinions =
        {
                "Opinión 1, text 1",
                "Opinión 2, text 2",
                "Opinión 3, text 3"
            };

        var myOpinonSelection = myOpinions.SelectMany(opinion => opinion.Split(","));

        var enterprises = new[]
        {
                new Enterprise()
                {
                    Id = 1,
                    Name = "Enterprise 1",
                    Employees = new []
                    {
                        new Employee
                        {
                            Id=1,
                            Name="Martín",
                            Email="martin@imaginagroup.com",
                            Salary = 3000
                        },
                        new Employee
                        {
                            Id=2,
                            Name="Pepe",
                            Email="pepe@imaginagroup.com",
                            Salary = 1000
                        },
                        new Employee
                        {
                            Id=3,
                            Name="Juanjo",
                            Email="juanjo@imaginagroup.com",
                            Salary = 2000
                        }
                    }
                },
                new Enterprise()
                {
                    Id = 2,
                    Name = "Enterprise 2",
                    Employees = new []
                    {
                        new Employee
                        {
                            Id=4,
                            Name="Ana",
                            Email="ana@imaginagroup.com",
                            Salary = 3000
                        },
                        new Employee
                        {
                            Id=5,
                            Name="Maria",
                            Email="maria@imaginagroup.com",
                            Salary = 1500
                        },
                        new Employee
                        {
                            Id=6,
                            Name="Marta",
                            Email="marta@imaginagroup.com",
                            Salary = 4000
                        }
                    }
                }
            };

        // todos los empleados de todas las empresas
        var employeeList = enterprises.SelectMany(enterprise => enterprise.Employees);

        // si existen empresas o esta vacia
        bool hasEnterprises = enterprises.Any();
        //si la empresa tiene empleados
        bool hasEmployees = enterprises.Any(enterprise => enterprise.Employees.Any());

        // todas las empresas que tengan empleados que ganen mas de 999
        bool hasEmployeeWithSalaryMoreThanOrEqual1000 =
            enterprises.Any(enterprise =>
                enterprise.Employees.Any(employee => employee.Salary >= 1000));

    }

    static public void linqCollections()
    {
        var firstList = new List<string>() { "a", "b", "c" };
        var secondList = new List<string>() { "a", "c", "d" };

        // INNER JOIN
        var commonResult = from element in firstList
                           join secondElement in secondList
                           on element equals secondElement
                           select new { element, secondElement };

        var commonResult2 = firstList.Join(
                secondList,
                element => element,
                secondElement => secondElement,
                (element, secondElement) => new { element, secondElement }
            );


        // OUTER JOIN - LEFT
        var leftOuterJoin = from element in firstList
                            join secondElement in secondList
                            on element equals secondElement
                            into temporalList
                            from temporalElement in temporalList.DefaultIfEmpty()
                            where element != temporalElement
                            select new { Element = element };

        var leftOuterJoin2 = from element in firstList
                             from secondElement in secondList.Where(s => s == element).DefaultIfEmpty()
                             select new { Element = element, SecondElement = secondElement };



        // OUTER JOIN - RIGHT
        var rightOuterJoin = from secondElement in secondList
                             join element in firstList
                             on secondElement equals element
                             into temporalList
                             from temporalElement in temporalList.DefaultIfEmpty()
                             where secondElement != temporalElement
                             select new { Element = secondElement };


        // UNION
        var unionList = leftOuterJoin.Union(rightOuterJoin);

    }


    static public void SkipTakeLinq()
    {

        var myList = new[]
        {
                1,2,3,4,5,6,7,8,9,10
            };

        // SKIP

        var skipTwoFirstValues = myList.Skip(2);

        var skipLastTwoValues = myList.SkipLast(2);

        var skipWhileSmallerThan4 = myList.SkipWhile(num => num < 4);

        // TAKE

        var takeFirstTwoValues = myList.Take(2);

        var takeLastTwoValues = myList.TakeLast(2);

        var takeWhileSmallerThan4 = myList.TakeWhile(num => num < 4);

    }
}
