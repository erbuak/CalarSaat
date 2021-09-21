using CalarSaat.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalarSaat.UI
{
    public partial class FrmAnaSayfa : Form
    {
        AlarmKart ak;
        FrmAlarmKur frmAlarmKur;
        FrmAlarm frmAlarm;

        public FrmAnaSayfa()
        {  
            InitializeComponent();
            pnlAlarmKartlari.BorderStyle = BorderStyle.FixedSingle;
            for (int i=0; i<5; i++)
            {
                pnlAlarmKartlari.AutoScroll = true;
                ak = new AlarmKart(pnlAlarmKartlari.Size.Width - 19, 60);
                ak.Location = new Point(0, i * 64);
                pnlAlarmKartlari.Controls.Add(ak);
            }
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            
            foreach (Alarm alarm in DbContext.Alarmlar)
            {
                if(alarm.AlarmZamani.Hours == DateTime.Now.Hour && alarm.AlarmZamani.Minutes == DateTime.Now.Minute && alarm.AlarmZamani.Seconds == DateTime.Now.Second && DbContext.AktifAlarmVar == false)
                {
                        frmAlarm = new FrmAlarm(alarm);
                        frmAlarm.ShowDialog();
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
