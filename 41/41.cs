//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int count = 0;
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
    return array;
}

void PrintArray(int[] array)
{
    foreach (int num in array)
        Console.Write($"{num} ");
    Console.WriteLine();
}

Console.WriteLine("Сколько будет чисел ?");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Напишите эти {size} чисел");
int[] array = CreateArray(size);
Console.WriteLine($"Получился массив:");
PrintArray(array);
Count(size);

int Count(int size)
{
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }

    }
    return count;
}

if (count == 0)
{
    Console.WriteLine("Нет чисел больше нуля");
}
else
{
    Console.WriteLine($"Количество чисел больше нуля - {count}");
}

