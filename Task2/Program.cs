// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12]-> 19
// [-4, -6, 89, 6]-> 0

Console.WriteLine("Ввведите число:");
int number = Convert.ToInt32(Console.ReadLine());
int [] array = FillArray(number);
Console.WriteLine("Сформирован массив: [" + String.Join(", ", array) + "]");
Console.WriteLine($"Сумма элементов массива с нечетным индексом равна {SumtOfPositiveIndexes(array)}");

int[] FillArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 9);
    }
    return array;
}
int SumtOfPositiveIndexes(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}