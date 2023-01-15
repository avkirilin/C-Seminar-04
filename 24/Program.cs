// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
Console.WriteLine ("Введите любое положительное целое число");
int a = Convert.ToInt32(Console.ReadLine());
int summ = 0;
for (int i = 0; i <= a; i++)
{
    summ = summ + i;
}
Console.WriteLine ($"Сумма чисел от 1 до {a} будет равна {summ}");