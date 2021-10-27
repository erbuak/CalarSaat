using CalarSaat.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CalarSaat.UI
{
    public partial class FrmAnaSayfa : Form
    {
        AlarmKart ak;
        FrmAlarmKur frmAlarmKur;
        FrmAlarm frmAlarm;
        readonly List<Alarm> alarmlar = DbContext.Alarmlar;
        int i = 0;
        TimeSpan ts;
        DateTime dtAlarmZamani;

        public FrmAnaSayfa()
        {  
            InitializeComponent();
            pnlAlarmKartlari.BorderStyle = BorderStyle.FixedSingle;
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");
            AlarmDurumuGoster();
            AlarmlariGoster();
        }

        public void EventGuncelle(object sender, EventArgs e)
        {
            AlarmDurumuGoster();
            AlarmlariGoster();
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            AlarmDurumuGoster();
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");
            foreach (Alarm alarm in DbContext.Alarmlar)
            {
                if(alarm.TekrarlıMı)
                {
                    if (alarm.AlarmZamani.Hours == DateTime.Now.Hour && alarm.AlarmZamani.Minutes == DateTime.Now.Minute && alarm.AlarmZamani.Seconds == DateTime.Now.Second && !DbContext.AcikAlarmVar && alarm.TekrarGunleri.Contains((int)DateTime.Now.DayOfWeek))
                    {
                        frmAlarm = new FrmAlarm(alarm);
                        frmAlarm.ShowDialog();
                        AlarmlariGoster();
                    }
                } 
                else
                {
                    if (alarm.AlarmZamani.Hours == DateTime.Now.Hour && alarm.AlarmZamani.Minutes == DateTime.Now.Minute && alarm.AlarmZamani.Seconds == DateTime.Now.Second && !DbContext.AcikAlarmVar && alarm.AktifMi)
                    {
                        frmAlarm = new FrmAlarm(alarm);
                        frmAlarm.ShowDialog();
                        AlarmlariGoster();
                    }
                }
            }
        }

        private void AlarmDurumuGoster()
        {
            Alarm alarm = alarmlar.FirstOrDefault(x => x.AktifMi == true);
            if (alarm != null)
            {
                List<int> alarmaKalanGunSayilari = new List<int>();
                foreach (int i in alarm.TekrarGunleri)
                {
                    if(i >= (int)DateTime.Now.DayOfWeek)
                    {
                        alarmaKalanGunSayilari.Add(Math.Abs(i - (int)DateTime.Now.DayOfWeek));
                    } 
                    else
                    {
                        alarmaKalanGunSayilari.Add(Math.Abs(i - (int)DateTime.Now.DayOfWeek + 7));
                    }
                }
                
                if(alarm.TekrarlıMı)
                {
                    if ((alarm.OlusturulmaTarihi.Hour * 60 + alarm.OlusturulmaTarihi.Minute) >= alarm.AlarmZamani.Hours * 60 + alarm.AlarmZamani.Minutes)
                    {
                        dtAlarmZamani = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, alarm.AlarmZamani.Hours, alarm.AlarmZamani.Minutes, 0).AddDays(1 + alarmaKalanGunSayilari.Min());
                    }
                    else
                    {
                        dtAlarmZamani = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, alarm.AlarmZamani.Hours, alarm.AlarmZamani.Minutes, 0).AddDays(alarmaKalanGunSayilari.Min());
                    }

                    if(alarmaKalanGunSayilari.Min() == 0)
                    {
                        ts = dtAlarmZamani - DateTime.Now;
                        lblAlarmDurumu.Text = "Sırdaki Alarma Kalan Süre: " +  ts.Hours + " Saat " + ts.Minutes + " Dakika " + ts.Seconds + " Saniye";
                    }
                    else
                    {
                        ts = dtAlarmZamani - DateTime.Now;
                        lblAlarmDurumu.Text = "Sırdaki Alarma Kalan Süre: " + ts.Days + " Gün " + ts.Hours + " Saat " + ts.Minutes + " Dakika " + ts.Seconds + " Saniye";
                    }
                } 
                else
                {
                    if ((alarm.OlusturulmaTarihi.Hour * 60 + alarm.OlusturulmaTarihi.Minute) >= alarm.AlarmZamani.Hours * 60 + alarm.AlarmZamani.Minutes)
                    {
                        dtAlarmZamani = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1, alarm.AlarmZamani.Hours, alarm.AlarmZamani.Minutes, 0);
                    }
                    else
                    {
                        dtAlarmZamani = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, alarm.AlarmZamani.Hours, alarm.AlarmZamani.Minutes, 0);
                    }
                    ts = dtAlarmZamani - DateTime.Now;
                    lblAlarmDurumu.Text = "Sırdaki Alarma Kalan Süre: " + ts.Hours + " Saat " + ts.Minutes + " Dakika " + ts.Seconds + " Saniye";
                }
            } 
            else
            {
                lblAlarmDurumu.Text = String.Empty;
            }
        }

        private void AlarmlariGoster()
        {
            pnlAlarmKartlari.Controls.Clear();
            i = 0;
            foreach (Alarm alarm in AlarmSirala())
            {
                pnlAlarmKartlari.AutoScroll = true;
                ak = new AlarmKart(pnlAlarmKartlari.Size.Width - 19, 60, alarm, this);
                ak.Location = new Point(0, i * 64);
                pnlAlarmKartlari.Controls.Add(ak);
                i++;
            }
        }

        private List<Alarm> AlarmSirala()
        {
            List<Alarm> alarmlar = DbContext.Alarmlar;

            Alarm temp;

            for(int i = 0; i < alarmlar.Count; i++)
            {
                for(int j = i + 1; j < alarmlar.Count ; j++)
                {
                    if ((alarmlar[i].AlarmZamani.Hours * 60 + alarmlar[i].AlarmZamani.Minutes) > (alarmlar[j].AlarmZamani.Hours * 60 + alarmlar[j].AlarmZamani.Minutes))
                    {
                        temp = alarmlar[i];
                        alarmlar[i] = alarmlar[j];
                        alarmlar[j] = temp;
                    }
                }

            }
            return alarmlar;
        }

        private void BtnAlarmEkle_Click(object sender, EventArgs e)
        {
            frmAlarmKur = new FrmAlarmKur();
            frmAlarmKur.ShowDialog();
            AlarmDurumuGoster();
            AlarmlariGoster();
        }
    }
}
