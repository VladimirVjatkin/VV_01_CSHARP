
//int[] arr = { 2, 91, 62, 58, 69, 23, 54, 88, 66, 12 };

//int max = arr[0];
// for (int i = 1; i < arr.Length; i++)
// {
//     if (arr[i]>max) max=arr[i];
// }   
//     System.Console.Write($"Maximum is {max}");

// int max = arr[0];
// foreach (int e in arr)
// {
//     if (e>max) max=e;
// }   
//     System.Console.Write($"Maximum is {max}");



    Console.Write("Введите натуральное число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    if (N < 10)
    {
        Console.WriteLine(N);
    }
    else
    {
        while (N > 0)
        {
            int currentDigit = N % 10;
            N /= 10;
            if (N > 0)
            {
                Console.Write(currentDigit + ",");
            }
            else
            {
                Console.WriteLine(currentDigit);
            }
        }
    }
