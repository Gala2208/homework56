
int m = 6,
    n = 3,
    minSum = 0,
    currentSum = 0,
    minLine = 0;
int[,] arr = new int[m, n];
Random rnd = new Random();

// Заполняем массив
for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++) arr[i, k] = rnd.Next(10);
}

// Сумма первой строки
for (int i = 0; i < n; i++)
{
    minSum += arr[0, i];
}

// Ищем строку с мин суммой
for(int i = 0; i < m; i++)
{
    currentSum = 0;
    for (int k = 0; k < n; k++)
    {
        currentSum += arr[i, k];
    }
    if (currentSum < minSum)
    {
        minLine = i;
        minSum = currentSum;
    }
}

// Output Array
for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++)
    {
        Console.Write("{0} ", arr[i, k]);
    }
    Console.WriteLine();
}

minLine++;
Console.WriteLine("{0} строка", minLine); // Answer