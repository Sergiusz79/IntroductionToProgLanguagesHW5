// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


void FillArray(int[] array)
{
Random rand = new Random();    
    for (int index = 0; index < array.Length; index++)
    {
    array[index] = rand.Next(100, 1000);
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

void FindNumbers(int[] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array [index] % 2 == 0) {count++;}    
    }
    Console.WriteLine($"Total number of even numbers {count}");
}

void Task034()
{
int[] array = new int [10];
FillArray(array);
PrintArray(array);
FindNumbers(array);
}

Task034();
