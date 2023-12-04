using System;

class Program
{
    static void Main()
    {
        // Задаем двумерный массив символов
        char[,] charArray = {
            {'A', 'B', 'C'},
            {'D', 'E', 'F'},
            {'G', 'H', 'I'}
        };

        // Создаем строку из символов массива
        string resultString = ConvertCharArrayToString(charArray);

        // Выводим результат
        Console.WriteLine("Результат: " + resultString);
    }

    static string ConvertCharArrayToString(char[,] charArray)
    {
        int rows = charArray.GetLength(0);
        int cols = charArray.GetLength(1);

        // Создаем объект StringBuilder для эффективной работы со строкой
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        // Проходим по каждому символу в массиве и добавляем его к строке
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sb.Append(charArray[i, j]);
            }
        }

        // Возвращаем полученную строку
        return sb.ToString();
    }
}

