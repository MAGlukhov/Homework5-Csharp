// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 11);
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

int NotEvenElementsSum(int[] array)
{
    int result = 0;
    for(int i = 0; i < size; i++)
    {
        if(i % 2 == 1) result += array[i];
    }
    return result;
}

int[] contemp = CreateArray(size);
ShowArray(contemp);
Console.WriteLine();
Console.WriteLine(NotEvenElementsSum(contemp));