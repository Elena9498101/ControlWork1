// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("введите группы символов различной длины в количестве {lenght}, после ввода каждой группы символов нажмите Enter");

int length = 5;
string[] arr1 = new string[length];

void PrintArray(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {

        Console.Write($"\"{arr[i]}\"" + " ");
    }
    Console.Write(" ]");
}

void FillingArr(string[] arr)  // ввод данных с клавиатуры
{
    for (int i = 0; i < length; i++)
    {
        arr[i] = Console.ReadLine();
    }
}

FillingArr(arr1);
PrintArray(arr1);
Console.Write("->");

int CreatNewArr(string[] arr)   // создание нового массива
{
    int lengthNew = 0;
    for (int i = 0; i < length; i++)
    {
        if (arr[i].Length < 4)
        {
            lengthNew++;
        }
    }
    return lengthNew;
}

if (CreatNewArr(arr1) == 0) Console.WriteLine("нет элементов для нового массива");
else
{
    string[] arr2 = TransferNewElements(arr1);
    PrintArray(arr2);
}

string[] TransferNewElements(string[] arr)   // перенос данных в новый массив
{
    string[] arr2 = new string[CreatNewArr(arr1)];
    for (int i = 0, n = 0; i < length; i++)
    {
        if (arr[i].Length < 4)
        {
            arr2[n] = arr[i];
            n++;
        }
    }
    return arr2;
}