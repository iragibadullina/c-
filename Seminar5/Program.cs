//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
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

int FindPositivSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i];
    }
    return sum;
}

int FindNegativSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i]; // sum = sum + array[i]
    }
    return sum;
}

int[] myArray = CreateRandomArray(12, - 9, 9);
Console.WriteLine("Sum of Positiv is " + FindPositivSum(myArray));
Console.WriteLine("Sum of Negativ is " + FindNegativSum(myArray));
*/

//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] ChangeNegativOnPositiv(int[] array)
{
     for(int i = 0; i < array.Lehgth; i++)
    {
         array[i] * -1;
      
    }
    return array;
} 


//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

bool FindNumberInArray (int[]array, int aa)
{
for(int i = 0; i < array.Length; i++){
if(array[i] == aa) return true;
}
return false;
}



//Задайте одномерный массив из 12 случайных чисел. Найдите 

int FindElements(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= min && array[i] <= max) count++;
    }
    return count;
}





int FindCountElemensInRange( int[] array, int min, int max){
int count = 0;
for( int i=0; i < array.Length; i++){
if( array[i] >= min && array[i] <= max ) count++;
}
return count;
}

string OutputArrayConsole(int[] array){
string ss = "";
for(int i = 0; i < array.Length; i++){
ss += array[i] + ", ";
}
return ss;
}

//программа
Console.WriteLine("Работаем");
int[] myArray = CreateRandomArray(20,-20,20);

Console.WriteLine("reverse array " + OutputArrayConsole( ReverseElementsArray(myArray)) );
int find = 16;
Console.WriteLine("В массиве число "+ find + ( (FindNumberInArray(myArray,find)) ? "присутствует" : " не присутствует" ) );

int minnum = 10;
int maxnum = 99;
Console.Write

количество элементов массива, значения которых лежат в отрезке [10,99].