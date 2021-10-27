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
        FrmAnaSayfa frmAnaSayfa;
        int x;
        string saat,dakika;

        public AlarmKart(int x, int y, Alarm alarm, FrmAnaSayfa frmAnaSayfa)
        {
            this.alarm = alarm;
            this.x = x;
            this.frmAnaSayfa = frmAnaSayfa;
            this.BackColor = Color.White;
            this.Size = new Size(x, y);
            this.Controls.Add(cb);
            this.Controls.Add(lblAlarmAd);
            this.Controls.Add(pnlGunler);
            this.DoubleClick += AlarmKart_DoubleClick;
            IcerigiHazirla();
        }

        private void AlarmKart_DoubleClick(object sender, EventArgs e)
        {
            FrmAlarmGuncelle frmAlarmGuncelle = new FrmAlarmGuncelle(alarm, frmAnaSayfa);
            frmAlarmGuncelle.ShowDialog();
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
            lblAlarmAd.Top = 15;
            lblAlarmAd.Left = 150;
            lblAlarmAd.Font = new Font(lblAlarmAd.Font.FontFamily, 18f);

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

            if (alarm.AlarmZamani.Hours < 10)
            {
                saat = "0" + alarm.AlarmZamani.Hours;
            }
            else
            {
                saat = alarm.AlarmZamani.Hours.ToString();
            }

            if (alarm.AlarmZamani.Minutes < 10)
            {
                dakika = "0" + alarm.AlarmZamani.Minutes;
            }
            else
            {
                dakika = alarm.AlarmZamani.Minutes.ToString();
            }

            lblSaat.Text = saat + ":" + dakika;
            lblSaat.Font = new Font(lblSaat.Font.FontFamily, 32f);
            this.Controls.Add(lblSaat);

            pnlGunler.Left = 450;
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
                {
                    if (alarm.TekrarGunleri.Contains(0))
                    {
                        lblGun.BackColor = Color.SkyBlue;
                    }
                } 
                else
                {
                    if (alarm.TekrarGunleri.Contains(i+1))
                    {
                        lblGun.BackColor = Color.SkyBlue;
                    }
                }
                lblGun.Font = new Font(lblGun.Font, FontStyle.Bold);
                lblGun.Size = new Size(30, 30);
                lblGun.TextAlign = ContentAlignment.MiddleCenter;
                pnlGunler.Controls.Add(lblGun);
            }
        }
    }
}
