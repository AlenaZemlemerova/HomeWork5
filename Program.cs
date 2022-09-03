int Exercice34()
{
    //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    //Напишите программу, которая покажет количество чётных чисел в массиве.

    int size = 10;
    int count = 0;
    int[] array = new int[size];
    fillingArray(array, 100, 1000);
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    showArray(array);
    Console.WriteLine($"Количество четных чисел: {count}");
    return count;
}

int Exercice36()
{
    //Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    //Найдите сумму элементов, стоящих на нечётных позициях.

    int size = 10;
    int sum = 0;
    int[] array = new int[size];
    fillingArray(array, 1, 11);

    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    showArray(array);
    System.Console.WriteLine($"Сумма: {sum}");
    return sum;
}

double Exercice38()
{
    //Задача 38: Задайте массив вещественных чисел. 
    //Найдите разницу между максимальным и минимальным элементов массива.

    int size = 5;
    double[] array = new double[size];
    double max = array[0];
    double min = array[0];
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble() *1000 - 100, 2);
    }

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "   ");
    } 
    Console.WriteLine();

    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    double dif = Math.Round(max - min, 2);
    Console.WriteLine($"Разнима между максимальным и минимальным значением: {dif}");
    
    return dif;
}

void fillingArray(int[] array, int minValue, int maxValue)
{
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(minValue, maxValue);
    }
}

void showArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Exercice34();
Exercice36();
Exercice38();