Console.WriteLine("Введите кол-во строк:");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int col = int.Parse(Console.ReadLine());

int[,] array = new int[row, col];

Random r = new Random();
Console.WriteLine("Вывод первой полученной матрицы:");
int sum = 0;


for (int i = 0; i < row; i++)
{

    for (int j = 0; j < col; j++)
    {
        array[i, j] = r.Next(10);
        Console.Write($"{array[i, j]} ");
        
    }
    Console.WriteLine();

}

Random d = new Random();
int[,] arr2d = new int[row, col];

Console.WriteLine("Вывод второй полученной матрицы:");

for (int i = 0; i < row; i++)
{

    for (int j = 0; j < col; j++)
    {
        arr2d[i, j] = d.Next(10);
        Console.Write($"{arr2d[i, j]} ");
       
    }
    Console.WriteLine();
}


int[,] arrSum = new int[row, col];
Console.WriteLine("Вывод суммы массивов:");


for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        arrSum[i, j] = arr2d[i, j] + array[i, j];
        Console.Write($"{arrSum[i, j]} ");
    }
    Console.WriteLine();
}

