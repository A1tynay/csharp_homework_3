// Задайте массив из вещественных чисел с ненулевой 
// дробной частью. Найдите разницу между маскимальным и 
// минимальным элементов массива.

double[] array = {2.2, 0.4, 9.11, 7.2, 78.98};

foreach (double number in array)
{
    Console.Write(number + " ");
}
System.Console.WriteLine();

double max = array[0];
double min = array[0];

for(int i = 0; i < array.Length; i++)
{
    if(max < array[i])
    {
        max = array[i];
    }
    if(min > array[i])
    {
        min = array[i];
    } 
}
System.Console.Write(max - min);
