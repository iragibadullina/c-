//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

void NumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Sum numbers from M to N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    NumberSum(numberM, numberN, sum);
}

NumberSum(numberM, numberN, 0);

Console.WriteLine("Input number M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Input number N:");
int numberN = int.Parse(Console.ReadLine());

//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.
//453 -> 3
//45 -> 2

int AmountDigitInNumbers(int number)
{
   count = 0
   while(number > 0)  number = number / 10;
   count = count + 1
   
return count;
}
Console.WriteLine(AmountDigitInNumbers(123))


