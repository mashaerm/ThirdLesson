int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] numbers, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(minValue, maxValue);
    }  
}

void FilArray(double[] numbers, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.NextDouble() * (maxValue - minValue) + minValue;
        numbers[i] = Math.Round(numbers[i], 2);
    }  
}

void PrinArray (double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

void FillcArray(double[,] matrix, int minValue = -9, int maxValue = 9)
 {  
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.NextDouble() * (maxValue - minValue) + minValue;
            matrix[i,j] = Math.Round(matrix[i,j], 1);
        }
    }
 }

void PrintcArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintArray (int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}

int SumPositive (int[] numbers)
{
    int sumPositive = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) sumPositive += numbers[i];
    }
    return sumPositive;
}

int SumNegative (int[] numbers)
{
    int sumNegative = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0) sumNegative += numbers[i];
    }
    return sumNegative;
}

void FillsArray(int[,] matrix, int minValue = -9, int maxValue = 9)
 {  
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(minValue, maxValue);
        }
    }
 }

void PrintsArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Task24()
{
    //Напишите программу, которая принимает на вход число (A) и выдает сумму чисел от 1 до A

    int number = Input("Введите число: ");
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{i} + ");
        sum += i;
    }
    Console.Write("\b\b= ");
    Console.WriteLine(sum);
}

void Task26()
{
    //Напишите программу, которая принимает на вход число и выдает количество чисел в числе

    int number = Input("Введите число: ");
    int digitsCount = 0;

    Console.WriteLine($"В числе {number} - ");
    while (number > 0)
    {
        number /= 10;
        digitsCount++;
    }
    Console.WriteLine($"{digitsCount} цифр");
}

void Task28()
{
    //Напишите программу, которая принимает на вход число (N) и выдает произведение чисел от 1 до N

    int number = Input("Введите число: ");
    int mult = 1;

    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{i} * ");
        mult *= i;
    }
    Console.Write("\b\b= ");
    Console.WriteLine(mult);
}

void Task30()
{   
    //Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
    
    int size = 8;
    Random rnd = new Random();

    // int [] numbers = {10, 4, 3, 8, 15, 10};
    // // Console.WriteLine(numbers[4]);

    int[] numbers = new int[size];

    for (int i = 0; i < size; i++)
    {
        numbers[i] = rnd.Next(0, 2);
    }

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();

}

void Task25()
{
    //Напишите программу, которая принимает на вход два натуральных числа (A и B) и возводит число A в степень B

    int number = Input("Введите число: ");

    int numberSc = Input("Введите число: ");

    if (number < 1 || numberSc < 1)
    {
        Console.Write("Число должно быть натуральным");
    }

    else
    {
        Console.Write($"{number}^{numberSc} = {Math.Pow(number, numberSc)}");
    }
}

void Task27()
{
    //Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

    int number = Input("Введите число: ");
    int sum = 0;

    Console.WriteLine($"В числе {number} сумма цифр");

    number = Math.Abs(number);

    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    Console.WriteLine(sum);
}

void Task29()
{   
    //Напишите программу, которая выводит массив из 8 случайных целых чисел и выводит отсортированный по модулю массив
    
    int size = 8;
    // FillArray(numbers, 0, 15);
    // PrintArray(numbers);

    int[] numbers = new int[size];

    int LastIndex = numbers.Length - 1;
    for (int i = 0; i < LastIndex; i++)
    {
        for (int k = 0; k < LastIndex - i; i++)
        {
            if (numbers[k] > numbers[k+1])
            {
                int temp = numbers[k];
                numbers[k] = numbers[k+1];
                numbers[k+1] = numbers[k];
            }
        }
    }

    Console.WriteLine();
    PrintArray(numbers);
}

void Task31()
{   
    //Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива
    
    int size = Input("Введите размер массива ");
    
    int[] numbers = new int[size];

    FillArray(numbers);
    PrintArray(numbers);

    Console.WriteLine($"Сумма положительных элементов равна: {SumPositive(numbers)}");

    Console.WriteLine($"Сумма отрицательных элементов равна: {SumNegative(numbers)}");
}

