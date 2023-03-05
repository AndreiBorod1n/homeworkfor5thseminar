// 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32 (Console.ReadLine());
int[] arr = new int[n];
int summ = 0;
Console.Write("Массив: ");
for (int index = 0; index < n; index++)
{
    arr[index] = new Random().Next(0,100);
    Console.Write(arr[index]);
    Console.Write(' ');
    if(index % 2 != 0) summ = summ + arr[index];
    arr[index] = index + 1;
}
Console.WriteLine(' ');
Console.Write($"Сумма чисел нечетных элементов равна: {summ}");


