// Задача 64 начало
int InputNum(string input) // также и для задач 66 и 68
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintNum(int x, int count)
{
    if (count > x) return;
    PrintNum(x, count + 1);
    Console.Write(count + ", ");
}
// Задача 64 конец


// Задача 66 начало
void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма натуральных элементов = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}
// Задача 66 конец


// Задача 68 начало
int AkkFunc(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkFunc(m - 1, 1);
    else return AkkFunc(m - 1, AkkFunc(m, n - 1));
}
// Задача 68 конец

Console.Clear();
Console.WriteLine("\n========= Список задач ==========\n");
Console.WriteLine("1 - Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
Console.WriteLine("2 - Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine("3 - Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
Console.WriteLine("0 - Выход\n");
Console.Write("Выберите задачу 1, 2 или 3:   ");
int task = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

switch (task)
{
    case 1:
        // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
        // N = 5 -> "5, 4, 3, 2, 1"
        // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

        int n = InputNum("Введите число N: ");
        int count = 2;
        Console.Write($"Последовательноcть от {n} до 1:   ");
        PrintNum(n, count);
        Console.Write(1);
        break;


    case 2:
        // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
        // M = 1; N = 15 -> 120
        // M = 4; N = 8. -> 30

        int m2 = InputNum("Введите число M: ");
        int n2 = InputNum("Введите число N: ");
        int temp = m2;

        if (m2 > n2)
        {
            m2 = n2;
            n2 = temp;
        }
        
        PrintSumm(m2, n2, temp = 0);
        break;


    case 3:
        // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
        // m = 2, n = 3 -> A(m,n) = 9
        // m = 3, n = 2 -> A(m,n) = 29

        int m3 = InputNum("Введите число m: ");
        int n3 = InputNum("Введите число n: ");
        Console.Write($"Функция Аккермана равна {AkkFunc(m3, n3)} ");
        break;


    case 0:
        Console.WriteLine("Всего хорошего!");
        break;
}
Console.WriteLine();