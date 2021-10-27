using System;
using System.Collections.Generic;

namespace CalarSaat.Data
{
    public class DbContext
    {
        public static List<Alarm> Alarmlar { get; set; } = new List<Alarm>();

        public static bool AcikAlarmVar { get; set; }
    }
}