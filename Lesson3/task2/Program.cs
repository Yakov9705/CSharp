
void Bar(int a)
{
    a=0;
}

int value = 5;
Bar(value);
Console.WriteLine(value);



/////////////////////////////////////////////////////////////////////////////////////////////////
///
/* 
int Bar(int a)
{
    a=0;
Console.WriteLine(a);
return a;
}

int value = 5;
Bar(value);
Console.WriteLine(value);
*/
///////////////////////////////////////////////////////////////////////////////////////////////////
/// 
/* 
int Bar(int a)
{
    a = 0;
    Console.WriteLine(a);
    return a;
}

int value = 5;
Console.WriteLine(Bar(value));
*/
//////////////////////////////////////////////////////////////////////////////////////////////////////////

/* 
void ZeroEvenElements(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0)
    {
      arr[i] = 0;
    }
  }
}

void PrintArray(int[] arr)
{
  foreach (int e in arr)
  {
    System.Console.WriteLine($"{e}");
  }
}


int[] array = { 1, 2, 3, 4, 5, 6, 7 };
ZeroEvenElements(array);
PrintArray(array);

int i=0;
while (i < array.Length)
{
    System.Console.WriteLine(array[i]);
    i++;
} 
*/