int [,] arr;
int [,] CreateArray2d()
{
    Console.WriteLine("Введите поочередно m и n");
    int m =  Convert.ToInt32(Console.ReadLine());
    int n =  Convert.ToInt32(Console.ReadLine());
    int [,] array2d = new int [m,n];
    Console.WriteLine();
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array2d[i, j] = rand.Next(1, 100);
        }
    }
    return array2d;
}
void PrintArray2d(int [,] arr)
{
        for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }   
}
void ArithmeticMean(int [,] arr)
{   
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i,j];
        }
        Console.Write($"{sum / arr.GetLength(0)} \t");
    }
    Console.WriteLine();

}

arr = CreateArray2d();
PrintArray2d(arr);
Console.WriteLine();
ArithmeticMean(arr);
