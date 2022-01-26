// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
double Fibonacci(int number, int A, int B)
{
    if (number == 1 ) return A;
    else if (number == 2) return B;
    else return Fibonacci(number-1, A, B)+ Fibonacci(number -2, A, B);
}

Console.Write("Введите количество элементов последовательности: ");
int n = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите первый элемент последовательности: ");
int a = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите второй элемент последовательности: ");
int b = int.Parse(Console.ReadLine()??"0");
for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"f({i}) = {Fibonacci(i, a, b)} ");
    }