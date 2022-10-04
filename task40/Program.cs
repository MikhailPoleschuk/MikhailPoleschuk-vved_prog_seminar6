// 40
Console.Clear();
Console.WriteLine("Введите AB:");
int AB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите AB:");
int BC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите AC:");
int AC = Convert.ToInt32(Console.ReadLine());

if (AB > BC + AC || BC > AB + AC || AC > AB + BC) Console.WriteLine("не треугольник");
else Console.WriteLine("все ок");