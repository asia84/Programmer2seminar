/* Напишите программу которая будет выводить случайное число из отрезка [10 , 99] и 
показывает наибольшую цифру из этого числа.
78->8
12->2
85->8 */

int GentRandomNumber (int minBorder, int maxBorder)              //функция. название произвольное, но логичное
{
   return new Random().Next(minBorder,maxBorder+1);      //входные параметры min,max//возвращаем и экранируем, чтобы было красиво, не строгое равенство, как в задаче
}
int getMaxDigit(int number)             // число на вход number и нам надо понять, какое из двух чисел больше// пишем вторую функцию
{
        int result = 0;
        number = Math.Abs(number);
        if(number > 10 && number < 100 )    //есть ли тут два числа
        {
            int digitOne = number / 10;//56/10=5.6 отбрасывается остаток и остается 5
            int digitTwo = number % 10;// остаток от деления 56 / 10= 5,6 но нам нужен остаток, а остаток будет = 6
            result = digitOne;//для наглядности,к примеру //первое число приравниваем к результату
            if(result < digitTwo)//если первое число меньше второго, то
            {
                result = digitTwo;//результатом будет второе число
            }
             return result;
        }
        else
        {
            Console.WriteLine($"Число {number}, не в границе [10, 99]");
        }
        
        return result;
} 
int randomNumber = GentRandomNumber(10, 99);   //получить рандомное число. выводит псевдорондомное число, можно прописать множество раз,указав на номер randomNumber1,2,3,4,5  и тд.
int maxDigit = getMaxDigit (randomNumber);
Console.WriteLine($"наибольшая цифра числа {randomNumber} это {maxDigit}");      //(такое же количество раз, что и выше строчкой, указав в скобках какой randomNumber 1,2,3,4,5, и тд )