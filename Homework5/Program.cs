//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++ )
    {
    if (array[i] % 2 == 1) 
      count++;
    }
    return count;
}

int[] myArray = CreateRandomArray(15, 99, 1000);
Console.WriteLine("Count of Positiv Numbers is " + CountPositiveNumbers(myArray));
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


//Вариант 1.
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

int SunmNechetPosition(int[] array)
{
  int sum = 0;
      for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 > 0) sum += array[i];

    } 
    return sum;
}
int[] myArray = CreateRandomArray(8, 10, 10);
Console.WriteLine("Sum of Nechet index is " + SunmNechetPosition(myArray));
*/

 // Вариант 2.
 /*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

int SunmNechetPosition(int[] array)
{
  int sum = 0;
      for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    } 
    return sum;
}
int[] myArray = CreateRandomArray(8, 10, 10);
Console.WriteLine("Sum of Nechet index is " + SunmNechetPosition(myArray));
*/

//Задача 38: Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76 

double[] CreateRandomArray(double size, double min, double max)
{
    double[] newArray = new double[20];
    
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().NextDouble() * (max - min) + min;
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

double DifferenceOfMaxAndMinNumbers(double[] array)
{
  double maxnum = 0;
  double minnum = 1;
  for(int i = 2; i < array.Length; i++)
  {
    if(maxnum < array[i]) maxnum = array[i];
    if(minnum > array[i]) minnum = array[i];
  }
   double difference = maxnum - minnum; 
  return difference;
}
  
double[] myArray = CreateRandomArray(3, 0, 1);
Console.WriteLine("Difference of max and min numbers is " +  DifferenceOfMaxAndMinNumbers(myArray));





