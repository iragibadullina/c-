//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
double[,] CreateRandomTwoDemArray(int m, int n, int min, int max)
{
   double[,] newMatrix = new double[m,n];

   for(int i = 0; i < m; i++)
   { 
      for(int j = 0; j < n; j++)
      {
        newMatrix[i,j] = new Random().NextDouble() * 100;
        Console.Write(newMatrix[i,j] + " ");
      }
      Console.WriteLine();    
   }

   return newMatrix; 
}
*/
// Вариант 2
/*
void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().NextDouble() * 100;
    }
  }
}

void ShowTwoDemArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
   { 
      for(int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(array[i,j] + " ");
      }
      Console.WriteLine();
      }
}
Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

CreateArrayDouble(array);

ShowTwoDemArray(array);

Console.WriteLine();
*/




//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет
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
 
string ElementOfArray(int[] array, int lines, int columns)
{
   if(lines <= array.GetLength(0) || columns <= array.GetLength(1))
    return "Element is not found in this array";
    else return $"{array[lines, columns]}"
}

Console.Write("Input number of lines: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min numbers: ");
int[,] array = CreateRandomTwoDemArray(4,5,1,10);
Console.WriteLine(ElementOfArray(array));

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void ShowTwoDemArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
   { 
      for(int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(array[i,j] + " ");
      }
      Console.WriteLine();
      }
}
 
double[] AverageSumOfColums(int[,] array)
{
   double[] newArray = new double[array.GetLength(1)];

   for(int i = 0; i < array.GetLength(0); i++)
   {
      for(int j = 0; j < array.GetLength(1); j++)
      {
           newArray[i] += array[i,j] / array.GetLength(0);
      }
    
 } 
 return newArray; 
} 

Console.Write("Input amount lines: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input amount columns: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min numbers: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max numbers: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] sumArray = AverageSumOfColums(CreateRandomTwoDemArray(a,b,min,max));


