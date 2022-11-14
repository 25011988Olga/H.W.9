//Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов
// в промежутке от M до N.
//(НЕ ИСПОЛЬЗОВАТЬ РЕЗУЛЬТИРУЮЩУЮ ПЕРЕМЕННУЮ)
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма элементов от {n} до {m} = {CountNaturalSum(n, m)}");


int CountNaturalSum(int n, int m)
{
    if (n == m)
        return m;
    return m + CountNaturalSum(n, m - 1);
}







