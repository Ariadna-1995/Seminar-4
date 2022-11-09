//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int GetSum(int A)
{
    int sum = 0;   
    while(A > 0)
    {
        sum = sum + A%10;
        A = A/10;        
    }
    return sum;
}
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSum(N));
