// Задача 38: Задайте массив ВЕЩЕСТВЕННЫХ чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.


void FillArray(double[] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round
        (rnd.Next(-9, 10) + rnd.NextDouble(), 2);
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FindDiffMaxMin(double[] array)
{
    double max = array[0]; double min = array[1];

    if (max < min) min = array[0]; max = array[1];
    
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];  
        
        if (array[i] < min) min = array[i];
    }

    double dif = Math.Round(max - min, 2); 
    Console.WriteLine($"Difference between minimum and maximum: {dif} ");
}

void Task038()
{
double[] array = new double [10];
FillArray(array);
PrintArray(array);
FindDiffMaxMin(array);
}

Task038();