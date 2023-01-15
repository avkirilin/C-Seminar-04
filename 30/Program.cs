// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
void FillArray(int[] znachenie)
{
    int lenght = znachenie.Length;
    int index = 0;
    while (index < lenght)
    {
        znachenie[index] = new Random().Next(0, 2);
        index++;
    }
}
void PrintArray(int[] chisla)
{
    int count = chisla.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{chisla[position]} ");
        position++;
    }
}
int[] array = new int[8];

FillArray(array);
PrintArray(array);