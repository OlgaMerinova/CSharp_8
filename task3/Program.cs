//Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). 
//Напишите программу, которая будет построчно выводить массив.
//Вариант создания функции:
//Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
//Пример:
//Массив размером 3 x 3
//10 11 55
//33 41 23
//17 28 34


int arraySizeX = 3;
int arraySizeY = 3;
int minNumber = 10;
int maxNumber = 99;
int[,] testArray = new int[arraySizeX,arraySizeY];

Console.Clear();
FillArrayRandomNumber(testArray, minNumber, maxNumber);
PrintArrayWithIdex(testArray);

void FillArrayRandomNumber(int[,] array, int minNumber = 0, int maxNumber = 9)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            while (array[i, j] == 0)
            {
                int number = rand.Next(minNumber, maxNumber + 1);
                if (IsNumberInArray(array, number) == false)
                {
                    array[i, j] = number;
                }
            }
        }
    }
}


bool IsNumberInArray(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number) return true;
        }
    }
    return false;
}

   


void PrintArrayWithIdex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           
            Console.Write(array[i, j]);
            Console.Write("({0},{1})\t", i, j);
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}
