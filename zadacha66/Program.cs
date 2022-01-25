// Показать натуральные числа от 1 до N, N задано
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()??"0");
void PrintNumbers(int number, int maximum)
{
    Console.Write($"{number}  ");
    number++;
    if (number <= maximum)
        PrintNumbers(number, maximum);
}
PrintNumbers(1, N);