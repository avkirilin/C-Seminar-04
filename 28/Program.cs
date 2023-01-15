Console.WriteLine ("Введите любое положительное целое число");
int a = Convert.ToInt32(Console.ReadLine());
int umnoj = 1;
for (int i = 1; i <= a; i++)
{
    umnoj = umnoj * i;
}
Console.WriteLine ($"Произведение чисел от 1 до {a} будет равна {umnoj}");