void Task32()
{   
    //Напишите программу замены элементов массива: положительные элементы замените на соотвествующие отрицательные, и наоборот
    
    int size = Input("Введите размер массива ");
    
    int[] numbers = new int[size];

    FillArray(numbers);
    PrintArray(numbers);

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= -1;
    }

    Console.WriteLine("Выход измененного массива");
    PrintArray(numbers);
}

void Task33()
{   
    //Напишите программу, которая определяет, присутствует ли заданное число в массиве
    
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    int num = Input("Введите искомое значение ");
    bool flag = false;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == num) flag = true;
    }

    if (flag) Console.WriteLine("Есть совпадение");
    else Console.WriteLine("Совпадений нет");
}

void Task35()
{   
    //Задайте одномерный массив из 10 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10, 99]
    
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, -50, 100);
    PrintArray(numbers);

    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >= 10 && numbers[i] <= 99) count++;
    }

    Console.WriteLine($"Найдено элементов: {count}");
}

void Task37()
{   
    //Найдите произведение пар чисел в одномерном массиве
    
    int size = 3;
    int[] numbers = new int[size];
    FillArray(numbers, 0, 15);
    PrintArray(numbers);

    int LastIndex = numbers.Length - 1;
    int halfindex = numbers.Length/2;
    for (int i = 0; i < halfindex; i++)
    {
        Console.WriteLine($"{numbers[i]} * {numbers[LastIndex - i]} = {numbers[i] * numbers[LastIndex]}");
    }

    if (numbers.Length % 2 == 1)
    {
        Console.WriteLine($"Элемент {numbers[halfindex]} без пары");
    }
}

void Task34()
{   
    //Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве
    
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 1000);
    PrintArray(numbers);

    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) count++;
    }

     Console.WriteLine($" {count} четных чисел");
}

void Task36()
{   
    //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечетными индексами
    
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    int sum = 0;
    for (int i = 0; i < numbers.Length; i+=2)
    {
        sum += numbers[i];
    }

     Console.WriteLine($"Сумма элементов с нечетными индексами {sum}");
}

void Task38()
{   
    //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива
    
    int size = 5;
    double[] numbers = new double[size];
    FilArray(numbers);
    PrinArray(numbers);

    double min = numbers[0];
    double max = numbers[0];

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }

    Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {max - min}");
}

void Task39()
{   
    //Напишите программу, которая перевернет одномерный массив
    
    int size = 6;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    int halfSize = numbers.Length/2;
    int lastIndex = numbers.Length - 1;
    for (int i = 0; i < halfSize; i++)
    {
        // int temp = numbers[i];
        // numbers[i] = numbers[lastIndex - i];
        // numbers[lastIndex - i] = temp;

        (numbers[i], numbers[lastIndex -i]) = (numbers[lastIndex - i], numbers[i]);
    }

    PrintArray(numbers);
}

void Task40()
{   
    //Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины
    
    int a = Input("Введите число a: ");
    int b = Input("Введите число b: ");
    int c = Input("Введите число c: ");
    
    if (a + b > c & a + c > b & b + c > a)
    {
        Console.WriteLine("Треугольник существует");
    }

    else
    {
        Console.WriteLine("Треугольник не существует");
    }

}

void Task42()
{   
    //Напишите программу, которая будет преобразовывать десятичное число в двоичное
    
    // int number = 47;
    // int result = 0;
    // int bias = 1;
    
    // while (number > 0)
    // {
    //     result += number % 2 * bias;
    //     number /= 2;
    //     bias *= 10;
    // }

    //  Console.WriteLine($"{result}");

    int number = 47;
    string result = "";
    
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }

     Console.WriteLine($"{result}");
}

