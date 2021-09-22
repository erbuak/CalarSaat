using System;
using System.Collections.Generic;

namespace CalarSaat.Data
{
    public class DbContext
    {
        public static List<Alarm> Alarmlar { get; set; } = new List<Alarm>();

        public static bool AcikAlarmVar { get; set; }

        public static SortedDictionary<string, string> AlarmSesleri = new SortedDictionary<string, string> 
        {
            { "Alarm Dediğin Böyle Olur", AppDomain.CurrentDomain.BaseDirectory + @"Resources\alarm_dedigin_boyle_olur.wav" },
            { "Gemi Batıyor", AppDomain.CurrentDomain.BaseDirectory + @"Resources\gemi_batiyor.wav" },
        };
    }
}
