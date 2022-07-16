//Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
//Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();
    }
    return words;
}

int CounterWordStartingVowel(string[] array)
{
    int counter = 0;
    char[] volwe = { 'a','e','i','o','y','u'};
    for (int i = 0; i < array.Length; i++)
    {
        for(int j = 0; j < array.Length; j++)
        {
            if(char.ToLower(array[i][0])== volwe[j]) counter++;
        }
          
    }
    return counter;
}

//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
//Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string[] IntegratedArray(string[] array)
{
    int addition = 0;
    if(array.Length % 2 == 0) addition = 1;
    string [] newArray = new string[array.Length / 2 + addition];
    for(int i = 0; i < newArray.Length; i++)
    {
        if(i * 2 + 1 < array.Length) newArray[i] = array[i * 2] + array[i * 2 +1];
        else newArray[i] = array [i * 2];
    }
    return newArray;
}

void WriteArray(string[] array)
{
    foreach(string word in array) Console.Write(word + ", ");
}

string[] array = {"qwe", "wer", "ert","rty","tyu","yui"};
WriteArray(array);
Console.WriteLine();
string[] newArray =  IntegratedArray(array);
WriteArray(newArray);