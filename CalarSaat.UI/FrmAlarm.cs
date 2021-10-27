using CalarSaat.Data;
using System;
using System.Drawing;
using System.Media;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace CalarSaat.UI
{
    public partial class FrmAlarm : Form
    {
        Alarm alarm;
        WebBrowser wbYoutube;
        SoundPlayer sp;
        bool baglanti;
        public FrmAlarm(Alarm alarm)
        {      
            InitializeComponent();
            this.alarm = alarm;
            DbContext.AcikAlarmVar = true;
            if(alarm.AlarmYoutubeMu)
            {
                YoutubeAlarmCal();
            } 
            else
            {
                HazirAlarmCal();
            }
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");
            lblAlarmAd.Text = alarm.AlarmAdi;
        }
        private void btnErtele_Click(object sender, EventArgs e)
        {
            if(alarm.AlarmYoutubeMu && baglanti)
            {
                wbYoutube.Navigate(string.Empty);
            }
            DbContext.AcikAlarmVar = false;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            AlarmDurdur();
            this.Close();
        }

        private void FrmAlarm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AlarmDurdur();
        }

        private void HazirAlarmCal()
        {
            sp = new SoundPlayer();
            sp.SoundLocation = alarm.AlarmSes.Value;
            sp.PlayLooping();
        }

        private void YoutubeAlarmCal()
        {
            try
            {
                baglanti = new Ping().Send("www.youtube.com").Status == IPStatus.Success;
            }
            catch (Exception)
            {

                baglanti = false;
            }

            if (baglanti)
            {
                wbYoutube = new WebBrowser();
                wbYoutube.Size = new Size(this.Size.Width, this.Size.Height - 50);
                wbYoutube.Navigate(String.Format("https://www.youtube.com/v/{0}", alarm.VideoId));
            }
            else
            {
                HazirAlarmCal();
            }
        }

        private void AlarmDurdur()
        {
            if (alarm.AlarmYoutubeMu && baglanti)
            {
                wbYoutube.Navigate(string.Empty);
            }
            else if (alarm.AlarmYoutubeMu && !baglanti)
            {
                sp.Stop();
            } else if(!alarm.AlarmYoutubeMu)
            {
                sp.Stop();
            }

            if (!alarm.TekrarlıMı)
                alarm.AktifMi = false;

            DbContext.AcikAlarmVar = false;
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
