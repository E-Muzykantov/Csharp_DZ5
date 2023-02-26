// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

Console.Write("Введите размерность массива: ");
int num = int.Parse(Console.ReadLine());

bool ChekLength(int number)
{
    if (number <= 0)
    {
        Console.WriteLine("Размер массива не может равняться 0 или быть меньше 0");
        return false;
    }

    return true;
}

int[] GenerateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }

    return array;
}

int GetCountEvenNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }

    return result;
}

void PrintArray(int[] array)
{
    Console.Write($"[{string.Join(", ", array)}]");
}

if (ChekLength(num))
{
    int[] array = GenerateArray(num);
    PrintArray(array);
    Console.Write($" - > {GetCountEvenNumbers(array)}");
}