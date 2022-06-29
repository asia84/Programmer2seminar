/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int randomNumber = new Random().Next(1, 1000000);//определяет рандомное число
int number = 0;
Console.WriteLine(randomNumber); 

if (randomNumber < 100)
{
    Console.WriteLine ("третьей цифры в этом числе нет");
}
else
{

while (randomNumber > 1000)
{
  randomNumber = ((randomNumber-randomNumber % 10) /10 );  
}
number = randomNumber % 10;

Console.WriteLine($"{number}");//вывели в консоль
}

