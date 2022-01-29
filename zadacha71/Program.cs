// Написать программу вычисления функции Аккермана
int Akerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if ( n == 0) return Akerman(m-1, 1);
    else return Akerman(m - 1, Akerman(m, n - 1));
}
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()??"0");
int akkerman = Akerman(m, n);
Console.WriteLine(akkerman);

