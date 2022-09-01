// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = new int[4]; 
int count = 0;
RandomArray(arr);
PrintArray(arr);


for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    count++;
}

Console.WriteLine($"Количество чётных чисел в массиве: {count}");


void RandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
        Random rnd = new Random();
        int value = rnd.Next(100, 1000);
        arr[i] = value;
    }
}


void PrintArray(int [] array)

{
    for(int i =0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
    Console.WriteLine();
}
