//42


void PrintArray(int[] AnyArrayToPrint)
{
    for (int i = 0; i < AnyArrayToPrint.Length; i++)
    {
        Console.Write($" {AnyArrayToPrint[i]} |");
    }
}

int ArrayToInt(int[] AnyArray)
{
    int Number = AnyArray[0];

    for (int i = 1; i < AnyArray.Length; i++)
    {
        Number = Number * 10 + AnyArray[i];
    }
    return Number;
}

int[] NumberToArray(int N)
{
    int Chastnoe = N / 2;
    int ost = N % 2;
    int chislo = ost;
    int count = 1;

    while (Chastnoe > 0)
    {
        ost = Chastnoe % 2;
        Chastnoe = Chastnoe / 2;
        count++;
    }

    int[] array = new int[count];

    Chastnoe = N;
    int EndPos = array.Length - 1;
    for (int i = 0; i < array.Length; i++)
    {
        array[EndPos] = Chastnoe % 2;
        EndPos--;
        Chastnoe = Chastnoe / 2;

    }
    return array;
}


Console.Clear();
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());

int[] arr1= NumberToArray(N);

//PrintArray(arr1);

int num = ArrayToInt(arr1);
Console.WriteLine();
Console.WriteLine(num);