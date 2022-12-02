// Задача 27: Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int FindSumOfDigitsOfNumber(int num)
{
    int sum = 0;
    for (int i = 0; i < 10; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine(FindSumOfDigitsOfNumber(num));