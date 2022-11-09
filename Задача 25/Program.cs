//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int GetPow(int A, int B)
{
    int res = A;
    for (int i = 1; i < B; i++)
    {
        res = res*A;
    }
    return res;
}
int N = int.Parse(Console.ReadLine()!);
int M = int.Parse(Console.ReadLine()!);
Console.Write(GetPow(N, M));
