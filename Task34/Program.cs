// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] createdArray)
{
    for(int i = 0; i < size; i++)
    {
        Console.Write(createdArray[i] + " ");
    }
}

int IsEvenElements(int[] shownArray)
{
    int sum = 0;
    for(int i = 0; i < size; i++)
    {
        if(shownArray[i] % 2 == 0) sum ++;
    }
    return sum;
}

int[] generatedArray = CreateArray(size);
ShowArray(generatedArray);
Console.WriteLine();
Console.WriteLine(IsEvenElements(generatedArray));

