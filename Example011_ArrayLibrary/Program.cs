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



int[] array = new int [10];
FillArray(array);
PrintArray(array);
// new int означает - создай новый массив в котором будет 10 элементов.

