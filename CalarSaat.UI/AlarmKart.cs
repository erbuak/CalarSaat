using CalarSaat.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalarSaat.UI
{
    class AlarmKart : Panel
    {
        CheckBox cb = new CheckBox();
        Label lblSaat = new Label();
        Label lblAlarmAd = new Label();
        Label lblGun;
        Panel pnlGunler = new Panel();
        Alarm alarm;
        int x;
        public AlarmKart(int x, int y, Alarm alarm)
        {
            this.alarm = alarm;
            this.x = x;
            this.BackColor = Color.White;
            this.Size = new Size(x, y);
            this.Controls.Add(cb);
            this.Controls.Add(lblAlarmAd);
            this.Controls.Add(pnlGunler);
            IcerigiHazirla();
        }

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cb.Checked)
            {
                lblSaat.ForeColor = Color.Black;
                lblAlarmAd.ForeColor = Color.Black;
                pnlGunler.Enabled = true;
                alarm.AktifMi = true;
            }
            else
            {
                lblSaat.ForeColor = Color.FromArgb(224, 224, 224);
                lblAlarmAd.ForeColor = Color.FromArgb(224, 224, 224);
                pnlGunler.Enabled = false;
                alarm.AktifMi = false;
            }
        }

        private void IcerigiHazirla()
        {
            cb.Location = new Point(x - 30, 0);
            cb.CheckedChanged += Cb_CheckedChanged;
            cb.Checked = alarm.AktifMi;
            lblAlarmAd.AutoSize = true;
            lblAlarmAd.Top = 10;
            lblAlarmAd.Left = 150;
            lblAlarmAd.Font = new Font(lblAlarmAd.Font.FontFamily, 22f);

            if (alarm.AlarmAdi == string.Empty)
            {
                lblAlarmAd.Text = "Adsız alarm";
            }
            else
            {
                lblAlarmAd.Text = alarm.AlarmAdi;
            }

            if (cb.Checked)
            {
                lblSaat.ForeColor = Color.Black;
                lblAlarmAd.ForeColor = Color.Black;
            }
            else
            {
                lblSaat.ForeColor = Color.FromArgb(224, 224, 224);
                lblAlarmAd.ForeColor = Color.FromArgb(224, 224, 224);
            }

            lblSaat.AutoSize = true;
            lblSaat.Top = 3;
            lblSaat.Text = alarm.AlarmZamani.Hours + ":" + alarm.AlarmZamani.Minutes;
            lblSaat.Font = new Font(lblSaat.Font.FontFamily, 32f);
            this.Controls.Add(lblSaat);

            pnlGunler.Left = 390;
            pnlGunler.Top = 13;
            pnlGunler.Size = new Size(270,30);
            GunleriListele();
        }

        private void GunleriListele()
        {
            for (int i = 0; i <= 6; i++)
            {
                lblGun = new Label();
                lblGun.Text = Enum.GetName(typeof(Gunler), i).ToString();
                lblGun.Left = 35 * (i);
                if (i == 6)
                    lblGun.Tag = i + 1;
                else
                    lblGun.Tag = 0;
                if(alarm.TekrarGunleri.Contains(i))
                {
                    lblGun.BackColor = Color.SkyBlue;
                } 
                else
                {
                    lblGun.BackColor = Color.White;
                }
                lblGun.Font = new Font(lblGun.Font, FontStyle.Bold);
                lblGun.Size = new Size(30, 30);
                lblGun.TextAlign = ContentAlignment.MiddleCenter;
                pnlGunler.Controls.Add(lblGun);
            }
        }
    }
}
