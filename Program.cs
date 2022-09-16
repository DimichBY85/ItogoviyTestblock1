// Написать программу, которая из имеющегося массива целых чисел формирует
// массив из четных чисел. Первоначальный массив можно ввести с клавиатуры,
// либо сгенерировать случайным образом. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

using System;
 
string[] array =
{
    "hello",
    "2",
    "world",
    ":-)",
    "1234",
    "-2"
};
 
var result = new string[array.Length];
var realSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
 
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
