// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

 Console.WriteLine("Введите M: ");
 int m = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите N: ");
 int n = Convert.ToInt32(Console.ReadLine());

int result = 0;

int Sum(int begin, int end)
{
    int num = n;
    for (end = num; end >= begin; end--)
    {
        result += end;
    }
    return result;
   
}

Console.WriteLine(Sum(m,n));