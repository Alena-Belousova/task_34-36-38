// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("задача 34");
Console.Write("введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array=new int[size];
int count= 0;
int index=0;
for ( index=0; index<size; index++)
{
   array[index]= new Random().Next(100,1000);
   Console.Write(array[index] + " ");
   
   if (array[index]%2==0)
   {count++; }
    }
 Console.WriteLine();
    Console.WriteLine(count +" "+ "четных чисел"); 

    

    

