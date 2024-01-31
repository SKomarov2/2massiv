
// int [,] CreateMatrix (int rowCout, int columsCout)
// {
//     int[,] matrix = new int [rowCout,columsCout];

//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = rnd.Next(1, 11);
//         }
//     }
//     return matrix;
// }
// void ShowMatrix (int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int matrix = CreateMatrix(4,5);
// ShowMatrix(matrix);


// int[,] CreateMatrix(int rowCout, int columsCout)
// {
//     int[,] matrix = new int[rowCout, columsCout];

//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 1000);
//         }
//     }
//     return matrix;
// }
// void ShowMatrix (int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] matrix = CreateMatrix(3, 4);
// ShowMatrix(matrix);
// foreach (int e in matrix)
// {
//     if (isInteresting(e) == true)
//     {
//         Console.WriteLine(e);
//     }
// }
// bool isInteresting(int value)
// {
//     int SumOfDigits = GetSumOfDigits(value);
//     if (SumOfDigits % 2 == 0)
//     {
//         return true;
//     }
//     return false;
// }
// int GetSumOfDigits (int value)
// {
//     int sum = 0;
//     while(value > 0)
//     {
//         sum = sum + value % 10;
//         value = value / 10;
//     }
//     return sum;
// }

// string GetLettersFromStr (string s)
// {
//     string letters = "";
//     foreach (char e in s)
//     {
//         if(char.IsAsciiLetter(e) == true)
//         {
//             letters = letters + e;
//         }

//     }
//     return letters;
// }

// string str = Console.ReadLine();
// string result = GetLettersFromStr(str);
// Console.WriteLine(result);

