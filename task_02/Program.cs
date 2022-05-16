// Задать одномерный массив, заполненный случайными числами. 
// Найти сумму элементов, стоящих на нечётных позициях.

int size = 11;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 99);
    }
    return array;
}

void PrintArray(int[] arr)
{
    int sum = 0;
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        Console.Write(arr[i] + " ");
        if (i % 2 > 0) sum += arr[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов на нечётной позиции равна {sum} ");
    Console.WriteLine();
}

PrintArray(FillArray(size));
