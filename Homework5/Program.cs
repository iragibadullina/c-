//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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

int CountPositive(int[] newArray)
{
    int count = 0;
    for (int i = 0; i < newArray.Length; i++ )
    {
    if (array[i] % 2 == 1) 
      count++;
    }
  
  return count;
}

int min = 100;
int max = 999;
int result = CountPositive();
Console.WriteLine("Sum of Positiv is " + CountPositiv());




/*
int FindCountPositivNumbers( int[] array, int min, int max){
int count = 0;
for( int i=0; i < array.Length; i++)
{
if( array[i] % 2 == 1 ) count++;
}
return count;
}

int minnum = 100;
int maxnum = 999;
int[] myArray = FindCountPositivNumbers;
Console.Write("Count positiv numbers" + FindCountPositivNumbers(myArray, minnum, maxnum));


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
*/


//Задача 38: Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76