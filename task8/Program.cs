Console.Write("Введите любое число: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = 1;

while (number1 >= number2)
{
   if (number2 % 2 == 0)
   {
      Console.Write("" + number2 + " ");
   }
   number2++;
}
