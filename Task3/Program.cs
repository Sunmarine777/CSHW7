//Задача 3: Задайте произвольный массив. Выведете его элементы,
//начиная с конца. Использовать рекурсию, не использовать циклы.


int[] Array = {1,2,3,4,5};
int size = 5;

void RevertArray(int[] Array, int size)

{
      if (size == 0) 
      return; 
      Console.Write(Array[size-1] + " ");           
      RevertArray(Array, size - 1);     
}

RevertArray(Array,size);


/*
int[] Array = {1,2,3,4,5};
int size = Array.Length;

void RevertArray(int[] Array, int size = 4)

{
      if (size < 0) 
      return; 
              
      RevertArray(Array, size - 1);
            
      if (size > 4)
      return;

      Console.Write(Array[size] + " ");    
}

RevertArray(Array,size);
*/