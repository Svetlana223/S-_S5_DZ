//Задача 36.Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.[3, 7, 23, 12] -> 19   [-4, -6, 89, 6] -> 0

Console.WriteLine("Задайте длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
int [] randomArray = new int[Length];
void FillArray(int [] Array)
{
    for(int i = 0; i <Array.Length; i++)
    {
        Array[i] = new Random().Next(0,10);
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
FillArray(randomArray);
WriteArray(randomArray);
int sum = 0;
for(int i = 1; i < randomArray.Length; i++)
{
    sum = randomArray[i] + sum;
    i++;
}
Console.WriteLine($"Сумма чисел на нечетных позициях индекса = {sum}");
