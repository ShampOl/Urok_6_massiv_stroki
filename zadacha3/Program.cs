using System;

class Program
{
    static void Main()
    {
        // Задаем произвольную строку
        string inputString = "Happy New Year";

        // Проверяем, является ли строка палиндромом
        bool isPalindrome = IsPalindrome(inputString);

        // Выводим результат
        Console.WriteLine("Строка: " + inputString);
        Console.WriteLine("Является ли палиндромом: " + isPalindrome);
    }

    static bool IsPalindrome(string str)
    {
        // Удаляем из строки все пробелы и приводим к нижнему регистру
        string cleanStr = str.Replace(" ", "").ToLower();

        // Создаем обратную копию строки
        char[] charArray = cleanStr.ToCharArray();
        Array.Reverse(charArray);
        string reversedStr = new string(charArray);

        // Сравниваем исходную строку с ее обратной копией
        return cleanStr == reversedStr;
    }
}

