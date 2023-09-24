//Двумерные массивы.

// string[,] table = new string[2, 5]; //таблица строк (string)

/* 
string. Empty - для строк инициализация происходит такой константой. Т.е. пустая строка.
table[0,0] table[0,1] table[0,2] table[0,4] - максимум 5 столбиков (максимум до 4-ех)
table[1,0] table[1,1] table[1,2] table[1,4] - меняется индекст строки

/*
table[1, 2]="word"; //table-наименование массива, [1, 2] - 1 - строка; 2 - столбцы

for (int rows = 0; rows < 2; rows++) //счетчик называется "rows"
{
    for(int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/


//то же самое с числами
using System.Globalization;
using System.Linq.Expressions;

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); //[1,10]
        }
    }
}
int[,] matrix = new int[3, 4]; //3 строки, 4 столбца
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);