// Задать массив вещественных чисел. Найти разницу между максимальным и минимальным элементом массива.

int size = 11;
double[] FillSourceArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 10;
    }
    return array;
}
void PrintDiffMinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    double diff = arr.Max() - arr.Min();
    Console.WriteLine($"Минимальный элемент массива равен {arr.Min()}");
    Console.WriteLine($"Максимальный элемент массива равен {arr.Max()}");
    Console.WriteLine($"Разница между минимумом и максимумом равна {diff}");
    Console.WriteLine();
}
PrintDiffMinMax(FillSourceArray(size));
Console.WriteLine();