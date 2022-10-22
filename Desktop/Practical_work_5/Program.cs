// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = new int [10];
CreateArray(array);
PrintArray(array);
int count1 = EvenNumbers(array);
Console.WriteLine($"\nКолличество четных чисел в массиве: \"{count1}\"");
int EvenNumbers(int[] array)
{int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0)
    count++;
    }
    return count;
}
void CreateArray(int[] array)
{
 Random randgenerator = new Random();
 for (int i = 0; i < 10; i++)
 {
    array[i] =randgenerator.Next(100,1000);
 }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int[] array = new int[5];
// CreateArray(array);
// PrintArray(array);
// int count1 = nonEvenNumbers(array);
// Console.WriteLine($"\nСумма не четных чисел в массиве: \"{count1}\"");
// int nonEvenNumbers(int[] array)
// {int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//     if (array[i] % 2 == 1)
//     sum+=array[i];
//     }
//     return sum;
// }
// void CreateArray(int[] array)
// {
//  Random randgenerator = new Random();
//  for (int i = 0; i < 5; i++)
//  {
//     array[i] =randgenerator.Next(1,10);
//  }
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3,21 7,04 22,93 -2,71 78,24] -> max = 78,24, min = - 2,71, difference = 80,95

double[] arrayRealNumbers = new double[10];
CreateArray(arrayRealNumbers);
void CreateArray(double[] arrayRealNumbers)
{
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNumbers[i] + " ");
  }
}

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];
  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }
  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");

