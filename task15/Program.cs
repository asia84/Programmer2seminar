namespace DayWEEk
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.Write($"ВВедите число дня недели: ");
            int number = Convert.ToInt32(Console.ReadLine());   

            Console.WriteLine(GetWeekday(number));
        }

        static string GetWeekday( int num )
        {
            if( num > 0 && num <= 5)
            {
                return $"Сегодня рабочий день";
            }
            else if(num > 5 && num < 8)
            {
                return $"Сегодня выходной";
            }
            else
            {
                return $"Введено неверное число";
            }
        }
    }
}






