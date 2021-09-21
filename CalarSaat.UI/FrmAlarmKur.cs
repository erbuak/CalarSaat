using CalarSaat.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalarSaat.UI
{
    public partial class FrmAlarmKur : Form
    {
        Label lblGun;
        Alarm alarm;
        
        public FrmAlarmKur()
        {
            InitializeComponent();
            dtpSaat.CustomFormat = "HH";
            dtpSaat.ShowUpDown = true;
            dtpDakika.CustomFormat = "mm";
            dtpDakika.ShowUpDown = true;
            GunleriOlustur();

            if (cbYoutube.Checked == true)
            {
                cbbAlarmlar.Enabled = false;
                txtYoutube.Enabled = true;
            }

            lblMesaj.Text = "Not: İnternet bağlantınız kesilir veya YouTube'a herhangi bir sebeple ulaşılamazsa, alarmınız otomatik olarak 'Ring Tone' melodisi olacaktır.";
        }

        private void GunleriOlustur()
        {
            lblGun = new Label();
            lblGun.Text = Enum.GetName(typeof(Gunler), 1).ToString();
            lblGun.BackColor = Color.White;
            Font = new Font(lblGun.Font, FontStyle.Bold);
            lblGun.Size = new Size(50, 50);
            lblGun.Left = 55 * 0;
            lblGun.BorderStyle = BorderStyle.FixedSingle;
            lblGun.TextAlign = ContentAlignment.MiddleCenter;
            pnlGunler.Controls.Add(lblGun);
            lblGun.Click += Gun_Click;

            for (int i = 2; i <= 6; i++)
            {
                lblGun = new Label();
                lblGun.Text = Enum.GetName(typeof(Gunler), i).ToString();
                lblGun.BackColor = Color.White;
                Font = new Font(lblGun.Font, FontStyle.Bold);
                lblGun.Size = new Size(50, 50);
                lblGun.Left = 55 * (i-1);
                lblGun.BorderStyle = BorderStyle.FixedSingle;
                lblGun.TextAlign = ContentAlignment.MiddleCenter;          
                pnlGunler.Controls.Add(lblGun);
                lblGun.Click += Gun_Click;
            }

            lblGun = new Label();
            lblGun.Text = Enum.GetName(typeof(Gunler), 0).ToString();
            lblGun.BackColor = Color.White;
            Font = new Font(lblGun.Font, FontStyle.Bold);
            lblGun.Size = new Size(50, 50);
            lblGun.Left = 55 * 6;
            lblGun.BorderStyle = BorderStyle.FixedSingle;
            lblGun.TextAlign = ContentAlignment.MiddleCenter;
            pnlGunler.Controls.Add(lblGun);
            lblGun.Click += Gun_Click;
        }

        private void Gun_Click(object sender, EventArgs e)
        {
            lblGun = (Label)sender;
            if (lblGun.BackColor == Color.SkyBlue)
            {
                lblGun.BackColor = Color.White;
                lblGun.ForeColor = Color.Black;
            }
            else
            {
                lblGun.BackColor = Color.SkyBlue;
                lblGun.ForeColor = Color.DarkBlue;
            }
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
                    alarm.AlarmYoutubeMu = true;
                }       
            } 
            else
            {
                alarm = new Alarm("");
                alarm.AlarmYoutubeMu = false;
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
