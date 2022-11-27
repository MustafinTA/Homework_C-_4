// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Сумма всех цифр = ");
Console.Write(GetSum(num));

int GetSum(int num1)
{
    int sum = 0;
    while (num1 > 0)
    {
        sum += num1 % 10;
        num1 /= 10;
    }
    return sum;
}
