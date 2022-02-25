// Задача 58: Написать программу, которая в двумерном
//массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
int[,] mass = new int[3,3];
for(int i = 0; i < mass.GetLength(0); i++)
{
    for(int j = 0; j < mass.GetLength(1); j++)
    {
       mass[i,j] = new Random().Next(1,50);
       Console.Write(mass[i,j] + " ");
    }
    Console.WriteLine();
}
int[,] array = new int [mass.GetLength(0), mass.GetLength(1)];

Console.WriteLine();
if(mass.GetLength(0) == mass.GetLength(1))
{
for(int i = 0; i < mass.GetLength(0); i++)
{
    for(int j = 0; j < mass.GetLength(1); j++)
    {
        array[i,j] = mass[j,i];
        Console.Write(array[i,j] + " ");
    }
   Console.WriteLine();
}
Console.WriteLine();
}
else Console.WriteLine("Не возможно ввести, матрица не квадратная");