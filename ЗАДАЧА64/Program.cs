// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void PrintSomeNumbers(int M, int N)
{
    if(N < M) return;
    PrintSomeNumbers(M, N - 1);
    Console.Write(N + " ");
}
PrintSomeNumbers(1, 9);