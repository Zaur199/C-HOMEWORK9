// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int PrintSum(int M, int N)
{
    if(N == M) return N;
    else return M + PrintSum(M + 1, N);
}
Console.WriteLine(PrintSum(1, 7));