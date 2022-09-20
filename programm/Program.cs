string[] initialArray = {"Vint", "etgg", "344", "kgktg", ",", "win", "zxcv", "456", "<>(", "joy"}; //Задаётся строковый массив на старте

int numberOfStrings(string[] firstArray) //Метод определяет сколько строк имеет меньше или равное трём количество символов
{
    int result = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {    
        if (firstArray[i].Length <= 3)
        
            result ++;
    }
    return result;
}

string[] stringsArray(string[] secondArray, int dimension) //Метод формирует массив из строк, длина которых меньше либо равна 3 символам
{
    string[] outputArray = new string[dimension];
    dimension = 0;
    for (int i = 0; i < secondArray.Length; i++)
    {
    if (secondArray[i].Length <= 3)
        {
        outputArray[dimension] = secondArray[i];
        dimension ++;
        }
    }
    return outputArray;
}

int number = numberOfStrings(initialArray); // Определяем сколько строк в массиве с колчеством символов меньше четырех, с помощью первого метода

string [] resultArray = stringsArray(initialArray, number); // Заполняется вновь созданный массив строками изначально созданого, в которых количество символов менее или равно 3

Console.WriteLine($"Результат: [ {String.Join("; ", resultArray)} ]"); // Вывод результируещего массива в консоль
