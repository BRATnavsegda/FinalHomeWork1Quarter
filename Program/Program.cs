Console.Clear();
string[] array = { "бюджетополучатель", "достопримечательность", "ФСБ", "тротуар", "консолидация", "see", "автоматизация", "s", "макроэкономика", "you" };

string[] PrintArray(string[] array)
{
    System.Console.WriteLine();
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) System.Console.Write($"{array[i]}");
        else System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write("] ");
    System.Console.WriteLine();
    return array;
}

string[] CheckArray(string[] array)
{
    int count = 0;
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    string[] result = new string[count];
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            result[temp] = array[j];
            temp++;
        }

    }
    PrintArray(result);
    return result;
}
System.Console.WriteLine("\nЭто заданный массив:");
PrintArray(array);
System.Console.WriteLine("\nЭтот массив сформирован из строк, длина которых меньше, либо равна 3 символам:");
CheckArray(array);
System.Console.WriteLine();
