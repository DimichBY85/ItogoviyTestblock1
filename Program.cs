// Написать программу, которая из имеющегося массива целых чисел формирует
// массив из четных чисел. Первоначальный массив можно ввести с клавиатуры,
// либо сгенерировать случайным образом. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.
// Тесты:
// [1, 2, 3, 4] -> [2, 4]
// [1, 3, 4, 5, 7, 1, 3] -> [4]
// [2, -4, 6] -> [2, -4, 6]
// [1, 3, 5] -> []

int[] GetEvenArray(int[] inputArr) // Возращает новый массив в котором содержаться четные числа исходного массива
{
    int[] resultArr = new int[inputArr.Length];
    int j = 0;
    for (int i = 0; i < inputArr.Length; i++)
        if (inputArr[i] % 2 == 0)
        {
            resultArr[j] = inputArr[i];
            j++;
        }
    Array.Resize(ref resultArr, j);
    return resultArr;
}

void PrintArray(int[] arr, string preStr = "", string postStr = "\n") // Выводит на экран элементы массива через запятую
{
    Console.Write(preStr);
    for (int i = 0; i < arr.Length; i++)
        if(i != arr.Length - 1) Console.Write($"{arr[i]}, ");
        else                    Console.Write($"{arr[i]}");
    Console.Write(postStr);
}

void FillRandomArray(int[] arr, int minVal, int maxVal) // Возращает заполненный псевдослучайными числами [minVal;maxVal) массив
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(minVal, maxVal);
}

bool IsEqualArray(int[] arrA, int[] arrB) // Сравнивает поэлементно два массива: True - идентичны, False - отличаются.
{
    if (arrA.Length != arrB.Length) return false;
    else
    {
        for (int i = 0; i < arrA.Length; i++)
            if (arrA[i] != arrB[i]) return false;
    }
    return true;
}

Console.Clear();

{   // Тест 1
    Console.WriteLine("Тест 1");
    int[] tstArr = { 1, 2, 3, 4 };
    int[] expectedResult = { 2, 4 };
    int[] actualResult = GetEvenArray(tstArr);
    PrintArray(tstArr, preStr: "[", postStr: "]");
    PrintArray(actualResult, preStr: " -> [", postStr: "]. ");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 2
    Console.WriteLine("Тест 2");
    int[] tstArr = { 1, 3, 4, 5, 7, 1, 3 };
    int[] expectedResult = { 4 };
    int[] actualResult = GetEvenArray(tstArr);
    PrintArray(tstArr, preStr: "[", postStr: "]");
    PrintArray(actualResult, preStr: " -> [", postStr: "]. ");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 3
    Console.WriteLine("Тест 3");
    int[] tstArr = { 2, -4, 6 };
    int[] expectedResult = { 2, -4, 6 };
    int[] actualResult = GetEvenArray(tstArr);
    PrintArray(tstArr, preStr: "[", postStr: "]");
    PrintArray(actualResult, preStr: " -> [", postStr: "]. ");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 4
    Console.WriteLine("Тест 4");
    int[] tstArr = { 1, 3, 5 };
    int[] expectedResult = { };
    int[] actualResult = GetEvenArray(tstArr);
    PrintArray(tstArr, preStr: "[", postStr: "]");
    PrintArray(actualResult, preStr: " -> [", postStr: "]. ");
    Console.WriteLine($"Результат верен: {IsEqualArray(actualResult, expectedResult)}\n");
}

{   // Тест 5
    Console.WriteLine("Тест 5");
    int[] tstArr = new int[15];
    FillRandomArray(tstArr, -10, 10);
    int[] actualResult = GetEvenArray(tstArr);
    PrintArray(tstArr, preStr: "[", postStr: "]");
    PrintArray(actualResult, preStr: " -> [", postStr: "]. ");
}
