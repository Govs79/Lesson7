// Задача 1
// void ShowNumbers (int start, int end)
// {
//     if (start == end)
//     {
//         Console.WriteLine (start);
//         return;
//     }
//     Console.WriteLine (start + " ");
//     ShowNumbers (start + 1, end);
// }

// Console.Write("Введите начальное число: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите конечное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// ShowNumbers (M, N);

// Задача 2

// Задача 3
void PrintReverseArray (int[] array, int j)
{
    if (j == 0)
    {
        Console.Write (array[j] + " ");
        return;
    }
    Console.Write (array[j] + " ");

    PrintReverseArray(array, j - 1);
    }
Console.Write("Задайте размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
    int [] numbers = new int [N];
Console.Write("Задайте массив из чисел: ");
for (int i = 0; i < 10; i++) 
{
numbers[i] = Convert.ToInt32(Console.ReadLine());
}
int jm = numbers.Length-1;
PrintReverseArray(numbers, jm);