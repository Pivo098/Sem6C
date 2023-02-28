// Задача 2: Напишите программу, которая 
// будет преобразовывать десятичное число в двоичное.

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

int [] ToBinary(int num)
{
    int[] result = new int [8];
    for (int i = 7; i >= 0; i--)
    {
        result[i] = num % 2;
        num /= 2;
        if (num == 0)
        {
            break;
        }
        
    }
    return result;
}
int Number = InputInt("Введите число ");
int[] array = ToBinary(Number);
PrintArray(array);