﻿// Напишите программу, которая на вход принимает число (N), а 
// на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите любое число: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = 1;

while (number1 >= number2)
{
   if (number2 % 2 == 0)
   {
      Console.Write($"{number2}, ");
   }
   number2++;
}
