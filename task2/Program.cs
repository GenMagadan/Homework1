Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
   Console.Write("Max = " + number1 + "");
}
else if (number2 > number1)
{
   Console.Write("Max = " + number2 + "");
}
else
{
   Console.Write("Числа равны");
}
