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

void FilArray(double[] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.NextDouble();
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

Console.Clear();
Task38();