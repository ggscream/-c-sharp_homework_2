﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

using static System.Console;

WriteLine("Введите число: ");
string number = ReadLine();

if (number.Length > 2)
{
    WriteLine(number[2]);
}
else
{
    WriteLine("Третьей цифры не существует");
}