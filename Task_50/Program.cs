//Задача 50. Напишите программу, которая на вход принимает число, возвращает индексы этого элемента в двумерном массиве или же указание, что такого числа нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4




Console.WriteLine("Введите число сторок массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число в массиве");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] array2d = new int[m, n];
int count = 0;
int [,] CreateNewArray(int m, int n)
{ 
    Random rand = new Random();
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array2d[i, j] = rand.Next(0,100);
        }
    }
    return array2d;
}
void ArrayPrint(int [,] array2d)
{
        for(int i = 0; i < m; i++)
    {
        for(int j = 0; j< n; j++)
        {
            System.Console.Write(array2d[i, j] + "\t");
        }
        Console.WriteLine();
    }
    
}
void SearchingArrayElement(int [,]array2d, int num)
{
        for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            if(array2d[i, j] == num)
            {
                Console.WriteLine($"Этот Элемент имеет индекс {i}, {j}.");
                count++;
            }

        }
    }
    if(count == 0)
    {
        Console.WriteLine($"Такого элемента в массиве нет.");   
    }
}

array2d = CreateNewArray(m, n);
ArrayPrint(array2d);
Console.WriteLine();
SearchingArrayElement(array2d, num);