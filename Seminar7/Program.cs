// двумерный массив заполненный случайными цифрами
/*int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
   int[,] newMatrix = new int[a,b];

   for(int i = 0; i < a; i++)
   { 
      for(int j = 0; j < b; j++)
      {
        newMatrix[i,j] = new Random().Next(min, max + 1);
        Console.Write(newMatrix[i,j] + " ");
      }
      Console.WriteLine();    
   }

   return newMatrix; 

}
 int[,] array =CreateRandomTwoDemArray(4,5,1,10);
*/


//1 Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j.
// Выведите полученный массив на экран.
/*
int[,] CreateArrayIJ(int a, int b)
{
   int[,] newMatrix = new int[a,b];

   for(int i = 0; i < a; i++)
      for(int j = 0; j < b; j++)
          newMatrix[i,j] = i + j;
   return newMatrix; 
}         
  

void ShowTwoDemArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
   { 
      for(int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(newMatrix[i,j] + " ");
      }
      Console.WriteLine();
      }
}
 int[,] array =CreateRandomTwoDemArray(4,5);
*/
//2. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
/*
int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
   int[,] newMatrix = new int[a,b];

   for(int i = 0; i < a; i++)
   { 
      for(int j = 0; j < b; j++)
      {
        newMatrix[i,j] = new Random().Next(min, max + 1);
        Console.Write(newMatrix[i,j] + " ");
      }
      Console.WriteLine();    
   }
   return newMatrix; 
}

int[,] UpdateArrayEvenIndexQuard(int[,] array)
{
      for(int i = 0; i < array.GetLength(0); i+=2)
           for(int j = 0; j < array.GetLength(1); j+=2)
                 array[i,j] *= array[i,j];

  return array;                
 }

int[,] myArray = CreateRandomTwoDemArray(4,5,2,15);
Console.WriteLine();
UpdateArrayEvenIndexQuard(myArray);
*/
//3.Задайте двумерный массив. Найдите сумму элементов, находящихся на 
//главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] CreateRandomTwoDemArray(int a, int min, int max)
{
   int[,] newMatrix = new int[a];

   for(int i = 0; i < a; i++)
   { 
      for(int j = 0; j < a; j++)
      {
        newMatrix[i,j] = new Random().Next(min, max + 1);
        Console.Write(newMatrix[i,j] + " ");
      }
      Console.WriteLine();    
   }
   return newMatrix; 
}
int[,] array = CreateRandomTwoDemArray(4,5,1,10);
int[,] SumOfDiagramma(int[,] array)
{
   int sum = 0;
   for(int i = 0; i < array.GetLength(1); i++)
             sum += array[i,i];
      return sum;
 }  
     
int[,] myArray = CreateRandomTwoDemArray(4,2,15); 
Console.WriteLine(SumOfDiagramma(myArray));