/* Имеется список чисел. 
Создайте список, в который попадают числа, описывающие максимальную возрастающую последовательность. 
Порядок элементов менять нельзя.
Одно число - это не последовательность.
[1, 5, 2, 3, 4, 6, 1, 7] => [1, 7]
[1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5]
[1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5]*/

// int[] CraeateFillArray(int size)
// {
//     int[] numbers = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         int j = i + 1;
//         Console.Write($"Введите {j} число: ");
//         numbers[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     Console.WriteLine();
//     Console.WriteLine("Список: ");
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{numbers[i]} ");
//     }
//     return numbers;
// }

// int max = 0;
// int min = 1000;

// int FindMaxMin(int[] Line, int size)
// {
//     for (int j = 0; j < size; j++)
//     {
//         if (max < Line[j])
//             max = Line[j];
//         if (min > Line[j])
//             min = Line[j];
//     }
//     return max;
// }

// Console.Write("Введите количество чисел: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = CraeateFillArray(size);
// Console.WriteLine();
// FindMaxMin(numbers, size);
// Console.WriteLine($"Максимальный элемент = {max}");
// Console.WriteLine($"Минимальный элемент = {min}");

// int[] numbers = { 3, 1, 5, 7, 6 };
// int min = 1;
// int j = 0;
// int countMVP = 1;
// int MVPmin = 0;
// int num = 2;
// for (int ind = 0; ind < 5; ind++)
// {
//     for (int i = 0; i < 5; i++)
//     {
//         if (min + 1 == numbers[i])
//             j = numbers[i];
//     }
//     if (j == 0)
//     {
//         for (int i = 0; i < 5; i++)
//         {
//             for (int index = 0; index < 5; index++)
//             {
//                 if (min + num == numbers[index])
//                     min += num;
//             }
//             if(min+num != numbers[index])
//                 num++;
//         }
//     }
//     else if (j == min + 1)
//     {
//         MVPmin = min;
//         countMVP += 1;
//         min = j;
//         j = 0;
//     }
// }


// Console.Write(countMVP);

int[] numbers = { 3, 2, 5, 4, 13 };
int size = numbers.Length;
int min = 1;
int max = 13;
int count = 0;
for (int j = 0; j < size; j++)
{
    for (int i = 0; i < size; i++)
    {
        if (numbers[j] + 1 == numbers[i])
        {
            count += 1;
            j = i;
            if (count <= 1)
                min = numbers[j];
        }
    }
}
Console.Write($"{min}, {max}");
