// Показать натуральные числа от N до 1, N задано
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()??"0");
void PrintNumbers(int start, int end )
{
    Console.Write($"{start} ");
    start--;
    if (start >= end)
        PrintNumbers(start,end);
}
PrintNumbers(N, 1);