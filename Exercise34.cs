// 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] arr = new int[3];
int value = 0;
for (int index = 0; index < 3; index++)
{
    arr[index] = new Random().Next(100,1000);
    Console.Write(arr[index]);
    Console.Write(' ');
    if(arr[index] % 2 == 0) value++;
    arr[index] = index + 1;
}
Console.WriteLine(value);

