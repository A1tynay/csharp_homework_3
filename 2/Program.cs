// Задайте массив на 10 целых чисел. Напишите программу
// котрая определяет количество четных чисел в массиве

int[] array = {2, 13, 33, 56, 89, 96, 23, 8, 90, 76};

foreach (int number in array)
{
    Console.Write(number + " ");
}
System.Console.WriteLine();

for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
