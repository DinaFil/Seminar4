Console.WriteLine("input number");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (number == 0)
{
    Console.WriteLine("1");
}
else
{while (number > 0)
{
number /= 10;
count++;
}
Console.WriteLine(count);
}