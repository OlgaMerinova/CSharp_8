//Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


int m = InputNumbers("Введите количество строк и столбцов для квадратных матриц: ");

int[,] firstMartrix = new int[m, m];
CreateArray(firstMartrix);
Console.WriteLine($" Первая матрица:");
WriteArray(firstMartrix);

int[,] secondMartrix = new int[m, m];
CreateArray(secondMartrix);
Console.WriteLine($" Вторая матрица:");
WriteArray(secondMartrix);

int[,] resultMatrix = new int[m,m];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($" Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      sum = sum + (firstMartrix[i,j] * secondMartrix[i,j]);
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}