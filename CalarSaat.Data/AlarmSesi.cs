using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalarSaat.Data
{
    public class AlarmSesi
    {
        public int Id { get; set; }

        public int AlarmId { get; set; }

        public string AlarmSesAdi { get; set; } = "Alarm Dediğin Böyle Olur";

        public string AlarmSesYolu { get; set; } = AppDomain.CurrentDomain.BaseDirectory + @"Resources\alarm_dedigin_boyle_olur.wav";
    }
}
