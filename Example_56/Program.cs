//Задача 56: Написать программу, которая обменивает
//элементы первой строки и последней строки
int[,] mass = new int [4,6];
for(int i = 0; i < mass.GetLength(0); i++)
{
    for(int j = 0; j < mass.GetLength(1); j++)
    {
        mass [i,j] = new Random().Next(1,50);
        Console.Write(mass[i,j] + " ");
    }
    Console.WriteLine();
}
for(int i = 0; i < mass.GetLength(1); i++)
{
    int n = mass[0,i];  // в переменную n вложили первую строку массива
    mass[0,i] = mass[mass.GetLength(0) - 1, i]; // первая строка = длина строки - 1, т.к. кол-во элементов меньше на 1 длины строки
    //mass.GetLength(1);
   // Console.WriteLine(mass.GetLength(0) - 1);
    mass[mass.GetLength(0) - 1, i] = n;
}
Console.WriteLine();
for(int i = 0; i < mass.GetLength(0); i++)
{
    for(int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i,j] + " ");
    }
    Console.WriteLine();
}
