using System;

class Program
{
    static void Main()
    {
        // Задаем строку с латинскими буквами 
        string originalString = "Happy New Year My Friend!";

        // Преобразуем все заглавные буквы в строчные
        string resultString = ConvertToLowerCase(originalString);

        // Выводим результат
        Console.WriteLine("Исходная строка: " + originalString);
        Console.WriteLine("Результат: " + resultString);
    }

    static string ConvertToLowerCase(string inputString)
    {
        // Используем метод ToLower для преобразования всех заглавных букв в строчные
        return inputString.ToLower();
    }
}
