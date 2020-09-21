using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_4
{
    //Вариант 9
    class Time
    {
        private int hour;
        private int minute;
        private int second;
        private int difHour;
        private int difMin;
        private int difSec;

        public Time() 
        { 
            hour = DateTime.Now.Hour; 
            minute = DateTime.Now.Minute; 
            second = DateTime.Now.Second; 
        }

        public Time(int hour, int minute, int second)
        {
                try
                {

                    this.hour = hour;
                    this.minute = minute;
                    this.second = second;

                    if (hour > 23 || hour < 0 ||
                        minute > 59 || minute < 0 ||
                        second > 59 || second < 0)
                    {
                        throw new Exception("Введен неверный формат времени");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
        }

        public int Hour
        {
            set
            {
                hour = value;
            }
            get
            {
                return hour;
            }          
        }

        public int Minute
        {
            set
            {
                minute = value;
            }
            get
            {
                return minute;
            }
        }

        public int Second
        {
            set
            {
                second = value;
            }
            get
            {
                return second;
            }
        }

        public void printTime()
        {
            Console.WriteLine($" время: {hour}:{minute}:{second}");
        }
        public void getTime()
        {
            Console.Write("Введенное");
            printTime();
        }
        public int DifHour
        {
            set
            {
                difHour = value;
            }

            get
            {
                return difHour;
            }
        }
        public int DifMin
        {
            set
            {
                difMin = value;
            }

            get
            {
                return difMin;
            }
        }
        public int DifSec
        {
            set
            {
                difSec = value;
            }

            get
            {
                return difSec;
            }
        }
        public void howUpdateTime()
        {
            updateTime(difHour, difMin, difSec);
        }

        public void updateTime(int difHour, int difMin, int difSec)
        {
            DateTime dateTime = new DateTime(2020, 9, 1, hour, minute, second);
            var newTime = dateTime.AddHours(difHour).AddMinutes(difMin).AddSeconds(difSec);
            Console.WriteLine("\nНовое время: " + newTime.ToLongTimeString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();

            Console.Write("Текущее");
            time.printTime();

            Console.WriteLine("\nЧтобы ввести свое время нажмите '1'\nДля продолжения нажмите любую цифру");
            char castom = Convert.ToChar(Console.ReadLine());

            switch (castom)
            {
                case '1':
                    Console.Write("\nЧасы: ");
                    time.Hour = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nМинуты: ");
                    time.Minute = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nСекунды: ");
                    time.Second = Convert.ToInt32(Console.ReadLine());
                    break;
            }   

            Console.WriteLine("\nЧтобы изменить время нажмите '2'\nДля выхода нажмите любую цифру");
            char upd = Convert.ToChar(Console.ReadLine());

            switch(upd)
            {
                case '2':
                    Console.WriteLine("\nНа сколько часов нужно изменить время?");
                    time.DifHour = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("На сколько минут нужно изменить время?");
                    time.DifMin = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("На сколько секунд нужно изменить время?");
                    time.DifSec = Convert.ToInt32(Console.ReadLine());

                    time.howUpdateTime();
                    break;
            }

        }
    }
}
