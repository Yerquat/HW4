//    Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//               и возводит число A в натуральную степень B:  3, 5 -> 243 (3⁵),   2, 4 -> 16.


double ApowerB(int A, int B) 
     {
        double C = Math.Pow(A, B);
        
            double result = C;
        return result;
     }
    
     int EnterData(string text)
        {
            Console.WriteLine(text);
            int number = int.Parse(Console.ReadLine());
            return number;
        } 
        int A = EnterData($"Введите число A ");
        int B = EnterData($"Введите число B ");
        double number = ApowerB(A, B);
        Console.WriteLine("А в степени В равно " + number);
