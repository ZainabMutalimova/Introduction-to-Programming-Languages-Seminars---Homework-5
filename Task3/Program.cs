// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Ввведите размер массива:");
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
    if (array.Length == 0) throw new Exception("Массив пустой");
    for (int i = 0; i < array.Length; i++)
    {
        double random = new Random().NextDouble();
        array[i] = random*(max - min) + min;
}
return array;
}
double DifferenceBetweenMaxAndMin(double[] array)
{
    double min = int.MaxValue;
    double max = int.MinValue;
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
    Console.WriteLine ($"Max = {max}");
    Console.WriteLine ($"Min = {min}");
    return max - min;
}