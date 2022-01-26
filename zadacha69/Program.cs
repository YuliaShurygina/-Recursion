// Найти сумму элементов от M до N, N и M заданы
int SumOfNumbers(int n, int m)
{
    if (n == m) return m;
    else   return n + SumOfNumbers(n-1, m);
}
Console.Write(" Введите число M: ");
int M = int.Parse(Console.ReadLine()??"0");
Console.Write(" Введите число N: ");
int N = int.Parse(Console.ReadLine()??"0");
int sumOfNumbers = SumOfNumbers(N, M);
Console.WriteLine($"Сумма элементов от {M} до {N} равна {sumOfNumbers}");
