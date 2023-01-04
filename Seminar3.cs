// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

void Palindrom()
{
    Console.WriteLine("Введите пятизначное число: ");
    string number = Console.ReadLine();
    char[] reverse = new char[number.Length];
    int j = 0;

    for (int i = number.Length - 1; i >= 0; i--)
    {
        reverse[j] = number[i];
        j++;
    }

    int numberInt = int.Parse(number);
    int reverseInt = int.Parse(reverse);

    if (numberInt == reverseInt)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }

}

Palindrom();

//--------------------------------------------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance (double[] A, double[] B)
{
    double dist = 0;

    for (int i = 0; i < A.Length; i++)
    {
        dist = dist + Math.Pow(B[i] - A[i], 2);
    }

    dist = Math.Round(Math.Sqrt(dist), 2);

    Console.WriteLine(dist);

    return dist;
}

double[] GetCoordinates()
{
    string[] coordinateNames = {"x", "y", "z"};
    double[] point = new double[3];
    Console.WriteLine("Введите координаты следующей точки");
    for (int j = 0; j < point.Length; j++)
    {
        Console.WriteLine($"Введите координату {coordinateNames[j]}: ");
        point[j] = double.Parse(Console.ReadLine());
    }
    
    return point;
}

Distance(GetCoordinates(), GetCoordinates());

//-------------------------------------------------------------------------------------------------
// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void PowerTable()
{
    Console.WriteLine("Введите натуральное число N: ");
    int n = int.Parse(Console.ReadLine());

    int[] cubes = new int[n];

    for (int i = 0; i < n; i++)
    {
        cubes[i] = (int) Math.Pow(i + 1, 3);
    }

    Console.WriteLine(String.Join(",", cubes));
}

PowerTable();