//Задача 38. Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76

Console.WriteLine("Задайте длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
int [] randomArray = new int[Length];
void FillArray(int [] Array)
{
    for(int i = 0; i <Array.Length; i++)
    {
        Array[i] = new Random().Next(0,100);
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
int max = 0;
int min = randomArray[0];
for (int i = 0; i < randomArray.Length; i++)
{
    if(randomArray[i] < min)
    {
        min = randomArray[i];
    }
    else
    {
        if (randomArray[i]> max)
        {
            max = randomArray[i];
        }
    }
}
int diff = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + diff);