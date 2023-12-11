/*Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29*/

using System;

int m = 3, n = 2;

static int AckermannFunc(int m, int n)
{
      if (m == 0) return n + 1;

      if (m > 0 && n == 0) return AckermannFunc(m - 1, 1);

      if (m > 0 && n > 0) return AckermannFunc(m - 1, AckermannFunc(m, n - 1));

      return 0;    
}

Console.WriteLine(AckermannFunc(m,n));

AckermannFunc(m,n);