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