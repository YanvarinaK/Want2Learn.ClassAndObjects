using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.ClassAndObjects
{
    class Time
    {
        private const int SECINHOUR = 3600;

        private const int SECINMIN = 60;

        private const int MAXMINSEC = 59;

        private const int COUNTHOUR = 24;

        public int Hour { get; set; }

        public int Minute { get; set; }

        public int Second { get; set; }

        public Time()
        {
        
        }

        public Time(int hour, int minute, int second)
        {
            if ((hour >= COUNTHOUR) || (hour < 0))
            {
                throw new Exception(" Hour Validation Exception");
            }
            Hour = hour;
            if ((minute > MAXMINSEC) || (minute < 0))
            {
                throw new Exception(" Minute Validation Exception");
            }
            Minute = minute;
            if ((second > MAXMINSEC) || (second < 0))
            {
                throw new Exception(" Second Validation Exception");
            }
            Second = second;
        }

        public Time(int hour, int minute)
        {
            if ((hour >= COUNTHOUR) || (hour < 0))
            {
                throw new Exception(" Hour Validation Exception");
            }
            Hour = hour;
            if ((minute > MAXMINSEC) || (minute < 0))
            {
                throw new Exception(" Minute Validation Exception");
            }
            Minute = minute;
            Second = 0;
        }

        public Time(int hour)
        {
            if ((hour >= COUNTHOUR) || (hour < 0))
            {
                throw new Exception(" Hour Validation Exception");
            }
            Hour = hour;
            Minute = 0;
            Second = 0;
        }

        public void AddSeconds(int second)  
        {
            int hour = second / SECINHOUR;
            int minute = (second % SECINHOUR) / SECINMIN;
            second = second % SECINMIN;
            Second = Second + second;
            Minute = Minute + minute;
            Hour = Hour + hour;

            if (Second > MAXMINSEC)
            {
                Minute++;
                Second = Second - SECINHOUR;
            }
            if (Minute > MAXMINSEC)
            {
                Hour++;
                Minute = Minute - SECINMIN;
            }
            if (Hour >= COUNTHOUR)
            {
                Hour = Hour % COUNTHOUR;
            }

        }

        public void AddMinutes(int minute)
        {
            int hour = minute / SECINMIN;
            minute = minute % SECINMIN;
            Minute = Minute + minute;
            Hour = Hour + hour;

            if (Minute > MAXMINSEC)
            {
                Hour++;
                Minute = Minute - SECINMIN;
            }
            if (Hour >= COUNTHOUR)
            {
                Hour = Hour % COUNTHOUR;
            }
        }

        public void AddHours(int hour)
        {
            Hour = Hour + hour;

            if (Hour >= COUNTHOUR)
            {
                Hour = Hour % COUNTHOUR;
            }
        }

        public string GetTime()
        {
            string time = String.Format("{0:d2}:{1:d2}:{2:d2}", Hour, Minute, Second );
            return time;
        }

    }
}
