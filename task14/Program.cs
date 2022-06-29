/*Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23. 
14 -> нет 46 -> нет 161 -> да */

//int randomNumber = new Random().Next(1, 1000);//определяет рандомное число
Console.Write("Введите число, чтобы определить его кратность: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
Console.WriteLine (number); //(randomNumber);
    if (number % (7 *23) == 0)
    {
    
        Console.WriteLine($"Число {number} кратно числу 7 и 23");
    }

    else
    {
        result = number % (7*23);
        Console.WriteLine ($"Число {number} не кратно числам 7 и 23");
    }    











