/*Теперь надо потренировать синтаксис языка.
Сейчас перепишем этот код с использованием генератора псевдослучайных чисел с использованием методов. 
Мы потренируем то, каким образом можно взять, 
например, метод, передать в него массив и заполнить массив нужным количеством элементов. 
На следующем этапе опишем метод, который будет выводить все элементы по порядку. 
Затем превратим наш код поиска нужного индекса в метод.*/

void FillArray(int[] collection)
//void - это когда метод ничего не возвращает.
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        //index = index +1;
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

//Метод IndexOf.
/*Мы попробовали написать свои первые методы: 
метод заполнения массива и метод его печати на экран. 
Теперь попробуем адаптировать решение предыдущей задачи, 
в которой находили нужные элементы и позицию нужного элемента в массиве.*/

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; 
    //"-1" или "-2" (неважно) то есть такой элемент (то есть несществующий) не найден.
    //Например если в массив мы завели 10 значений и пытаемся найти значение 444
    //благодаря вводу "-1" на вызходе программа выведет -1 или -2 что означвет что такой элемент не найден.
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int [10];

FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);
// new int означает - создай новый массив в котором будет 10 элементов.

