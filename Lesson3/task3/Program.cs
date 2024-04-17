void ZeroEvenElements(int[] arr)  //  функция заполнения массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)  // функция вывода массива
{
    foreach (int e in arr)
    {
        Console.Write($"{e} "); // не индекс массива
    }
}

int[] array = { 1, 2, 3, 4, 5, 6, 7 };
ZeroEvenElements(array);
PrintArray(array);

///////////////////////////////////////////////////////////////////////////////////////////////////////////////
///

Console.WriteLine();
int i = 0;
while (i < array.Length)
{
    Console.Write(array[i]+" ");
    i++;
}
