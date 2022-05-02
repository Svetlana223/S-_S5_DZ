//Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

void FillArray(int [] Array)
{
    for(int i = 0; i <Array.Length; i++)
    {
        Array[i] = new Random().Next(100,1000);
    }
}
void WriteArray(int [] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Задайте длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
int [] randomArray = new int[Length];
FillArray(randomArray);
WriteArray(randomArray);
int count = 0;
for(int i = 0; i < randomArray.Length; i++)
{
    if(randomArray[i] %2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве = {count}");
