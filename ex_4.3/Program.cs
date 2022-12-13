//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

void NewAr()
{
    int[] ar = new int[8];
    for (int i = 0; i < ar.Length; i++)
    {
        ar[i] = new Random().Next(0, 20);
        Console.Write($"{ar[i]}, ");
    }

}

//Console.Clear();
NewAr();