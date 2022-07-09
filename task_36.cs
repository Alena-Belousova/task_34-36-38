// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, 
//стоящих на нечётных позициях
Console.WriteLine("задача 36");
Console.Write("введите размер массива: ");//5
int size = Convert.ToInt32(Console.ReadLine());
int[] array=new int[size];
int sum = 0;

for(int index = 0; index<size; index++)
{
    array[index] =new Random().Next(0,100);
    Console.WriteLine(array[index] + " ");//.....

    if(index%2!=0){
sum=sum+array[index];
    }
   
}int NumberIndex0=sum+array[0];
Console.WriteLine("сумма чисел с нечетным индексом = "+sum);
 Console.WriteLine("сумма, с учетом элемента, с индексом 0 = "+ NumberIndex0);



