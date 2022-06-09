/*
int num1, num2;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2) 
{
    Console.WriteLine("max =" + num1);
}
else
{
    Console.WriteLine("max =" + num2);
}
*/

/*
int num1, num2, num3, max;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third integer number: ");
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;

if(num1 > num2)
{
  Console.WriteLine(max = num1);  
}
if(num3 > max)
{
  Console.WriteLine(max = num3);  
}
*/

/*
int num;

Console.Write("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
   Console.WriteLine("Да"); 
}
else
{
  Console.WriteLine("Нет");  
}
*/

int N;

Console.Write("Input integer number: ");
N = Convert.ToInt32(Console.ReadLine());

int currant = 2;

while(currant <= N)
{
    if (currant % 2 == 0);

    Console.Write(currant + " ");
    currant = currant + 2;

}
