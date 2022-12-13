//Задача 27: Напишите программу, которая принимает на вход число
//           и выдаёт сумму цифр в числе:   452 -> 11, 82 -> 10, 9012 -> 12


int SummDigits(int A)
    {
        int n = A % 10;

            while (A > 0) 
            {
                A = A / 10;
                n = n + A % 10;
            }
            
        return n;
    }
    int EnterData(string text)
    {
        Console.Write(text);
        int number = int.Parse(Console.ReadLine());
        return number;
    }
        int A = EnterData($"Введите число ");
        int N = SummDigits(A);
        Console.WriteLine("Сумма цифр в числе равна " + N);

