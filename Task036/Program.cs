// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов с нечётными индексами.

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int index = 0; index < array.Length; index++)
    {
    array[index] = rand.Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
    Console.Write($"{array[index]} ");
    }
Console.WriteLine();
}

void FindSumOddIn(int[] array)
{
    int sum = 0;
    for (int index = 1; index < array.Length; index += 2)
    {
        sum = sum + array[index]; 
    }
    Console.WriteLine($"Sum of elements with odd indices {sum} ");
}

void Task036()
{
int[] array = new int [10];
FillArray(array);
PrintArray(array);
FindSumOddIn(array);
}

Task036();