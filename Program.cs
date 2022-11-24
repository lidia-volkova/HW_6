// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// 0, 7, 8, -2, -2 -> 2 
// 1, -7, 567, 89, 223 -> 4 
 
// int [] CreateNewArray (int size) 
// { 
//     int [] arr = new int [size]; 
//     for (int i = 0; i < size; i++) 
//     { 
//         Console.Write("Введи число для проверки "); 
//         arr[i] = Convert. ToInt32 (Console. ReadLine ()); 
//     } 
//     return arr; 
// } 
 
// void ShowArray (int [] arr) 
// { 
//     for (int i = 0; i < arr.Length; i++) 
//     { 
//         Console.Write(arr[i] + " , " ); 
//     } 
//     Console.WriteLine(); 
// } 
 
// int Resultat (int [] arr) 
// { 
//     int count = 0; 
//     for (int i = 0; i < arr.Length; i++) 
//     if (arr[i] > 0) 
//     { 
//         count = count +1; 
//     } 
//     return count; 
// } 
 
 
// Console.Write("Какое количество чисел нужно проверить:? "); 
// int m = Convert. ToInt32 (Console. ReadLine ()); 
 
// int [] positive = CreateNewArray(m); 
// ShowArray(positive); 
// int result = Resultat(positive); 
// Console.WriteLine($"количество положительных цифр равняется {result}"); 
 
                // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,  
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 
 
 
// void Intersection (int b1, int k1, int b2, int k2) 
// { 
//     double x = (b2 - b1)/(k1 - k2); 
//     Console.WriteLine($"{x}"); 
//     double y = k1 * x + b1; 
//     Console.WriteLine($"Точка пересечения прямых - {(x , y)}"); 
// } 
 
// Console.Write("Введите значение b1: "); 
// int b1 = Convert. ToInt32 (Console. ReadLine ()); 
// Console.Write("Введите значение k1: "); 
// int k1 = Convert. ToInt32 (Console. ReadLine ()); 
// Console.Write("Введите значение b2: "); 
// int b2 = Convert. ToInt32 (Console. ReadLine ()); 
// Console.Write("Введите значение k2: "); 
// int k2 = Convert. ToInt32 (Console. ReadLine ()); 
 
// Intersection ( b1,  k1,  b2,  k2);