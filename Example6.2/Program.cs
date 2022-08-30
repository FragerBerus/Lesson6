// Получение вместо строковых пар чисел числовых пар
using System.Linq;  // Подключение системной библиотеки
string text = "(1,2) (2,3) (4,5) (6,7)"
              .Replace("(", "") // Метод заменяет открывающую
                                // скобку на пустую строку
              .Replace(")", "") // Метод заменяет закрывющую
               ;                // строку на пустую
Console.WriteLine(text);    // На выходе будет строка без скобок
var data = text.Split(" ") // Неявный тип data. У строки есть
                            // метод Split делает разбивку
                            // с учетом символа разделителя
                .Select(item => item.Split(','))
                .Select(e => (int.Parse(e[0]),int.Parse(e[1])))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    Console.WriteLine("");
}