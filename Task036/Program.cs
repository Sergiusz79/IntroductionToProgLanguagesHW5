// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов с нечётными индексами.

void FillArray(int[] array)
{
int lngt = array.Length;
int index = 0;                  
    while (index < lngt)
    {
    array[index] = new Random().Next(0, 10);
    index++;
    }
}

void PrintArray(int[] array)
{
int lngt = array.Length;
int index = 0;
    while (index < lngt)
    {
    Console.Write($"{array[index]} ");
    index++;
    }
Console.WriteLine();
}

void FindSumOddIn(int[] array)
{
    int sum = 0;
    for (int index = 1; index < array.Length; index = index + 2)
    {
        sum = sum + array[index]; 
    }
    Console.WriteLine($"Sum of elements with odd indices {sum} ");
}


int[] array = new int [10];
FillArray(array);
PrintArray(array);
FindSumOddIn(array);
