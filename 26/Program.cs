// Напишите программу, которая принимает на вход число и выдает кол-во цифр в числе
Console.WriteLine("Введите любюе целое число");
int a = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (a > 0)
{
    i++;
    a /= 10;
}
Console.WriteLine($"Кол-во цифр в данном числе будет равно: {i}");
