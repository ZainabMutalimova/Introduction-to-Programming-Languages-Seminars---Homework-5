// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Ввведите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите минимальный предел:");
double min = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Ввведите максимальный предел:");
double max = Convert.ToInt64(Console.ReadLine());
double[] array = FillArray(number, min, max);
Console.WriteLine("Сформирован массив: [" + String.Join(", ", array) + "]");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {DifferenceBetweenMaxAndMin(array)}");

double[] FillArray(int number, double min, double max)
{
    double[] array = new double[number];
    for (int i = 0; i < array.Length; i++)
    {
        double random = new Random().NextDouble;
        array[i] = random*(max - min) + min;
}
return array;
}
double DifferenceBetweenMaxAndMin(double[] array)
{
    double min = 0;
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max - min;
}