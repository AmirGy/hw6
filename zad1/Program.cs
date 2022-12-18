// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] CraeateFillArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        int j = i + 1;
        Console.Write($"Введите {j} число: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    Console.WriteLine("Массив: ");

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    return numbers;
}

int NumbersSum(int[] numbers, int size)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] > 0)
            count+=1;
    }
    Console.Write($"Количество положительных чисел = {count}");
    return count;
}

try
{
    Console.Write("Введите количество чисел: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = CraeateFillArray(size);
    Console.WriteLine();
    NumbersSum(numbers, size);
}
catch 
{
    Console.Write("Ошибка! Введите числа.");
}
