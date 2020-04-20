using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeStructExample
{
    struct Time
    {
        int hours;
        int minutes;
        int seconds;

        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public void SetHours(int hours)
        {
            this.hours = hours;
        }
        public void SetMinutes(int minutes)
        {
            this.minutes = minutes;
        }
        public void SetSeconds(int seconds)
        {
            this.seconds = seconds % 60;
            this.minutes = (seconds / 60) % 60;
            this.hours = seconds / 3600;
        }

        public override string ToString()
        {
            return $"{hours,2:D2}:{minutes,2:D2}:{seconds,2:D2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time t = new Time(0, 0, 0);
            t.SetSeconds(60);
            Console.WriteLine(t);
        }
    }
}
