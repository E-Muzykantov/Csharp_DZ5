// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

double[] GenerateArray(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.Next(-10, 11) + rnd.NextDouble(), 2);
    }

    return array;
}

double GetMaxValue(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }

    return max;
}

double GetMinValue(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length;i++)
    {
        if (array[i] < min) min = array[i];
    }

    return min;
}

void PrintArray(double[] array)
{
    Console.Write($"[{string.Join(" | ", array)}]");
}

if (ChekLength(num))
{
    double[] array = GenerateArray(num);
    PrintArray(array);
    Console.Write($" -> {Math.Round(GetMaxValue(array) - GetMinValue(array), 2)} (max = {GetMaxValue(array)} min = {GetMinValue(array)})");
}