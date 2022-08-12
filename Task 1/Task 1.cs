// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите количество элементов: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] GetArray (int size, int minRandom, int maxRandom)
{
    int [] result = new int[size];
    for (int i = 0; i < result.Length; i++) // result.Length = size
    {
        result[i] = new Random().Next(minRandom,maxRandom + 1); // [-9;9]
    }
    return result;
}

int[] array= GetArray(M, -999, 999);

Console.WriteLine($"Результат: [ {String.Join("; ", array)} ]");

int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) result++;
}

System.Console.WriteLine($"Количество чисел больше нуля: {result}");
