// Задача 25 
//  Используя определение степени числа, напишите цикл,
// который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



// int a = ReadInt("Введите число A: ");
// int b = ReadInt("Введите число B: ");
// ToDegree(a, b);

// void ToDegree(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine(result);
// }

// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


// Задача 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int number = ReadInt("Введите число: ");
// int len = NumberLen(number);
// SumNumbers(number, len);

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int NumberLen(int x )
// {
//     int index = 0;
//     while (x > 0)
//     {
//         x /= 10;
//         index++;
//     }
//     return index;
// }

// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine(sum);
// }

// Задача 29 
// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

// int[] nums = { -2, 1, -13, 7, 22, -5, 19, 34 };
 
// int temp;
// for (int i = 0; i < nums.Length - 1; i++)
// {
//     for (int j = i + 1; j < nums.Length; j++)
//     {
//         if (nums[i] > nums[j])
//         {
//             temp = nums[i];
//             nums[i] = nums[j];
//             nums[j] = temp;
//         }
//     }
// }
 
// Console.WriteLine("Вывод отсортированного массива");
// for (int i = 0; i < nums.Length; i++)
// {
//     Console.WriteLine(nums[i]);
// }