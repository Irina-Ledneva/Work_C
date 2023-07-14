// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int NumberElementsSmallerLength(string[] arr, int length)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= length) count++;
    return count;
}

string[] NewArrayElementsSmallerLength(string[] arr, int length, int count)
{
    string[] newArr = new string[count];
    for (int i = 0, j = 0; i < arr.Length; i++)
        if (arr[i].Length <= length)
        {
            newArr[j] = arr[i];
            j++;
        }
    return newArr;
}
void PrintArray(string[] array)
{
    if (array.Length == 0) Console.WriteLine("[]");
    else
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.Write(array[array.Length - 1]);
        Console.Write("]");
    }
}

string[] array = new string[] { "Russia", "Denmark", "Kazan" };
int size = 3;
int lengthNewArray = NumberElementsSmallerLength(array, size);
string[] newArray = NewArrayElementsSmallerLength(array, size, lengthNewArray);
Console.Write("В массиве:");
PrintArray(array);
Console.WriteLine();
Console.Write("Содержатся следующие строки, длина которых меньше, либо равна 3 символам:");
PrintArray(newArray);
