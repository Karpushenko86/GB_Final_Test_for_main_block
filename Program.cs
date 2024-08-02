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

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

string[] array = new string[sizeArray];
for (int i = 0; i < sizeArray; i++)
{
    Console.Write($"Введите {i}-й элемент массива: ");

    array[i] = Console.ReadLine();
}

// string[] array1 = {"Hello", "2", "world", ":-)"};
// string[] array2 = {"1234", "1567", "-2", "computer science"};
// string[] array3 = {"Russia", "Denamrk", "Kazan"};
// string[] array4 = {"", "", ""};

PrintArray(array);
Console.Write(" => ");
PrintArray(LessThreeArray(array));
Console.WriteLine();

// PrintArray(array1);
// Console.Write(" => ");
// PrintArray(LessThreeArray(array1));
// Console.WriteLine();

// PrintArray(array2);
// Console.Write(" => ");
// PrintArray(LessThreeArray(array2));
// Console.WriteLine(); 

// PrintArray(array3);
// Console.Write(" => ");
// PrintArray(LessThreeArray(array3));
// Console.WriteLine();

// PrintArray(array4);
// Console.Write(" => ");
// PrintArray(LessThreeArray(array4));
// Console.WriteLine();