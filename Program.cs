﻿// Задача 73 : Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты (все числа в группе друг на друга не делятся)? Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰.

// Например, для N = 50, M получается 6

// Группа 1: 1
// Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// Группа 5: 7 16 24 36 40
// Группа 6: 5 32 48

// Группа 1: 1
// Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// Группа 5: 16 24 36 40
// Группа 6: 32 48
Console.WriteLine("Введите число N : ");
double n = double.Parse(Console.ReadLine());
Console.WriteLine($"Для N = {n} можно получить  {Math.Ceiling(Math.Log(n,2))}  групп M");
