// Задача 1
void ShowNumbers (int start, int end)
{
    if (start == end)
    {
        Console.WriteLine (start);
        return;
    }
    Console.WriteLine (start + " ");
    ShowNumbers (start + 1, end);
}

Console.Write("Введите начальное число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите конечное число: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNumbers (M, N);