using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
        public bool AktifMi { get; set; }
        public DateTime OlusturulmaTarihi { get; }
        public TimeSpan AlarmZamani { get; set; }
        public bool AlarmYoutubeMu { get; set; } = false;
        public string VideoId { get; set; }

        private string VideoIdCek(string youtubeLink)
        {
            var youtubeLinkMatch = new Regex(@"http(?:s?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match(youtubeLink);
            return youtubeLinkMatch.Success ? youtubeLinkMatch.Groups[1].Value : string.Empty;
        }
    }
}

