﻿// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int N = Convert.ToInt32(Console.ReadLine()), a0 = 0, a1 = 1, x;
for (int i = 0; i < N; i++)
{
  Console.Write($"{a0} ");
  x = a0 + a1;
  a0 = a1;
  a1 = x;
}
