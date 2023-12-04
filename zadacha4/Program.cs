using System;

class Program
{
    static void Main()
    {
        // Задаем строку из слов, разделенных пробелами
        string originalString = "Happy New Year my Friends!";

        // Формируем строку с обратным порядком слов
        string reversedString = ReverseWords(originalString);

        // Выводим результат
        Console.WriteLine("Исходная строка: " + originalString);
        Console.WriteLine("Строка с обратным порядком слов: " + reversedString);
    }

    static string ReverseWords(string inputString)
    {
        // Разбиваем строку на слова
        string[] words = inputString.Split(' ');

        // Обратно упорядочиваем массив слов
        Array.Reverse(words);

        // Объединяем слова в новую строку с пробелами между ними
        string reversedString = string.Join(" ", words);

        return reversedString;
    }
}

