
// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("ВВедите колличество  вводимых чисел: " );
string input = Console.ReadLine();
int number = int.Parse(input);
int[] array = new int[number];
CreateArray(array);
int count1 = checkNumbers(array);
Console.WriteLine($"\nКолличество введенных чисел  > 0 : \"{count1}\"");
void CreateArray(int[] array)
{
 for (int i = 0; i < array.Length; i++)
 {  Console.WriteLine($"ВВедите элемент массива c индексом {i}: " );
    array[i] = int.Parse(Console.ReadLine());

 }
var str = string.Join(" ", array);
    Console.WriteLine(str);
}
int checkNumbers(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if  (array[i] > 0) count++;
}
return count;
}



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


//    {
//     Console.Write("Введите b1: ");
//     double b1 = double.Parse(Console.ReadLine() ?? "0");
//     Console.Write("Введите k1: ");
//     double k1 = double.Parse(Console.ReadLine() ?? "0");
//     Console.Write("Введите b2: ");
//     double b2 = double.Parse(Console.ReadLine() ?? "0");
//     Console.Write("Введите k2: ");
//     double k2 = double.Parse(Console.ReadLine() ?? "0");

//     double x = (b2 - b1) / (k1 - k2);
//     Console.WriteLine("x = " + x);
//     double y = k1 * x + b1;
//     Console.WriteLine("y = " + y);
//     Console.WriteLine($"Точка пересечения с координатами: ({x}; {y})");

//     Console.ReadKey();
// }
