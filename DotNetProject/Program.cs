using System;
using calculatorSolid;
using CalculadoraSolid.Operations;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("calculator aplicando los principios SOLID!");


var calculator = new Calculator();

double a = 10, b = 5;

Console.WriteLine($"Valores para las operaciones: {a}, {b}");

Console.WriteLine($"Suma: {calculator.Calculate(a, b, new Addition())}");
Console.WriteLine($"Resta: {calculator.Calculate(a, b, new Subtraction())}");
Console.WriteLine($"Multiplicación: {calculator.Calculate(a, b, new Multiplication())}");
Console.WriteLine($"División: {calculator.Calculate(a, b, new Division())}");