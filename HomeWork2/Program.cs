
/*
int CutNumber(int num)
{
  int sot, dec;

  if (num >= 100 && num < 1000)
  {
    sot = num / 10;
    dec = sot % 10;
    
    return dec;
  }
  else
  {
    return -1;

  } 
}

Console.Write("Input three-figure number: ");

int a = Convert.ToInt32(Console.ReadLine());

int result = CutNumber(a);

if (result == -1)
{
  Console.WriteLine("Your number is not three-figure number!");
}
Console.WriteLine("Second number: " + result);
*/


// Задача 2. первый вариант
/*
int CutDigit(int num)

{
    if (num < 99) return -1;
    if (num >= 100 && num < 1000) return (num % 10);
    if (num >= 1000 && num < 10000) return ((num / 10) % 10);
    if (num >= 10000 && num < 100000) return ((num / 100) % 10);
    
    return -1;
}

Console.Write("Input your number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = CutDigit(a);
if (result == -1)
{
  Console.WriteLine("Your number is not third digit!");
}
Console.WriteLine("Trird digit: " + result);
*/


// Задача 2. второй не доработанный вариант. к нему еще вернусь.
/*
int CutDigit(int num)

{
    if (num < 99) return -1;
    if (num >= 100 && num < 999) return (num % 10);

    if (num > 999)
    {
      int a;
      int count = 0;
      
    while (count <= 999);
    {
       a = num / 10;      
      if (a > 100 && a < 999) return (a % 10); 
    }
    }
     return -1; 
}


Console.Write("Input your number: ");
int c = Convert.ToInt32(Console.ReadLine());
int result = CutDigit(c);
if (result == -1)
{
  Console.WriteLine("Your number is not third digit!");
}
Console.WriteLine("Trird digit: " + result);
*/


// Задача № 3. Почему -то не срабатывают выходные дни,программа пишет, что это не день недели.
/*
void CheckingTheDayOfTheWeek (int dayNumber)
 {
  if (dayNumber == 6 && dayNumber == 7) Console.WriteLine("Weekand -> yes");
  if (dayNumber >= 1 && dayNumber <= 5) Console.WriteLine("Is not weekand -> no");

  else Console.WriteLine("Is not week day!");

}
 
Console.Write("Input your number of the week day: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
CheckingTheDayOfTheWeek(dayNumber);
*/