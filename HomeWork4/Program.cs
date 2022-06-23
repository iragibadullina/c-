// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*Вариант 1.

int NumbreOfThePower (int A, int B)
{
     int current = 1;
     int result = 1;
     
    while (current <= B)
    {
       
       current++;
       result = result * A;
    }
    return result;
}
Console.Write("Input your number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your number B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = NumbreOfThePower(A, B);
 Console.Write($"Натуральное число {A} в степени {B} равна {result} ");
*/

//Вариант 2.

int NumbreOfThePower (int A, int B)
{
     int current = 1;
     int result = 1;
     
    while (current <= B)
    {
       Math.Sqrt(A * A);    
       current++;
       result = result * A;
    }
    return result;
}
Console.Write("Input your number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your number B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = NumbreOfThePower(A, B);
 Console.Write($"Натуральное число {A} в степени {B} равна {result} ");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
int size = 8;
int[] array = new int [size];

for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0,9);
}

for(int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
} 
*/