void Task44()
{   
    //Не используя рекурсию, выведите первые N чисел Фибоначчи

    int f_num = 0;
    int s_num = 1;
    int count = Input("Введите количество элементов: ");
    
    for (int i = 1; i <= count; i++)
    {
        Console.WriteLine($"{i}. {f_num}");
        // int temp = f_num;
        // f_num = s_num;
        // s_num = s_num + temp;
        (f_num, s_num) = (s_num, f_num + s_num);
    }
}

void Task45()
{   
    //Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования
    
    int size = 6;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    int[] copynumbers = new int[numbers.Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        copynumbers[i] = numbers[i];
    }

    PrintArray(numbers);
}

void Task41()
{   
    //Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь
    
    int size = Input("Введите размер массива ");
    int count = 0;
    for (int i = 1; i <= size; i++)
    {
        int number = Input($"Введите {i} элемент ");
        if (number > 0) count++;
    }

    Console.WriteLine($"Количество чисел больше 0 = {count}");
}

void Task43()
{   
    //Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнением y1=k1 * x + b1, y2=k2 * x + b2
    
    int k1 = Input("Введите k1 ");
    int b1 = Input("Введите b1 ");
    int k2 = Input("Введите k2 ");
    int b2 = Input("Введите b2 ");

    double x = (b2 -b1)/(k1 - k2);
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;

    Console.WriteLine($"A({x}, {y1})");
    Console.WriteLine($"B({x}, {y2})");
}

void Task46()
{   
    //Задайте двумерный массив размером mхn, заполненный случайными целыми числами
    
    int rows = 4;
    int columns = 7;

    int[,] matrix = new int[rows, columns];

    FillsArray(matrix);
    PrintsArray(matrix);
}

void Task48()
{   
    //Задайте двумерный массив размером mхn, каждый элемент в массиве находится по формуле A = i+j
    
    int rows = 4;
    int columns = 7;

    int[,] matrix = new int[rows, columns];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i + j;
        }
    }

    PrintsArray(matrix);
}

void Task49()
{   
    //Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты
    
    int rows = 3;
    int columns = 8;

    int[,] matrix = new int[rows, columns];
    FillsArray(matrix, 4, 9);
    PrintsArray(matrix);
    Console.ReadKey();
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
        }
    }

    PrintsArray(matrix);
}

void Task51()
{   
    //Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
    
    int rows = 6;
    int columns = 4;

    int[,] matrix = new int[rows, columns];
    FillsArray(matrix, 0, 6);
    PrintsArray(matrix);

    int sum = 0;
    int minSize = matrix.GetLength(0) < matrix.GetLength(1)? matrix.GetLength(0): matrix.GetLength(1);
    // if(matrix.GetLength(0) < matrix.GetLength(1)) minSize = matrix.GetLength(0);
    // else minSize = matrix.GetLength(1);

    for (int i = 0; i < minSize; i++)
    {
        sum += matrix[i, i];
    }
    Console.WriteLine($"Сумма равна {sum}");
}

void Task47()
{   
    //Задайте двумерный массив размером mхn, заполненный случайными вещественными числами, округленными до одного знака
    
    int rows = 4;
    int columns = 7;

    double[,] matrix = new double[rows, columns];

    FillcArray(matrix);
    PrintcArray(matrix);
}

void Task50()
{   
    //Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
    
    int rows = 4;
    int columns = 7;

    int[,] matrix = new int[rows, columns];

    FillsArray(matrix);
    PrintsArray(matrix);

    int indexRw = Input("Введите индекс строки: ");
    int indexCl = Input("Введите индекс столбца: ");

    if (indexRw < rows && indexCl < columns && indexRw >= 0 && indexCl >= 0)
    {
        Console.WriteLine($"{matrix[indexRw, indexCl]}");
    }
    else 
    {
        Console.WriteLine("Такого элемента нет");
    }
}

void Task52()
{   
    //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
    
    int rows = 4;
    int columns = 7;

    int[,] matrix = new int[rows, columns];

    double sum = 0;
    FillsArray(matrix);
    PrintsArray(matrix);

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        double sumSr = sum/rows;
        Console.Write($"{sumSr}");
    }
}

