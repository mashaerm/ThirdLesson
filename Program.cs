int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task17()
{
    //Напишите программу, которая на вход координаты точки (X и Y), при чем X и Y не равны 0 и выдает номер четверти плоскости, в которой находится эта точка

    int X = Input("Введите X: ");

    int Y = Input("Введите Y: ");

    if (X > 0 && Y > 0)
    {
        Console.WriteLine ("Точка принадлежит 1 четверти");
    }

    else if (X < 0 && Y > 0)
    {
        Console.WriteLine ("Точка принадлежит 2 четверти");
    }

    else if (X < 0 && Y < 0)
    {
        Console.WriteLine ("Точка принадлежит 3 четверти");
    }

    else if (X > 0 && Y < 0)
    {
        Console.WriteLine ("Точка принадлежит 4 четверти");
    }

    else

    {
        Console.WriteLine ("Точка лежит на оси");
    }
}

void Task18()
{
    //Напишите программу, которая по задонному номеру четверти, показывет диапазон возможных координат точек в этой четверти (X и Y)

    int number = Input("Введите номер четверти: ");

    if (number == 1)
    {
        Console.WriteLine ("Диапазон координат точек X > 0 и Y > 0");
    }

    else if (number == 2)
    {
        Console.WriteLine ("Диапазон координат точек X < 0 и Y > 0");
    }

    else if (number == 3)
    {
        Console.WriteLine ("Диапазон координат точек X < 0 и Y < 0");
    }

    else if (number == 4)
    {
        Console.WriteLine ("Диапазон координат точек X > 0 и Y < 0");
    }

    else

    {
        Console.WriteLine ("Нет такой четверти");
    }
}

void Task21()
{
    //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

    int X1 = Input("Введите X1: ");

    int Y1 = Input("Введите Y1: ");

    int X2 = Input("Введите X2: ");

    int Y2 = Input("Введите Y2: ");

    double result = Math.Sqrt(Math.Pow((X2 - X1),2) + Math.Pow((Y2 - Y1),2));
    result = Math.Round(result, 2);
    Console.WriteLine ($"Расстояние между точками: {result}");
}

void Task22()
{
    //Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N

    int number = Input("Введите число: ");

    // int counter = 1;

    // while (counter <= number)
    // {
    //     Console.WriteLine ($"{counter}^2 = {Math.Pow(counter,2)}");
    //     counter++;
    // }

    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine ($"{i}^2 = {Math.Pow(i,2)}");
    }
}

// Console.Clear();
// int task = Input("Введите номер задачи: ");
// switch (task)
// {
//     case 17:
//         Task17();
//         break;
//     case 18:
//         Task18();
//         break;
//     case 21:
//         Task21();
//         break;
//     case 22:
//         Task22();
//         break;
//     default:
//         Console.WriteLine("Ошибка ввода");
//         break;
// }

// if (task == 17) Task17();
// else if (task == 18) Task18();
// else if (task == 21) Task21();
// else if (task == 22) Task22();

void Task19()
{
    //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

    int number = Input("Введите пятизначное число: ");

    if (number >= 10000 & number < 100000)
    {
        int f_digit = number / 10000;
        int ff_digit = number % 10;
        int s_digit = number / 1000 % 10;
        int ss_digit = number / 10 % 10;

        if (f_digit == ff_digit & s_digit == ss_digit)

        {
            Console.WriteLine("Это число палиндром");
        }

        else
        {
            Console.WriteLine("Это число не палиндром");
        }

    }
    
    else

    {
        Console.WriteLine("Число не пятизначное");
    }

}

void Task211()
{
    //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

    int X1 = Input("Введите X1: ");

    int Y1 = Input("Введите Y1: ");

    int Z1 = Input("Введите Z1: ");

    int X2 = Input("Введите X2: ");

    int Y2 = Input("Введите Y2: ");

    int Z2 = Input("Введите Z2: ");

    double result = Math.Sqrt(Math.Pow((X2 - X1),2) + Math.Pow((Y2 - Y1),2) + Math.Pow((Z2 - Z1),2));
    result = Math.Round(result, 2);
    Console.WriteLine ($"Расстояние между точками: {result}");
}

void Task23()
{
    //Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N

    int number = Input("Введите число: ");

    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine ($"{i}^3 = {Math.Pow(i,3)}");
    }
}

Console.Clear();
Task23();
