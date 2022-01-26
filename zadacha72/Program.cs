// Написать программу возведения числа А в целую стень B
 int Exponentiation(int a, int b)
 {
     if (b == 0) return 1;
     else if (b % 2 == 0) return Exponentiation(a*a, b/2);
     else return a*Exponentiation(a, b-1);
 }

Console.Write(" Введите число A: ");
int A = int.Parse(Console.ReadLine()??"0");
Console.Write(" Введите степень B: ");
int B = int.Parse(Console.ReadLine()??"0");
int exponentation = Exponentiation(A, B);
Console.WriteLine($" Возведение числа {A} в степень {B} равно {exponentation}");