using System;


namespace laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            //День недели
            Random rnd = new Random();
            Console.WriteLine("какой по счету день недели? " );
            int ghg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Который час? ");
            int time = Convert.ToInt32(Console.ReadLine());

            DayOfWeek dayofweek = new DayOfWeek();
            DayTime daytime = new DayTime();

            if (Enum.IsDefined(typeof(DayOfWeek), ghg))
            {
                dayofweek = (DayOfWeek)ghg;
            }
            else
            {
                    throw new Exception("Invalid DayOfWeek value.");
            }
            
            if (time >= 0 && time < 6)
            {
                daytime = DayTime.Ночь;
                Console.WriteLine("Сегодня " + dayofweek + ". Время " + time + ", " + daytime);
            }
            if (time >= 6 && time < 12)
            {
                daytime = DayTime.Утро;
                Console.WriteLine("Сегодня " + dayofweek + ". Время " + time + ", " + daytime);
            }
            if (time >= 12 && time < 18)
            {
                daytime = DayTime.День;
                Console.WriteLine("Сегодня " + dayofweek + ". Время " + time + ", " + daytime);
            }
            if (time >= 18 && time < 24)
            {
                daytime = DayTime.Вечер;
                Console.WriteLine("Сегодня " + dayofweek + ". Время " + time + ", " + daytime);
            }
            if(time >= 24)
            {
                Console.WriteLine("Неверное время");
            }
        }
        
            enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sanday
        }
        enum DayTime
        {
            Утро,
            День,
            Вечер,
            Ночь
        }
        
    }
}
