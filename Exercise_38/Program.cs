// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[new Random().Next(1, 10)];
int minRandomNumber = 1;
int maxRandomNumber = 10;

int min = maxRandomNumber;
int max = minRandomNumber;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(minRandomNumber, maxRandomNumber + 1);
    if (max < array[i]) max = array[i];
    if (min > array[i]) min = array[i];
}
Console.WriteLine($"[{String.Join(",\t", array)}]");
Console.WriteLine($"Разница между max ({max}) и min ({min}) = {max - min}");