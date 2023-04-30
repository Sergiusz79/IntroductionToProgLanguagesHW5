// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


void FillArray(int[] array)
{
int lngt = array.Length;
int index = 0;                  
    while (index < lngt)
    {
    array[index] = new Random().Next(100, 1000);
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

void FindNumbers(int[] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array [index] % 2 == 0) {count++;}    
    }
    Console.WriteLine($"Total number of even numbers {count}");
}



int[] array = new int [10];
FillArray(array);
PrintArray(array);
FindNumbers(array);

