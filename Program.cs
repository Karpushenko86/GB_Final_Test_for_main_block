// Задача: 
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
//
// Пример: 
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
// 
// Пример от себя:
// [“”, “”, “”] → [ , , ]

string[] LessThreeArray(string[] array)
{
    int count = 0;
    string[] tempArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            tempArray[count] = array[i];
            count++;
        }
    }

    string[] newArray = new string[count];

    for (int i = 0; i < count; i++)
    {
        newArray[i] = tempArray[i];
    }

    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");

    if(array.Length > 0)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"\"{array[i]}\",");
        }
        Console.Write($"\"{array[array.Length - 1]}\"]");
    }
    else {Console.Write("]");}
}