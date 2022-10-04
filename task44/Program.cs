// 44
Console.Clear();
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());
int a=0;
Console.Write($"{a} ");
int b=1;
Console.Write($"{b} ");
int temp=-1;
for (int i=0; i<N-2; i++)
{ 
    Console.Write($"{a+b} ");
    temp=a;
    a=b;
    b=a+temp;
}

