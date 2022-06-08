/*
int num;
Console.Write("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

num = num * num;

Console.WriteLine("result is " + num);
*/

/*
int num1, num2, quad;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2 * num2;

if(num1 == quad)
{
     Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}
*/ 
    
int num;

Console.Write("Input  integer number: ");
num = Convert.ToInt32(Console.ReadLine());

int currant = num * (-1);

while(currant <= num)
{
    Console.Write(currant + " ");
    currant = currant + 1;

}

