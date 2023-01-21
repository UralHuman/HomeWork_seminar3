System.Console.Write("Введите пятизначое счисло--> ");

int a = Convert.ToInt32(System.Console.ReadLine());

int num1 = (a/10000);
int num2 = (((a/100)/10)%10);
int num4 = ((a/10)%10);
int num5 = (a%10);

if (num1==num5&&num2==num4)
{
    System.Console.WriteLine("Число является палиндромом");
}
else
{
    System.Console.WriteLine("Чисо не яыляется палиндромом");
}



