// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("задача 38");
Console.Write("введите размер массива: ");//5
int size = Convert.ToInt32(Console.ReadLine());
int[] array=new int[size];
for(int index = 0; index<size; index++)
{
    array[index] =new Random().Next(0,100);
    Console.Write(array[index] + " ");
    Console.WriteLine();
    }
    int numberMax=array.Max();
        Console.WriteLine("максимум "+numberMax );
        int numberMin=array.Min();
        Console.WriteLine("минимум "+numberMin );
        int itog=numberMax- numberMin;
        Console.WriteLine("разница между максимальным и минимальным элементами = "+itog );