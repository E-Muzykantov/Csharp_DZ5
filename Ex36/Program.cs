// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        array[i] = rnd.Next(-10, 11);
    }

    return array;
}

int GetSumOddIndex(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        result += array[i];
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
    Console.Write($" - > {GetSumOddIndex(array)}");
}