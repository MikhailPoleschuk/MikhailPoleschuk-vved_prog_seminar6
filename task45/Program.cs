// 45

Console.Clear();

int[] CopyAray(int[] AnyArray)
{
    
    int[] CopyArray = new int[AnyArray.Length];

    int N = AnyArray.Length - 1;
    for (int i = 0; i < AnyArray.Length; i++)
    {
        Console.WriteLine();
        CopyArray[i] = AnyArray[i];
        Console.Write($" {AnyArray[i]} |");
        
    }
    return CopyArray;
}

void PrintArray(int[] AnyArrayToPrint)
{
    for (int i = 0; i < AnyArrayToPrint.Length; i++)
    {
        Console.Write($" {AnyArrayToPrint[i]} |");
    }
}



int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
PrintArray(arr1);
int[] arr2 = CopyAray(arr1);
Console.WriteLine();
PrintArray(arr2);