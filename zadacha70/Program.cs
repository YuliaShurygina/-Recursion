// Найти сумму цифр числа
int SumOfDigits(int number)
{
    if (number == 0) return  0;
    else return number % 10 + SumOfDigits(number / 10);
}
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()??"0");
int sumOfDigits = SumOfDigits(n);
Console.WriteLine($"Сумма цифр числа равна {sumOfDigits} ");
