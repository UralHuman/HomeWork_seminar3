Console.Clear();
System.Console.Write("Введите кординаты x1--> ");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите кординаты x2--> ");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите кординаты y1--> ");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите кординаты y2--> ");
double y2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите кординаты z1--> ");
double z1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите кординаты z2--> ");
double z2 = Convert.ToDouble(Console.ReadLine());
double AB = (x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2);


System.Console.WriteLine($"{(Math.Sqrt(AB))}" );
