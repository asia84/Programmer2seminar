/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, 
то программа выводит остаток от деления. 34, 5 -> 
не кратно, остаток 4 16, 4 -> кратно 
*/

int randomNumber1 = new Random().Next(1, 100);//определяет рандомное число1
//определяет рандомное число2
int randomNumber2 = new Random().Next(1, 100);
int result = 0;
if (randomNumber1 % randomNumber2 == 0)
{
    Console.WriteLine($"Число {randomNumber1} кратно числу {randomNumber2}");
}
else
{
     result =randomNumber1 % randomNumber2;
    Console.WriteLine($"Число {randomNumber1} некратно числу {randomNumber2}, остаток от деления = {result}");
    
}


