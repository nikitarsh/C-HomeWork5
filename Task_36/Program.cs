/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] arr = new int[4]; 
RandomArray(arr);
PrintArray(arr);
int sumIndexEven = 0;

for (int i = 0; i < arr.Length; i += 2)
{
  sumIndexEven += arr[i];
}

Console.WriteLine($"Сумма нечетных элементов по индексу равна: = {sumIndexEven}");




void RandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
        Random rnd = new Random();
        int value = rnd.Next(0, 100);
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