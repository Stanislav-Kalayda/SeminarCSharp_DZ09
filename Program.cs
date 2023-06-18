// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int start = 1;
// FromHighToLower(num, start);
// void FromHighToLower(int num1, int num2)
// {
//     if (num1 < num2)
//     {
//         return;
//     }
//     else
//     {
//         FromHighToLower(num1, num2 + 1);
//         Console.Write($"{num2} ");
//     }
// }

// ________________________________________________________________________

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в 
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int temp = M;

// if (M > N)
// {
//     M = N;
//     N = temp;
// }
// Summ(M, N, temp = 0);
// void Summ(int M, int N, int sum)
// {
//     sum = sum + N;
//     if (N <= M)
//     {
//         Console.WriteLine($"Сумма элементов = {sum}");
//         return;
//     }
//     Summ(M, N - 1, sum);
// }

// _____________________________________________________________________________________

// Задача 68: Напишите программу 
// вычисления функции Аккермана с 
// помощью рекурсии. Даны два 
// неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Akkerman = Akk(m, n);

// Console.Write($"Результат функции Аккермана = {Akkerman} ");

// int Akk(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return Akk(m - 1, 1);
//     else return Akk(m - 1, Akk(m, n - 1));
// }

// _______________________________________________________________________________________