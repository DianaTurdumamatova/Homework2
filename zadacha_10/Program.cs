﻿/* Напишите программу, которая принимает на вход трехзначное число
 и на выходе показывает вторую цифру этого числа.
 456 - 5
 782 - 2*/


Console.WriteLine("Введите трехзначное число: ");
int num = new Random().Next(100, 1000);
int result = num / 10 % 10;
Console.WriteLine($"{num} -> {result}");
