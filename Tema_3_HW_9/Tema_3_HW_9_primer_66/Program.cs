/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNaturalNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или некорректное число.");
        }
    }

    return result;
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    if (m > n)
    {
        m=n;
         m++;
        res = m + SumMN(m, n);
        return res;
    }
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

Console.WriteLine();
int m = GetNaturalNumber("Введите натуральное число m: ");
Console.WriteLine();
int n = GetNaturalNumber("Введите натуральное число n: ");

SumFromMToN(m, n);
Console.WriteLine();
void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m-1 , n));

}
