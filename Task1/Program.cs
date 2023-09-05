// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Ввведите число:");
int number = Convert.ToInt32(Console.ReadLine());
int [] array = FillArray(number);
Console.WriteLine("Сформирован массив: [" + String.Join(", ", array) + "]");
Console.WriteLine($"Количество четных элементов массива равно {CountOfPositive(array)}");

int[] FillArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
int CountOfPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}