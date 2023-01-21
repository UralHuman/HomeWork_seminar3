Console.Clear();
System.Console.WriteLine("Введите кординаты: x1,x2,y1,y2,z1,z2--> ");
double x1 = Convert.ToDouble(Console.ReadLine());
double x2 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

double AB = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));

double truncated = Math.Truncate(AB * 100) / 100;

System.Console.WriteLine($"Расстояние между точкой А и точкой В--> {(truncated)}" );
