Console.WriteLine("Введите элементы массива через пробел:");
        string? input = Console.ReadLine();
        string[] inputArray = input!.Split( );

        string[] resultArray = new string[inputArray.Length];
        int resultIndex = 0;

        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[resultIndex] = str;
                resultIndex++;
            }
        }

        Array.Resize(ref resultArray, resultIndex);

        Console.WriteLine("Результат:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }