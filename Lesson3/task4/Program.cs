// Random rnd = new Random();

// int size = 100;
// int[] arr_int = new int [size];

// for (int i = 0; i < arr_int.Length; i++)
// {
//     arr_int[i] = rnd.Next(21,99);
//     System.Console.Write($"{arr_int[i]};");
// }

//Домашняя работа лекция про функции
int  n = 500;
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);
int sum = GetSumOfElements(arr);
System.Console.WriteLine(" ");
System.Console.Write("Sum of all elements is ");
System.Console.WriteLine(sum);

double product = GetProductOfElements(arr);
System.Console.Write("Product of all elements is ");
System.Console.WriteLine(product);

void FillArray(int[] array1)
{
    Random rnd = new Random();
    for (int i = 0; i < array1.Length; i++) array1[i] = rnd.Next(1,10);

}

void PrintArray(int[] array2)
{
    for (int i = 0; i < array2.Length; i++) System.Console.Write($"{array2[i]};");
}

int GetSumOfElements(int[] array3)
{
    int result= array3[0]; 
    for (int i = 1; i < array3.Length; i++) result=result+array3[i];
    return result;
}

double GetProductOfElements(int[] array4)
{
double result = array4[0]; 
    for (int i = 1; i < array4.Length; i++) result=result*array4[i];
    return result;
}
