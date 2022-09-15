// int SumLoop(int N)
//             {
//                 int sum=0;
//                 for (int i=1;i<=N;i++) sum+=i;
//                 return sum;
//             }

//         int SumRec(int N)
//             {
//                 if (N==0) return 0;
//                 else return N + SumRec(N-1);
//             }

//         Console.WriteLine(SumLoop(5));
//         Console.WriteLine(SumRec(5));


// // Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// // N = 5 -> "1, 2, 3, 4, 5"
// // N = 6 -> "1, 2, 3, 4, 5, 6"

// int n = 5;
// for (int i = 1; i <= n; i++)
// {
//     System.Console.Write(i + ",");
// }

// string showNumbers(int N)
// {
//     return (N == 1 ? "1" : showNumbers(N - 1) + N);
// }
// Console.WriteLine(showNumbers(5));




























// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// string GetNaturalRecursion(int m, int n)
// {
//   if (m == n) return Convert.ToString(n);
//   return m + ", " + GetNaturalRecursion(n - 1, m);
// }

// System.Console.WriteLine(GetNaturalRecursion(1, 5));


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// int SumDigits(int n)
// {
//     if (n < 10) return n;
//     else return (n % 10) + SumDigits(n / 10);
// }
// System.Console.WriteLine(SumDigits(188));













// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int PowNumbers(int a, int b)
// {
//     if (b == 0) return 1;
//     if (b == 1) return a;
//     else return a * PowNumbers(a, b-1);
// }
// System.Console.WriteLine(PowNumbers(3,5));




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

int AkkermanRec(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AkkermanRec(m - 1, 1);
    return AkkermanRec(m-1, AkkermanRec(m, n-1));
}
System.Console.WriteLine(AkkermanRec(3,2));









































