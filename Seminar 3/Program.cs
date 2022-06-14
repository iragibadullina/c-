
/*
// задача 1 про координаты
int FindQuart(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;

    return -1;

}

int result = FindQuart(2,4);
if (result == -1)  Console.WriteLine("Данная точка расположена га осях: ");
 else Console.WriteLine($"Точка находится в {result} четверти");

*/

void FindQuart(int x)
{
    if (x >= 1 && x <= 4);
    if (x == 1) Console.WriteLine("Допусимое значение x, y");
    if (x == 2) Console.WriteLine("Допусимое значение x, -y");
    if (x == 3) Console.WriteLine("Допусимое значение -x, -y");
    if (x == 4) Console.WriteLine("Допусимое значение -x, y");
    
    else Console.WriteLine("Doont");

} 

int x;
Console.WriteLine("Input number quart; ");
x = Convert.ToInt32(Console.ReadLine());
