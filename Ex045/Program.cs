// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] FillArray(int length)
{
    int[] array = new int[length];

    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
       array[i] = random.Next(-10, 10); 
    }
    return array;
}

void PrintArray(int[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Что-то пошло не так");
        return;
    }
    Console.Write("[");

for (int i = 0; i < array.Length - 1; i++)
{
    Console.Write($"{array[i]},");
}

Console.Write(array[array.Length - 1]);
Console.Write("]");
}

int[] CopyArray(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
{
    array2[i] = array[i];
}
return array2;
}

Console.WriteLine("Enter length - ");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);

if (!isNumber || length <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}

int[] result = FillArray(length);
PrintArray(result);

Console.WriteLine();
PrintArray(CopyArray(result));