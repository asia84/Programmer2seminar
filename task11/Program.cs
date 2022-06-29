/* напишите программу, которая выводит трехзначное число и удаляет вторую цифру из этого числа
489->49
567->57
124->14 
*/


int randomNumber = new Random().Next(100,999);//определяет рандомное число
Console.WriteLine(randomNumber);              //--/---/

int number1 = randomNumber / 100;
int number2 = (randomNumber % 100)/10;
int number3 =  randomNumber % 10;


Console.WriteLine($"{number1}{number3}");










