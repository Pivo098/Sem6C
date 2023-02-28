// Задача 3: Не используя рекурсию, выведите первые 
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int InputInt(string msg)
{
    Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

int [] Fibo(int num)
{
    int[] result = new int[num];
    result[0] = 0;
    result[1] = 1;
    for (int i = 2; i < result.Length; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
    }
return result;
}
int [] fibo = Fibo(InputInt("Введите число"));
PrintArray(fibo);
