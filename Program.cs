void FillArray(double[,] matr) // Заполнение массива рандомными данными
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void PrintArray(double[,] matr) // Создание матрицы 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число (количество строк): ");
int val1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число (количество столбцов): ");
int val2 = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[val1, val2];
FillArray(array);
PrintArray(array);