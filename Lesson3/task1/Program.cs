void PrintSquare(int limit)
{
  int i = 1;
  while (i <= limit)
  {
    Console.Write($"{i * i} ");
    i = i + 1;
  }
  Console.WriteLine();
}
PrintSquare(5);
PrintSquare(10);
PrintSquare(15);

//////////////////////////////////////////////////////////////////////

// Console.WriteLine("Введите число");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];

// void PrintArray()
// {
// for (int i = 0; i < array.Length; i++)
//     {
//         array[i]= new Random().Next(1,11);
//         Console.Write(array[i]+" ");
//     }
// }


// int Even()
// {
//     int count = 0;
//     for (int j = 0; j < array.Length; j++)
//     {
//         if(array[j]%2 == 0)
//          count++;
//     }
//     return count;
// }


// PrintArray();
// System.Console.WriteLine("Количество четных элементов = "+Even());

////////////////////////////////////////////////////////////////////////////////////////////////



// Console.Write("Введите число или 'q' для выхода: ");
// string input = Console.ReadLine();

// if (input == "q")
// {
//     break;
// }

// int number;
// if (Int32.TryParse(input, out number))
// {
//     int sum = 0;
//     while (number != 0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }

//     if (sum % 2 == 0)
//     {
//         Console.WriteLine("Сумма цифр введённого числа чётная. Программа завершена.");
//         break;
//     }
// }
// else
// {
//     Console.WriteLine("Введено некорректное число. Попробуйте ещё раз.");
// }



// void ShowHello()
// {
//     Console.WriteLine("HelloWorld");
// }
// ShowHello();

// double GetPi()
// {
//     return 3.14159;
// }
// Console.WriteLine(GetPi());

////////////////////////////////////////////////////////////////////////////////////////////

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// // int b = Convert.ToInt32(Console.ReadLine());
// // int c = Convert.ToInt32(Console.ReadLine());
// // int d = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Введите числа");
// string[] inputs = Console.ReadLine().Split(' ');
// int a = Convert.ToInt32(inputs[0]);
// int b = Convert.ToInt32(inputs[1]);
// int c = Convert.ToInt32(inputs[2]);
// int d = Convert.ToInt32(inputs[3]);

// double CalculateFormula(int a, int b, int c, int d)
// {
//   double numenator = a * b;
//   double dominator = c + d;
//   double result = numenator / dominator;
//   return result;
// }

// Console.WriteLine(CalculateFormula(a,b,c,d));


