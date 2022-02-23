# Задача #
##3 Написать программу, которая из имеющего массива строк формирует массив из строк, длина которых меньше либо равна 3. Первоначальный массив ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 3##

## Решение задачи ##

    string[] array = { "a","boby","cccp","mir","nikto","z", "5"};
 
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
 
    Console.WriteLine(string.Join(" ", result, 0, realSize));

