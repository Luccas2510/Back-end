﻿int numero;
do
{
    Console.Write("De um palpite do número secreto (Tem que ser um número inteiro): ");
    numero = int.Parse(Console.ReadLine());

    Console.WriteLine($"Você digitou: {numero}");
} while (numero != 7);

Console.WriteLine("Você acertou o número secreto");
Console.ReadKey();