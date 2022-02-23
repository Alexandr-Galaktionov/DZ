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
