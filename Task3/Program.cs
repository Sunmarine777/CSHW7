//Задача 3: Задайте произвольный массив. Выведете его элементы,
//начиная с конца. Использовать рекурсию, не использовать циклы.


void RevertArray(int m, int n)
{
      if(m > n) 
      return;
      RevertArray(m + 1, n);
      Console.Write(m + " ");
}

int m = 5, n = 10;
RevertArray(m, n);


/*
int ReadInt(string str)
{
      Console.Write(str);
      return Convert.ToInt32(Console.ReadLine());
}
void RevertArray(int m, int n)
{
      if(m > n)
      {
      Console.WriteLine("Wrong itput");
      return;
      }
      RevertArray(m + 1, n);
      Console.Write(m + " ");
}

int m = ReadInt("Enter integer m: ");
int n = ReadInt("Enter integer n: ");
RevertArray(m, n);
*/