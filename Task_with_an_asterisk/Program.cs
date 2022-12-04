// Дополнительная задача (задача со звёздочкой): Напишите программу, 
// которая на вход принимает радиус круга и находит его площадь 
// округленную до целого числа, необходимо вывести максимальную цифру 
// в полученном округлённом значении площади круга.
// 10 -> 4
// 20 -> 7
// 30 -> 8
//S = пи * r2

Console.Write("Введите число: ");
int radius = Convert.ToInt32(Console.ReadLine());

double FindAreaOfCircle(int rad)
{
    double pi = 3.14;
    double s = pi * Math.Pow(rad, 2);
    double res = Math.Round(s, 0, MidpointRounding.ToZero);
    return res;
}

double resultat = FindAreaOfCircle(radius);
string str = resultat.ToString();
int[] array1 = new int[str.Length];

int FindMaximum(int[] array)
{
    int length = array.Length;
    int max = 0;

    for (int i = 0; i < length; i++)
    {
        array[i] = int.Parse(str[i].ToString());
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int resultat2 = FindMaximum(array1);

Console.WriteLine($"{resultat2}");