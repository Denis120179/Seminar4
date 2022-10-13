// Задача 25
// Напишите программу, которая принимает на вход два числа (А и В), и возводит число А в натуральную степень В
/*
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!); 
Console.WriteLine($"{A} в степени {B} равно {Exponent(A, B)}");

int Exponent (int number1, int number2)
{
    int result = 1;
    int count = 1; 
    if(number2 == 0)
    {
        result = 1;            
    }
    else
    {
        while(count <= number2)
        {
            result = result*number1;
            count++;
        }
    }   
    return result;    
}  
*/

// Задача 27
// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
/*
Console.WriteLine("Введите число:  ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе равна {SumFigure(N)}");

int SumFigure (int num)
{
    int result = 0;
    if(num < 10)
    {
        Console.WriteLine("Ваше число состоит из одной цифры");
    }
    else
    {
        while(num/10 > 1)
        {           
            result = result + num%10;
            num = num/10;
        }
        result = result + num%10;
    } 
return result;
}
*/

// Задача 29
// Напишите программу, которая задает массив из 8 элементов и выводит их на экран
/*
int [] arr = Array(8);
Console.WriteLine($"[{String.Join(",", arr)}]");

int[] Array(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100);       
    }
    return result;
}
*/