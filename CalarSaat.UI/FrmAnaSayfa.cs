using CalarSaat.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalarSaat.UI
{
    public partial class FrmAnaSayfa : Form
    {
        AlarmKart ak;
        FrmAlarmKur frmAlarmKur;
        FrmAlarm frmAlarm;
        int i = 0;

        public FrmAnaSayfa()
        {  
            InitializeComponent();
            pnlAlarmKartlari.BorderStyle = BorderStyle.FixedSingle;
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");
            DbContext.Alarmlar.Add(
                new Alarm()
                    {
                        AktifMi = true,
                        AlarmAdi = "Merhaba",
                        AlarmZamani = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0),
                        TekrarGunleri = new List<int>() { 0, 3, 5 }
                    }
                );
            AlarmDurumuGoster();

            foreach (Alarm alarm in DbContext.Alarmlar)
            {
                pnlAlarmKartlari.AutoScroll = true;
                ak = new AlarmKart(pnlAlarmKartlari.Size.Width - 19, 60,alarm);
                ak.Location = new Point(0, i * 64);
                pnlAlarmKartlari.Controls.Add(ak);
                i++;
            }

        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");
            foreach (Alarm alarm in DbContext.Alarmlar)
            {
                if(alarm.TekrarlıMı)
                {
                    if (alarm.AlarmZamani.Hours == DateTime.Now.Hour && alarm.AlarmZamani.Minutes == DateTime.Now.Minute && alarm.AlarmZamani.Seconds == DateTime.Now.Second && !DbContext.AcikAlarmVar && alarm.TekrarGunleri.Contains((int)DateTime.Now.DayOfWeek))
                    {
                        frmAlarm = new FrmAlarm(alarm);
                        frmAlarm.ShowDialog();
                    }
                } else
                {
                    if (alarm.AlarmZamani.Hours == DateTime.Now.Hour && alarm.AlarmZamani.Minutes == DateTime.Now.Minute && alarm.AlarmZamani.Seconds == DateTime.Now.Second && !DbContext.AcikAlarmVar && alarm.AktifMi)
                    {
                        frmAlarm = new FrmAlarm(alarm);
                        frmAlarm.ShowDialog();
                    }
                }
            }
        }

        private void AlarmDurumuGoster()
        {
            if (DbContext.Alarmlar.Count < 1)
                lblAlarmDurumu.Text = "Tüm alarmlar kapalı!";

            foreach (Alarm alarm in DbContext.Alarmlar)
            { 
                if (!alarm.AktifMi)
                {
                    lblAlarmDurumu.Text = "Tüm alarmlar kapalı!";
                    //return;
                }
            }
        }
        private void btnAlarmEkle_Click(object sender, EventArgs e)
        {
            frmAlarmKur = new FrmAlarmKur();
            frmAlarmKur.ShowDialog();
        }
    }
}
