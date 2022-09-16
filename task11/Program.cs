//Задача 1: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Номер строки с наименьшей суммой элементов: 1 строка
//(допускается указывать индекс строки в массиве, в данном примере - 0)

Console.Write("введите количество строк: ");
int strsCount = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int columnsCount = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int [strsCount, columnsCount];
Random rnd = new Random();


for (int i=0; i<strsCount; i++)
{
    for (int j=0; j<columnsCount; j++)
    {
        arr[i,j] = new Random().Next(1, 20);
        Console.Write($"{arr[i, j]} ");
    }
Console.WriteLine();
}
Console.WriteLine("---------------------------");

int MinSum = 0;
int index = 0;
for (int i=0; i<arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j=0; j<arr.GetLength(1); j++)
    {
        sum = sum + arr[i,j];
    }
    Console.WriteLine($" Сумма {i+1} строки = {sum} ");
    if (i == 0)
    {
        MinSum = sum;
    }
    else if (sum < MinSum)
    {
        MinSum = sum;
        index = i;
    }

}
Console.Write($" Сумма {index+1} строки с наименьшей суммой = {MinSum} ");
Console.ReadLine();

