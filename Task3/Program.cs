﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите номер дня недели: ");
string num = Console.ReadLine()!;
switch (num)
{
    case "1":
    Console.WriteLine("Нет");
    break;
    case "2":
    Console.WriteLine("Нет");
    break;
    case "3":
    Console.WriteLine("Нет");
    break;
    case "4":
    Console.WriteLine("Нет");
    break;
    case "5":
    Console.WriteLine("Нет");
    break;
    case "6":
    Console.WriteLine("Да");
    break;
    case "7":
    Console.WriteLine("Да");
    break;
    default:
    Console.WriteLine("Нет такого дня недели");
    break;
}
