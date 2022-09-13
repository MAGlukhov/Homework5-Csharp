// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 101);
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

int FindTheLeast(int[] array)
{
    int minimum = array[0];
    for(int i = 0; i < size; i++)
    {
        if(array[i] < minimum) minimum = array[i];
    }
    return (minimum);
}

int FindTheBiggest(int[] array)
{
    int maximum = array[0];
    for(int i = 0; i < size; i++)
    {
        if(array[i] > maximum) maximum = array[i];
    }
    return (maximum);
}

int[] contemp = CreateArray(size);
ShowArray(contemp);
Console.WriteLine();
Console.WriteLine(FindTheBiggest(contemp) - FindTheLeast(contemp));