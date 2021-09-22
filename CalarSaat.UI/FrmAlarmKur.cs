using CalarSaat.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CalarSaat.UI
{
    public partial class FrmAlarmKur : Form
    {
        Label lblGun;
        Alarm alarm;
        List<int> gunler = new List<int>(); 
        
        public FrmAlarmKur()
        {
            InitializeComponent();
            dtpSaat.CustomFormat = "HH";
            dtpSaat.ShowUpDown = true;
            dtpDakika.CustomFormat = "mm";
            dtpDakika.ShowUpDown = true;
            GunleriListele();
            HazırAlarmlariListele();
            if (cbYoutube.Checked == true)
            {
                cbbAlarmlar.Enabled = false;
                txtYoutube.Enabled = true;
            }

            lblMesaj.Text = "Not: İnternet bağlantınız kesilir veya YouTube'a herhangi bir sebeple ulaşılamazsa, alarmınız otomatik olarak 'Alarm Dediğin Böyle Olur' melodisi olacaktır. İnternet bağlantı hızınıza bağlı olarak videonun açılması 30 saniyeye kadar uzayabilir.";
        }

        private void GunleriListele()
        {
            for (int i = 0; i <= 6; i++)
            {
                lblGun = new Label();
                lblGun.Text = Enum.GetName(typeof(Gunler), i).ToString();
                lblGun.Left = 55 * (i);
                if(i==6)
                    lblGun.Tag = i + 1;
                else
                    lblGun.Tag = 0;
                lblGun.BackColor = Color.White;
                Font = new Font(lblGun.Font, FontStyle.Bold);
                lblGun.Size = new Size(50, 50);     
                lblGun.BorderStyle = BorderStyle.FixedSingle;
                lblGun.TextAlign = ContentAlignment.MiddleCenter;  
                pnlGunler.Controls.Add(lblGun);
                lblGun.Click += Gun_Click;
            }
        }

        private void HazırAlarmlariListele()
        {
            cbbAlarmlar.DataSource = new BindingSource(DbContext.AlarmSesleri, null);
            cbbAlarmlar.DisplayMember = "Key";
            cbbAlarmlar.ValueMember = "Value";
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

        private void cbYoutube_CheckedChanged(object sender, EventArgs e)
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {      
            if (cbYoutube.Checked)
            {
                var youtubeLinkMatch = new Regex(@"http(?:s?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match(txtYoutube.Text);
                if(!youtubeLinkMatch.Success)
                {
                    MessageBox.Show("Geçerli bir youtube linki girin!");
                    return;
                } else
                {
                    alarm = new Alarm(txtYoutube.Text);
                    alarm.AktifMi = true;
                    alarm.TekrarlıMı = gunler.Count > 0 ?  true : false;
                    alarm.AlarmAdi = txtAlarmAdi.Text;
                    alarm.TekrarGunleri = gunler;
                    alarm.AlarmYoutubeMu = true;
                }       
            } 
            else
            {
                alarm = new Alarm();
                alarm.AktifMi = true;
                alarm.TekrarlıMı = gunler.Count > 0 ? true : false;
                alarm.AlarmAdi = txtAlarmAdi.Text;
                alarm.TekrarGunleri = gunler;
                alarm.AlarmYoutubeMu = false;
                KeyValuePair<string, string> selectedEntry = (KeyValuePair<string, string>)cbbAlarmlar.SelectedItem;
                alarm.AlarmSesAdi = selectedEntry.Key;
                alarm.AlarmSesYolu = selectedEntry.Value;
            }
            alarm.AlarmZamani = new TimeSpan(Convert.ToInt32(dtpSaat.Value.Hour), Convert.ToInt32(dtpDakika.Value.Minute), 0);
            DbContext.Alarmlar.Add(alarm);
            this.Close();
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
