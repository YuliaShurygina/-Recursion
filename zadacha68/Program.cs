// Показать натуральные числа от M до N, N и M заданы
void PrintNumbersRight(int m, int n)
{
    Console.Write($"{m} ");
    m++;
    if (m <= n)
       PrintNumbersRight(m, n);
}
void PrintNumbersLeft(int m, int n)
{
    Console.Write($"{m} ");
    m--;
    if (m >= n)
       PrintNumbersLeft(m, n);
}
Console.Write(" Введите число M: ");
int M = int.Parse(Console.ReadLine()??"0");
Console.Write(" Введите число N: ");
int N = int.Parse(Console.ReadLine()??"0");
if (N> M) PrintNumbersRight(M, N);
else PrintNumbersLeft(M, N);