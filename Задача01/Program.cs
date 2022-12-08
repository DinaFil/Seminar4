// int sum = 0;
// if (number < 1) Console.WriteLine("Введено некорректное число");
// else
// {
// for (int i = 1; i <=number; i++)
// {
// sum +=i;
// }
// }
// Console.WriteLine(sum);

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumerals(number));

int SumNumerals(int numbers)
{
int sum = 0;
for (int i = 1; i <=number; i++)
{
sum +=i;
}
return sum;
}
