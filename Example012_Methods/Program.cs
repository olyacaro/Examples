// Вид 1 (Пример метода, который ничего не возвращает и ничего не принимает)

using System.Reflection.Metadata;
using System.Xml;

void Method1()
{
    Console.WriteLine("Автор Гайер Ольга...");
}
//Method1();


/* Вид 2 (Пример метода, который ничего не возвращает
но может возвращать какие-то аргументы).*/

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Текст", count: 4); 
// Method21(count: 4, msg: "новый текст"); 
// count 4 - это означает сколько раз пользователь хочет увидеть данное сообщение ("Текст" 4 раза).

// Вид 3 (Пример метода, который что-то возвращает но ничего не принимает).

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);

// Вид 4 (Пример метода, который что-то принимает и что-то возвращает)

/* string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
} 

string res = Method4(10, "z");
Console.WriteLine(res); */

// Вид 4 - дубль но с цыклом "for":

string Method4(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}

string res = Method4(10, "z");
// Console.WriteLine(res);

// Циклы и не только While. Есть еще for и цикл в цикле.


/* for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
*/


/* Задача: 
Дан текст. 
В тексте нужно все пробелы заменить черточками, 
маленькие буквы “к” заменить большими “К”, 
а большие “С” заменить маленькими “с”. */
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// то есть s[3] = "r"

string Replace(string text, char oldValue, char newValue) //Replace - условно 4-ый вид методов
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

//string newText = Replace(text, ' ', '|');
//Console.WriteLine(newText);
//Console.WriteLine();
//newText = Replace(newText, 'к', 'К'); //Заменили символы.
//Console.WriteLine(newText);

// Упорядочить массив – это как?

int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for(int j = i + 1 ; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
