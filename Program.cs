// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] array =  new int[6];// создали массив из 6 эл

int count = 0; //количество чисел
int size = array.Length;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100,1000); 
          if (array[i] % 2 == 0) count++;
}
Console.WriteLine($"[ {String.Join(",",array)}]");
Console.WriteLine($" Количество положительных элементов {count}");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] array =  new int[6];// создали массив из 6 эл

int result = 0;
int size = array.Length;

for (int i = 0; i < size; i++) array[i] = new Random().Next(10); 
for (int i = 1; i < size; i+=2)  result = array[i] + result;

Console.WriteLine($"[ {String.Join(",",array)}]");
Console.WriteLine($" суммa элементов, стоящих на нечётных позициях: {result}");
*/


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] array = new double [10];
int size = array.Length;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().NextDouble();
    array[i] *=100;
    array[i] = Math.Round(array[i],3);

    Console.Write(array[i] + "   ");
}

double max = array[0];
double min = array[0];

for (int i = 0; i < size; i++)
{
   if (array[i] > max) max = array[i];
  if (array[i] < min) min = array[i];
}
Console.WriteLine($"Mаксимальная цифра - это {max}");
Console.WriteLine($"Mинимальная цифра - это {min}");
Console.WriteLine($"Разница - это {(max -min)}");
