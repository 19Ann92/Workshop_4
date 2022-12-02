// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] FillingArray(int n)
{
    Random rnd = new Random();
    int[] arr = new int[n];
    for(int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(1,100);
    }
    return arr;
}

int[] arr = FillingArray(8);
Console.Write("[");
Console.Write(String.Join(", ", arr));
Console.Write("]");
