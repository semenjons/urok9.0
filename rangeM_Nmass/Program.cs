
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите следующую число N:");
int numberN = int.Parse(Console.ReadLine());


void TopNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    TopNumberSum(numberM, numberN, sum);
}

TopNumberSum(numberM, numberN, 0);