// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];


var newArray = FillArray(array);
PrintArray(newArray);

int[] FillArray(int[] arr)
{
    var result = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        result[i] = new Random().Next(0, 40);
    }
    return result;
}

void PrintArray(int[] arr)
{
    for(int i =0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}