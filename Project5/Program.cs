﻿// Пишем пятую программу на C#: "Разное приветствие пользователей"
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine()!;

if (username.ToLower() == "маша")
{
    Console.WriteLine("УРА! Это же МАША!");
 }
 else
 {
    Console.Write("Привет, ");
    Console.WriteLine(username);
 }