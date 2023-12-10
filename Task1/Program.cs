//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
//натуральные числа в промежутке от M до N. Использовать рекурсию, 
//не использовать циклы.


using System.ComponentModel;
using System.Net.Mail;

void NaturalNumbersFromTo(int M, int N)
{
      if(M > N) 
      return;
      Console.Write(M + " ");
      NaturalNumbersFromTo(M + 1, N);
}

int M = 5;
int N = 10;
NaturalNumbersFromTo(M,N);

/*
int ReadInt(string str)
{
      Console.Write(str);
      return Convert.ToInt32(Console.ReadLine());
}

void NaturalNumbersFromTo(int M, int N)
{
      if(M > N) 
      return;
      Console.Write(M + " ");
      NaturalNumbersFromTo(M + 1, N);
}

int M = ReadInt("Enter number M: ");
int N = ReadInt("Enter number N: ");
NaturalNumbersFromTo(M,N);
*/