void Task53()
{   
    //Задайте двумерный массив. Напишите программу, которая поменяет местами последнюю и первую строки массива
    
    int rows = 4;
    int columns = 5;
    int[,] numbers = new int[rows, columns];

    FillsArray(numbers, 0, 9);
    PrintsArray(numbers);

    int indexFirstRow = 0;
    int indexLastRow = numbers.GetLength(0) - 1;

    for (int j = 0; j < columns; j++)
    {
        int temp = numbers[indexFirstRow, j];
        numbers[indexFirstRow, j] = numbers[indexLastRow, j];
        numbers[indexLastRow, j] = temp;
    }
    Console.WriteLine();
    PrintsArray(numbers);
}

void Task55()
{   
    //Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы
    
    int rows = 4;
    int columns = rows;
    int[,] numbers = new int[rows, columns];

    FillsArray(numbers, 0, 9);
    PrintsArray(numbers);

    for (int i = 0; i < rows; i++)
    {
        for (int j = i; j < columns; j++)
        {
            int temp = numbers[i, j];
            numbers[i, j] = numbers[j, i];
            numbers[j, i] = temp;
        }
    }

    Console.WriteLine();
    PrintsArray(numbers);
}

void Task57()
{   
    //Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию, о том, сколько раз встречается элемент входных данных
    
    int rows = 2;
    int columns = rows;
    int[,] numbers = new int[rows, columns];

    int a = -5;
    int b = 8;
    FillsArray(numbers, a, b);
    PrintsArray(numbers);

    int size = b - a + 1;
    int[] dictionary = new int[size];

     for (int i = 0; i < rows; i++)
    {
        for (int j = i; j < columns; j++)
        {
          dictionary[numbers[i, j] - a]++;
        }
    }

    Console.WriteLine();
    for (int i=0; i < size; i++)
    {
        if (dictionary[i] != 0) Console.WriteLine($"Элемент {i + a} встречается {dictionary[i]} раз(-a)");
    }
}

void Task59()
{   
    //Задайте двумерный массив из целых чисел. Напишите программу, которая удалит троку и столбец, на пересечение которых расположен наименьший элемент массива
    
    int rows = 5;
    int columns = 6;
    int[,] numbers = new int[rows, columns];

    FillsArray(numbers, -100, 100);
    PrintsArray(numbers);

    int rowResult = rows - 1;
    int columnResult = columns - 1;

    int[,] result = new int[rows - 1, columns - 1];

    int minValue = numbers[0, 0];
    int i_min = 0;
    int j_min = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = i; j < columns; j++)
        {
            if (numbers[i, j] < minValue)
            {
                minValue = numbers[i, j];
                i_min = i;
                j_min = j;
            }
        }
    }

    Console.WriteLine();
    Console.WriteLine($"Минимальное значение {minValue} находится в позиции {i_min + 1}, {j_min + 1}");

    int bias_i = 0;
    int bias_j = 0;

    for (int i = 0; i < rowResult; i++)
    {
        if (i == i_min) bias_i++;
        bias_j = 0;
        for (int j = i; j < columnResult; j++)
        {
            if (j == j_min) bias_j++;
            result[i, j] = numbers[i + bias_i, j + bias_j];
        }
    }

    Console.WriteLine();
    PrintsArray(result);
}

void Task54()
{   
    //Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
    
    int rows = 4;
    int columns = 5;
    int[,] numbers = new int[rows, columns];

    FillsArray(numbers);
    PrintsArray(numbers);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - j - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    int temp = numbers[i, k + 1];
                    numbers[i, k + 1] = numbers[i, k];
                    numbers[i, k] = temp;
                }
            }
        }
    }

    Console.WriteLine();
    PrintsArray(numbers);
}

