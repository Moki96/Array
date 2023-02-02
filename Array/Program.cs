
Console.WriteLine("Введите кол-во строк:");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int col = int.Parse(Console.ReadLine());

int[,] array = new int[row, col];

Random r = new Random();
Console.WriteLine("Вывод полученной матрицы:");

int sum = 0;

for (int i = 0; i < row; i++)
{
    
    for(int j = 0; j < col; j++)
    {
        array[i, j] = r.Next(100);
        Console.Write($"{array[i, j]} ");
        sum = sum + array[i, j];

    }
    Console.WriteLine();
    
}
Console.WriteLine($"Сумма всех элементов: {sum} ");