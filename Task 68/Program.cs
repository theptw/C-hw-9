﻿// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
    

            
    int Akk(int n, int m)
    {
        if (n == 0) return m + 1;
        if (n != 0 && m == 0) return Akk(n - 1, 1);
        if (n > 0 && m > 0) return Akk(n - 1, Akk(n, m - 1));
        return Akk(n,m);
    }
    Console.WriteLine(Akk(m,n));
