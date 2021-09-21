using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalarSaat.Data
{
    public class DbContext
    {
        public static List<Alarm> Alarmlar = new List<Alarm>();
        public static bool AktifAlarmVar { get; set; }
    }
}
