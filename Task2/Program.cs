/*Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29*/

using System;


static int AkkermanFunc(int m, int n)
{
      if (m == 0) return n + 1;

      if (m > 0 && n = 0) return AkkermanFunc(m - 1, 1);

      if (m > 0 && n > 0) return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));

      return 0;

      Console.WriteLine(AkkermanFunc(m,n));
}

int m = 3, n = 2;

AkkermanFunc(m,n);
