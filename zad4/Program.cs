/* Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
Вывести на экран красивенько таблицей. 
Найти минимальное число и его индекс, найти максимальное число и его индекс. 
Вывести эту информацию на экран.*/


int[,] CreateArray(int lines, int columns)
{
    int[,] table = new int[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            table[i, j] = new Random().Next(1, 100);
        }
    }
    return table;
}

void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FindMaxMin(int[,] table)
{
    int max = 0;
    int min = 1000;
    int IndLineMax = 0;
    int IndColumnsMax = 0;
    int IndLineMin= 0;
    int IndColumnsMin = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (max < table[i, j])
            {
                max = table[i, j];
                IndLineMax = i;
                IndColumnsMax = j;
            }
            else if (min > table[i, j])
            {
                min = table[i, j];
                IndLineMin = i;
                IndColumnsMin = j;
            }
        }
    }
    Console.WriteLine($"Максимальный элемент = {max}");
    Console.WriteLine($"Индекс максимального элемента = ({IndLineMax};{IndColumnsMax})");
    Console.WriteLine($"Минимальный элемент = {min}");
    Console.WriteLine($"Индекс минимального элемента = ({IndLineMin};{IndColumnsMin})");
}

Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] table = CreateArray(lines, columns);
PrintArray(table);
FindMaxMin(table);