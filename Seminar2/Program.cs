
int FindMaxPart(int num)
{
    int dec, ed;

    if(num >= 10 && num <= 99)
    {
        dec = num / 10;
        ed = num % 10;

        if(dec > ed)
        {
            return dec;
        }
        else
        {
            return ed;
        }
      
    }
    else 
    {
     return -1;   
    }
}

Console.WriteLine("Input two-digit number: ");

int a = Convert.ToInt32(Console.ReadLine());

int result = FindMaxPart(a);



Console.WriteLine($"Bigger number of {a} "is" + {result}");

