// Написать программу, которая из имеющегося массива целых чисел формирует 
// массив из четных чисел. Первоначальный массив можно ввести с клавиатуры, 
// либо сгенерировать случайным образом. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

void FillArray(int[] col, int min, int max)
{
    int size=col.Length;
    for (int i = 0; i <size; i++)
    {
        col[i]=new Random().Next(min,max);
    }
}

void PrintArray(int[] array)
{
    int count=array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]+ " ");
    }
}

Console.Write("введите M: ");
int lengthM = int.Parse(Console.ReadLine());
int[] Numbers = new int[lengthM];
FillArray (Numbers, 1, 20);
PrintArray (Numbers);
 Console.WriteLine();

int[] NumbersGreaterThan8(int[] collection)
{
    int length=collection.Length;
    int[] result=new int[length];
    for (int i = 0; i < length; i++)
    {
        if(collection[i]>8)
        {
            result[i]=collection[i];
        }
        
    }
    return result;
}

int[] res=NumbersGreaterThan8(Numbers);

void PrintResult(int[] arr)
{
    int size=arr.Length;
    for (int i = 0; i <size ; i++)
    {
        if(arr[i]!=0) Console.Write($"{arr[i]} ");
    }
}

PrintResult(res);