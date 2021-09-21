using CalarSaat.Data;
using CalarSaat.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalarSaat.UI
{
    public partial class FrmAlarm : Form
    {
        Alarm alarm;
        WebBrowser wbYoutube;
        bool baglanti;
        public FrmAlarm(Alarm alarm)
        {
            HazirAlarmCal();
            InitializeComponent();
            this.alarm = alarm;
            DbContext.AktifAlarmVar = true;
            if(alarm.AlarmYoutubeMu)
            {
                try
                {
                    baglanti = new Ping().Send("www.youtube.com").Status == IPStatus.Success;
                }
                catch (Exception)
                {

                    baglanti = false;
                }

                if(baglanti)
                {
                    wbYoutube = new WebBrowser();
                    wbYoutube.Size = new Size(this.Size.Width, this.Size.Height - 50);
                    wbYoutube.Navigate(String.Format("https://www.youtube.com/v/{0}", alarm.VideoId));
                } 
                else
                {
                    label1.Text = "int sorunlu";
                }
            }
        }
        private void btnErtele_Click(object sender, EventArgs e)
        {
            if(alarm.AlarmYoutubeMu && baglanti)
            {
                wbYoutube.Navigate(string.Empty);
            }
            DbContext.AktifAlarmVar = false;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (alarm.AlarmYoutubeMu && baglanti)
            {
                wbYoutube.Navigate(string.Empty);
            }
            
            DbContext.AktifAlarmVar = false;
            this.Close();
        }

        private void FrmAlarm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alarm.AlarmYoutubeMu && baglanti)
            {
                wbYoutube.Navigate(string.Empty);
            }
            DbContext.AktifAlarmVar = false;
        }

        private void HazirAlarmCal()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.Play();
        }

    }
}
