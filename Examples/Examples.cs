// int[] GetArray (int size, int minRandom, int maxRandom)
// {
//     int [] result = new int[size];
//     for (int i = 0; i < result.Length; i++) // result.Length = size
//     {
//         result[i] = new Random().Next(minRandom,maxRandom + 1); // [-9;9]
//     }
//     return result;
// }

// int[] GetArray (int size, int 
// int [] array = GetArray(12,-9,9);
// Console.WriteLine($"Результат: [ {String.Join("; ", array)} ]");

// int resultPositive = 0;

// int resultNegative = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0) resultPositive+=array[i]; //resultPositive = resultPositive + array[i]
//     else resultNegative+=array[i];              //resultNegative=resultNegative+array[i]
// }

// System.Console.WriteLine($"Сумма положительных чисел: {resultPositive} ");
// System.Console.WriteLine($"Сумма отрицательных чисел: {resultNegative} ");

// int [] array = {-2,-1,1,2};
// for (int i = 0; i < array.Length; i++)
// {
//     array [i]*= (-1); 
//     Console.Write(array [i] + " " );
// }
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int [] array = {-2,-1,1,2};
// int number = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < array.Length; i++)
// {
//     if (number == array[i]) Console.WriteLine("Элемент присутствует!");
//     else Console.WriteLine("Такого элемента нет!");
   
// }
// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] GetArray (int size, int minRandom, int maxRandom)
// {
//     int [] result = new int[size];
//     for (int i = 0; i < result.Length; i++) // result.Length = size
//     {
//         result[i] = new Random().Next(minRandom,maxRandom + 1); // [-9;9]
//     }
//     return result;
// }

// int [] array = GetArray(12,0,999);
// Console.WriteLine($"Результат: [ {String.Join("; ", array)} ]");
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] >= 10 && array[i] <=99) count++;
    
// }
// Console.WriteLine($"Результат: {count}");


// int[] array = { -3, -2, -1, 0, 1, 2, 3 };

// int searchNumber = new Random().Next(-5, 6); //[-5;5] 

// Console.WriteLine($"Рандомное число для поиска: {searchNumber}");

// bool flagResult = false; // false - элемента нет, true - элемент есть

// for (int i = 0; i < array.Length; i++)
// {
//     if (searchNumber == array[i]) 
//     {
//         flagResult = true;
//         break;
//     }
// }
// if (flagResult) Console.WriteLine($"Элемент {searchNumber} присутствует в массиве ");
// else Console.WriteLine($"Элемент {searchNumber} НЕ присутствует в массиве ");
