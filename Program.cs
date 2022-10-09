﻿/*******************************************************************************************************************
Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
(можно решить через строку, а можно математически)
14212 -> нет
12821 -> да
23432 -> да
*********************************************************************************************************************/
// Решение 1:
/*
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

if (num < 10000 || num > 100000)
{
    Console.WriteLine("Ваше число не пятизначное");
}
else
{
    int a1 = num / 10000;
    int a2 = (num / 1000) % 10;
    int a4 = (num % 100) / 10;
    int a5 = num % 10;
    if (a1 == a5 && a2 == a4)
    {
        Console.WriteLine($"Число {num} - палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {num} - не палиндромом");
    }
}
*/
// Решение 2:
/*
Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine()!;
if (num.Length == 5){
if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"Число {num} - палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {num} - не палиндромом");
    }    
}
else{
    Console.WriteLine("Ваше число не шестизначное");
}
*/

/*******************************************************************************************************************
Задача 21/ Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*********************************************************************************************************************/

Console.WriteLine("Вводим координаты точки A: ");
Console.Write("Введите X1: ");
double x1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Вводим координаты точки B: ");
Console.Write("Введите X2: ");
double x2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine()!);

double len = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками {len:f3}");