// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("задача 38");
Console.Write("введите размер массива: ");//5
int size = Convert.ToInt32(Console.ReadLine());

double[] array=new double[size];

for(int index = 0; index<size; index++)
{
    array[index] =new Random().NextDouble()*100;
    array[index]=Math.Round(array[index],2);
    Console.Write(array[index] + " ");
    Console.WriteLine();
    }
    double numberMax=array.Max();
        Console.WriteLine("максимум "+numberMax );
        double numberMin=array.Min();
        Console.WriteLine("минимум "+numberMin );
        double itog=numberMax- numberMin;
       itog= Math.Round(itog,2);
        Console.WriteLine("разница между максимальным и минимальным элементами = "+itog );