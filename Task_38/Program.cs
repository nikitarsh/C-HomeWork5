/* Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/


int[] arr = new int[8]; 
RandomArray(arr);
PrintArray(arr);
int max = arr[0];
int min = arr[0];


for (int i = 0; i < arr.Length; i++)
{
  if (arr[i] > max)
    {
        max = arr[i];
    }
    else if (arr[i] < min)
    {
        min = arr[i];
    }
}
Console.WriteLine($"min число = {min}");
Console.WriteLine($"max число = {max}");
Console.WriteLine($"Разница между max и min = {max-min}");




void RandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
        Random rnd = new Random();
        int value = rnd.Next(1, 100);
        arr[i] = value;
    }
}


void PrintArray(int [] array)

{
    for(int i =0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}