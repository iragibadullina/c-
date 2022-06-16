// получает число, найти сумму цифр в этом числе.
/*
int FindSumOfDigit(int num)
{
    int sum = 0;
    while(num > 0)
    {
        num = sum + num % 10;
        num = num / 10;
    }
   return sum;
}

int a ;
int result = FindSumOfDigit(a);
Console.Write($"Сумма цифр в числе {a} равна  {result}");
*/
//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
 /*
int SumOfDigit(int num)
{
    int sum = 0;
    int current = 1;
    while(current <= num)
    {
        sum += current;
        current++;
    }
   return sum;
}

int a = 5;
int result = SumOfDigit(a);
Console.Write($"Сумма цифр в числе {a} равна  {result}");
*/

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int MPOfDigit(int num)
{
    if(num <= 0) return -1;
    else int mp = 1;
    int current = 1;
    while(current <= num)
    {
        mp *= current;
        current++;
    }
   return mp;

    }
    
}


Console.Write($"Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = MPOfDigit(a);
Console.Write($"Произведение цифр в числе {a} равно  {result}");
*/
/*
int CountOfDigit(int num)
{
    int sum = 0;
    while(num / 10 > 0)
    {
        sum++;
        
    }
   return sum;
}

int a = 4789;
int result = CountOfDigit(a);
Console.Write($"Сумма цифр в числе {a} равна  {result}");
*/
/*
void Count(int a)
{
    int counter = 0;
    while (a > 0)
    {
        a = a / 10;
        counter++;
    }
    Console.WriteLine("Count of digits in your number is: " + counter);
}
int a = Convert.ToInt32(Console.Read());
Count(a);

*/
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int size = 8;
int[] array = new int [size];

for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0,2);
}

for(int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
} 
