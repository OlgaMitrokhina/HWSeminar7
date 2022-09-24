//задайте двумерный массив размером m на n заполненный случайными вещественными числами

// БЕЗ МЕТОДОВ
// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("m =" + m.ToString() + " n =" + n.ToString());
// //Console.ReadLine();
// double[,] array = new double[m, n];

// Random random = new Random();

// for (int i = 0; i < m; i++)
// {
// for (int j = 0; j < n; j++)
// {
// array[i, j] = random.NextDouble(); // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
// Console.Write("{0,6:F2}", array[i, j]);
// }
// Console.WriteLine();

// }
// Console.ReadLine();


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    double [,] matrix = new double[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(rand.NextDouble()*20 - 10, 1);
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
double [,] matr = GetMatrix(m, n);
Console.WriteLine("Рандомный двумерный массив из вещественных чисел: ");
PrintMatrix(matr);


