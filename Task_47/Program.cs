//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

string str = "";
int [] num;
int number = 0;
double [,] array2d;
string EnteringAnArrayOfNumbersFromTheKeyboard()
    {
        Console.WriteLine("Введите через запятую попорядку количество строк, столбцов: m, n");
        string? str= Console.ReadLine();
        Console.WriteLine();
        return str!;
    }
int [] ConvertingStringArrayNumbers(string str)
{
    string[] strnum = str!.Split(new char[] { ',' });
    int [] num = new int [strnum.Length];
    for(int i =0; i < strnum.Length; i++)
        {
            if(int.TryParse(strnum[i],out number) == true)
                {
                    num[i] = number;
                }
            else
                {
                    Console.WriteLine("Введено не число.Выход из программы");
                    break;
                }
            if(strnum.Length < 2)
                {
                    Console.WriteLine("Введены не все числа.Выход из программы");
                    break;   
                } 
            else if(strnum.Length > 2)
                {
                    Console.WriteLine("Введенo чисел больше чем нужно.Выход из программы");
                    break;   
                }              
        }
    return num;
}
double [,] CreatingArrayArealNumbers(int [] num)
{
    Random rand = new Random();
    double [,] array2d = new double [num[0], num[1]];
    for (int i = 0; i < num[0]; i++)
    {
        for (int j = 0; j < num[1]; j++)
        {
            array2d[i, j]= rand.Next(1,100) + rand.NextDouble();
        }
    }
    return array2d;
}
void PrintArray2d(double [,] array2d, int [] num)
{
    for (int i = 0; i < num[0]; i++)
    {
        for (int j = 0; j < num[1]; j++)
        {
            Console.Write(array2d[i, j]   + "\t");
        }
        Console.WriteLine();
    }  
}
str = EnteringAnArrayOfNumbersFromTheKeyboard();
num = ConvertingStringArrayNumbers(str);
array2d = CreatingArrayArealNumbers(num);
PrintArray2d(array2d, num);