void ModifyArray(string[] source_array, string[] modified_array)
{
    int index = 0;
    for (int i = 0; i < source_array.Length; i++)
    {
    if(source_array[i].Length <= 3)
        {
        modified_array[index] = source_array[i];
        index++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] source_arr = new string[6] {"Sun", "Moon", "Earth", "2023", "hi", "000"};
string[] modified_arr = new string[source_arr.Length];

ModifyArray(source_arr, modified_arr);

Console.WriteLine("Исходный массив: ");
PrintArray(source_arr);

Console.WriteLine("Измененный массив: ");
PrintArray(modified_arr);
