// Задача № 23. Вариант 1: Проверка вне метода.
/*
void Cube(int num)
{
    
    int current = 1;
    while(current <= num)
    {
        Console.Write((current * current * current) + " ");
        current ++ ;              
    } 
}
Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 0) Console.WriteLine("Your number is negativ!");
Cube(num);
*/

// Задача № 23. Вариант 2: Проверка внутри тела метода.
/*
void Cube(int num)
{
    if(num > 0)
    {
        int current = 1;
    while(current <= num)
    {
        Console.Write((current * current * current) + " ");
        current ++ ;              
    } 
    }
  else Console.WriteLine("Your number is negativ!");
}
Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);
*/

//Задача № 21.
/*
double FindLenght(double xA, double yA, double zA, double xB, double yB, double zB)
{
   return Math.Sqrt ((xB - xA)*(xB - xA) + Math.Pow((yB -yA),2) + Math.Pow((zB -zA),2));
}
 double xA, yA, zA, xB, yB, zB, Distance;

Console.WriteLine("Input coordinates xA: ");
xA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinates yA: ");
yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinates zA: ");
zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinates xB: ");
xB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinates yB: ");
yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinates zB: ");
zB = Convert.ToDouble(Console.ReadLine());

Distance = FindLenght(xA, yA, zA, xB, yB, zB);
Console.WriteLine("Вistance between points is " + Distance);
*/

// Задача № 19. 

void CheckingPolindromNumber(int num)
{
    if ((num / 10000 == num % 10) && ((num / 1000) % 10 == (num % 100) / 10)) Console.Write("Your number is polindrom");
    if ((num / 10000 <= num % 10) && (num / 10000 >= num % 10)) Console.Write("Your number is not polindrom") ;

    else  Console.WriteLine("Your number is not correct!");
}
Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
CheckingPolindromNumber(num);

