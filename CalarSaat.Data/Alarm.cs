using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CalarSaat.Data
{
    public class Alarm
    {

        public Alarm()
        {
            Id = Guid.NewGuid().ToString();
            OlusturulmaTarihi = DateTime.Now;
        }

        public Alarm(string youtubeLink)
        {
            Id = Guid.NewGuid().ToString();
            OlusturulmaTarihi = DateTime.Now;
            VideoId = VideoIdCek(youtubeLink);
        }

        public string Id { get; }
        public string AlarmAdi { get; set; }
        public bool AktifMi { get; set; }
        public bool TekrarlıMı { get; set; }
        public DateTime OlusturulmaTarihi { get; } = DateTime.Now;
        public List<int> TekrarGunleri { get; set; } = new List<int>();
        public TimeSpan AlarmZamani { get; set; }
        public string AlarmSesAdi { get; set; } = "Alarm Dediğin Böyle Olur";
        public string AlarmSesYolu { get; set; } = AppDomain.CurrentDomain.BaseDirectory + @"Resources\alarm_dedigin_boyle_olur.wav";
        public Dictionary<string,string> AlarmSes { get; set; }
        public bool AlarmYoutubeMu { get; set; } = false;
        public string VideoId { get; set; }

        private string VideoIdCek(string youtubeLink)
        {
            var youtubeLinkMatch = new Regex(@"http(?:s?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match(youtubeLink);
            return youtubeLinkMatch.Success ? youtubeLinkMatch.Groups[1].Value : string.Empty;
        }
    }
}

