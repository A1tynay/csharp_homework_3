// Задайте одномерный массив из 10 целых чисел от 1
// до 100. Найдите количество элементов массива, 
// значение котрых лежат в отрезке [20, 90]

int[] array = {2, 13, 33, 56, 89, 96, 23, 8, 90, 76};

foreach (int number in array)
{
    Console.Write(number + " ");
}
System.Console.WriteLine();

for(int i = 0; i < array.Length; i++)
{
    if(20 < array[i] && array[i] < 90)
    {
        System.Console.Write(i);
    }
}