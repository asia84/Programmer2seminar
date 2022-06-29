/*Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого. 5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет
*/

//int randomNumber = new Random().Next(1, 1000);//определяет рандомное число

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

//int squareOfNumber = number1*number;    

if (number1*number1 == number2)
{
    Console.WriteLine($"Числo {number2} является квадратом числа {number1}");
}
else
{
    if (number2*number2 == number1)
    {
        Console.WriteLine($"Числo {number1} является квадратом числа {number2}");
    }
    else
    {
        Console.WriteLine($"Ни одно из чисел не является квадратом другого");
    }
}