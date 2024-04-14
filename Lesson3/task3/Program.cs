void ZeroEvenElements(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i] % 2 == 0)
        {
            Arr[i] = 0;
        }
    }

}

void PrintArr(int[] arr)
{
    foreach (int e in arr)
    {
        System.Console.Write($"{e} ");
    }
}

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
ZeroEvenElements(array);
PrintArr(array);