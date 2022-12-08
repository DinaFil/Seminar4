Console.Clear();
Console.WriteLine("input number");
int number = Convert.ToInt32(Console.ReadLine());

int Proizv(int M)
{
int pz=1;
while (1 != M)
{
pz = pz * M;
M--;
}
return pz;
}
Console.WriteLine(Proizv(number));


// Функция возведения в степень
// double Pow(int number, int a) 
// {
//     int result = 1;
//     for (int i = 0; i < a; i++)
//     {
//         result *= number;
//     }
//     return result;
//     }

// Console.WriteLine(Pow(3,4))





