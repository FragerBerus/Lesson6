// Получение строковых пар
using System.Linq;  // Подключение системной библиотеки
string text = "(1,2) (2,3) (4,5) (6,7)";
var data = text.Split(" ") // Неявный тип data. У строки есть
                            // метод Split делает разбивку
                            // с учетом символа разделителя
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}