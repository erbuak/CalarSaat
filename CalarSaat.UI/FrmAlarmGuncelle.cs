using CalarSaat.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CalarSaat.UI
{
    public partial class FrmAlarmGuncelle : Form
    {
        private event EventHandler UpdatedAlarm;
        FrmAnaSayfa frmAnaSayfa;
        Label lblGun;
        List<int> gunler = new List<int>();
        Alarm alarm;

        public FrmAlarmGuncelle(Alarm alarm, FrmAnaSayfa frmAnaSayfa)
        {
            InitializeComponent();
            this.alarm = alarm;
            this.frmAnaSayfa = frmAnaSayfa;

            dtpSaat.CustomFormat = "HH";
            dtpSaat.ShowUpDown = true;
            dtpDakika.CustomFormat = "mm";
            dtpDakika.ShowUpDown = true;

            HazırAlarmlariListele();
            GunleriListele();

            if (alarm.AlarmYoutubeMu)
            {
                cbYoutube.Checked = true;
                cbbAlarmlar.Enabled = false;
                txtYoutube.Enabled = true;
                lblMesaj.Enabled = true;
            }

            UpdatedAlarm += frmAnaSayfa.EventGuncelle;

            dtpSaat.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, alarm.AlarmZamani.Hours, alarm.AlarmZamani.Minutes, 0);
            dtpDakika.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, alarm.AlarmZamani.Hours, alarm.AlarmZamani.Minutes, 0);
            txtAlarmAdi.Text = alarm.AlarmAdi;

            lblMesaj.Text = "Not: İnternet bağlantınız kesilir veya YouTube'a herhangi bir sebeple ulaşılamazsa, alarmınız otomatik olarak 'Alarm Dediğin Böyle Olur' melodisi olacaktır. İnternet bağlantı hızınıza bağlı olarak videonun açılması 30 saniyeye kadar uzayabilir.";
        }

        private void GunleriListele()
        {
            for (int i = 0; i <= 6; i++)
            {
                lblGun = new Label();
                lblGun.Text = Enum.GetName(typeof(Gunler), i).ToString();
                lblGun.Left = 55 * (i);
                if (i == 6)
                    lblGun.Tag = 0;
                else
                    lblGun.Tag = i + 1;
                lblGun.BackColor = Color.White;
                Font = new Font(lblGun.Font, FontStyle.Bold);
                lblGun.Size = new Size(50, 50);
                lblGun.BorderStyle = BorderStyle.FixedSingle;
                lblGun.TextAlign = ContentAlignment.MiddleCenter;
                pnlGunler.Controls.Add(lblGun);
                lblGun.Click += Gun_Click;

                foreach (int tekrarGunu in alarm.TekrarGunleri)
                {
                    if((int)lblGun.Tag == tekrarGunu)
                    {
                        lblGun.BackColor = Color.SkyBlue;
                        lblGun.ForeColor = Color.DarkBlue;
                        gunler.Add((int)lblGun.Tag);
                    }
                }
            }
        }

        private void HazırAlarmlariListele()
        {
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("Alarm Dediğin Böyle Olur", AppDomain.CurrentDomain.BaseDirectory + @"Resources\alarm_dedigin_boyle_olur.wav");
            test.Add("Gemi Batıyor", AppDomain.CurrentDomain.BaseDirectory + @"Resources\gemi_batiyor.wav");

            cbbAlarmlar.DataSource = new BindingSource(test, null);
            cbbAlarmlar.DisplayMember = "Key";
            cbbAlarmlar.ValueMember = "Value";

            cbbAlarmlar.SelectedItem = alarm.AlarmSes;
        }

        private void Gun_Click(object sender, EventArgs e)
        {
            lblGun = (Label)sender;
            if (lblGun.BackColor == Color.SkyBlue)
            {
                lblGun.BackColor = Color.White;
                lblGun.ForeColor = Color.Black;
                gunler.Remove((int)lblGun.Tag);
            }
            else
            {
                lblGun.BackColor = Color.SkyBlue;
                lblGun.ForeColor = Color.DarkBlue;
                gunler.Add((int)lblGun.Tag);
            }
            string gun = lblGun.Text;
        }

        private void TmrZaman_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void CbYoutube_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYoutube.Checked == true)
            {
                cbbAlarmlar.Enabled = false;
                txtYoutube.Enabled = true;
                lblMesaj.Enabled = true;
            }
            else
            {
                cbbAlarmlar.Enabled = true;
                txtYoutube.Enabled = false;
                lblMesaj.Enabled = false;
            }
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (cbYoutube.Checked)
            {
                var youtubeLinkMatch = new Regex(@"http(?:s?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match(txtYoutube.Text);
                if (!youtubeLinkMatch.Success)
                {
                    MessageBox.Show("Geçerli bir youtube linki girin!");
                    return;
                }
                else
                {
                    alarm.AktifMi = true;
                    alarm.TekrarlıMı = gunler.Count > 0 ? true : false;
                    alarm.AlarmAdi = txtAlarmAdi.Text;
                    alarm.TekrarGunleri = gunler;
                    alarm.AlarmYoutubeMu = true;
                }
            }
            else
            {
                alarm.AktifMi = true;
                alarm.TekrarlıMı = gunler.Count > 0 ? true : false;
                alarm.AlarmAdi = txtAlarmAdi.Text;
                alarm.TekrarGunleri = gunler;
                alarm.AlarmYoutubeMu = false;
                alarm.AlarmSes = (KeyValuePair<string, string>)cbbAlarmlar.SelectedItem;
            }
            alarm.AlarmZamani = new TimeSpan(Convert.ToInt32(dtpSaat.Value.Hour), Convert.ToInt32(dtpDakika.Value.Minute), 0);

            UpdatedAlarm?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DbContext.Alarmlar.Remove(alarm);
            UpdatedAlarm?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