void Task56()
{   
    //Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов
    
    int rows = 4;
    int columns = 5;
    int[,] numbers = new int[rows, columns];

    FillsArray(numbers);
    PrintsArray(numbers);
    int minSum = Int32.MaxValue;
    int minIn = 0;

    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += numbers[i, j];
        }

        if (minSum > sum)
        {
            minSum = sum;
            minIn = i;
        }
    }

    Console.WriteLine($"Строка с наименьшей суммой {minIn} и сумма равна {minSum}");
}

void Task58()
{   
    //Заполните спирально массив 4 на 4 числами от 1 до 16
    
    int rows = 4;
    int columns = 4;
    int[,] numbers = new int[rows, columns];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= rows * columns)
    {
        numbers[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < columns - 1) j++;
        else if (i < j && i + j >= rows - 1) i++;
        else if (i >= j && i + j > columns - 1) j--;
        else i--;
    }

    Console.WriteLine();
    PrintsArray(numbers);
}

void Recursion63(int counter, int number)
{
    if (counter > number) return;
    Console.WriteLine(counter);
    counter++;
    Recursion63(counter, number);
}

void Task63()
{   
    //Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N
    
    int number = Input("Введите число ");
    int counter = 1;

    while (counter <= number)
    {
        Console.WriteLine(counter);
        counter++;
    }
}

void Task65()
{   
    //Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N
    
    int number = Input("Введите число ");
    int numbersec = Input("Введите второе число ");

    while (numbersec <= number)
    {
        Console.WriteLine(numbersec);
        numbersec++;
    }
}

void Recursion65(int numbersec, int number)
{
    if (numbersec > number) return;
    Console.WriteLine(numbersec);
    Recursion65(numbersec + 1, number);
    Console.WriteLine(numbersec);
}

void Task67()
{   
    //Напишите программу, которая будет принимать на вход число и возвращать сумму его чисел
}

int Recursion67(int number, int sum = 0)
{
    if (number == 0) 
    {
        return sum;
    }

    sum += number % 10;
    number /= 10;
    return Recursion67(number, sum);
}

void Task68()
{   
    //Напишите программу, которая на вход принимает два числа A и B, и возводит число A в целую степень B с помощью рекурсии

int Recursion69(int a, int b, int result = 1)
{
    if (b == 0) 
    {
        return result;
    }

    result *= a;
    b--;
    return Recursion69(a, b, result);
}

int a = Input("Введите число a ");
int b = Input("Введите число b ");
Console.WriteLine($"{a}^{b}={Recursion69(a, b)}");
}

// Task64()
//Задайте значение M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ем в промежутке от M до N

// int number = Input("Введите число ");
// int numbersec = Input("Введите второе число ");


// void Recursion64(int numbersec, int number)
// {
//     if (numbersec < number) return;
//     if (numbersec % 3 == 0) Console.WriteLine(numbersec);
//     Recursion64(numbersec - 1, number);
// }

// Console.Clear();
// Recursion64(numbersec, number);

// Task66()
//Задайте значение M и N. Напишите рекурсивный метод, который найдет сумму натуральных элементов в промежутке от M до N

// int number = Input("Введите число ");
// int numbersec = Input("Введите второе число ");

// int Recursion66(int number, int numbersec)
// {
//     int temp = number;
//     if (number == numbersec)
//         return 0;
//     else
//     {
//         number++;
//         temp = number + Recursion66(number, numbersec);
//         return temp;
//     }
// }

// Console.Clear();
// Console.WriteLine(Recursion66(number - 1, numbersec));

// Task68()
//Напишите программу вычисления функции Аккермана с помощью рекурсии

// int number = Input("Введите число ");
// int numbersec = Input("Введите второе число ");

// int Recursion68(int number, int numbersec)
// {
// if (number == 0) return numbersec + 1;
// else if (numbersec == 0) return Recursion68(number - 1, 1);
// else return Recursion68(number - 1, Recursion68(number, numbersec - 1));
// }

// Console.Clear();
// Console.Write($"Функция Аккермана равно {Recursion68(number, numbersec)}");
