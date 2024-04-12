int n = 10;
int[] arr = new int[n];
for (int i = 1; i <= arr.Length; i++)
{
    arr[i-1]=i;
System.Console.Write($"{arr[i-1]} ");
}

