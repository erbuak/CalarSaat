
namespace CalarSaat.UI
{
    partial class FrmAlarmKur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtpDakika = new System.Windows.Forms.DateTimePicker();
            this.dtpSaat = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlarmAdi = new System.Windows.Forms.MaskedTextBox();
            this.lblAlarmAdi = new System.Windows.Forms.Label();
            this.pnlGunler = new System.Windows.Forms.Panel();
            this.txtYoutube = new System.Windows.Forms.TextBox();
            this.cbYoutube = new System.Windows.Forms.CheckBox();
            this.gbAlarmSecimi = new System.Windows.Forms.GroupBox();
            this.cbbAlarmlar = new System.Windows.Forms.ComboBox();
            this.gbTekrarSecimi = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.gbAlarmSecimi.SuspendLayout();
            this.gbTekrarSecimi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDakika
            // 
            this.dtpDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDakika.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDakika.Location = new System.Drawing.Point(404, 82);
            this.dtpDakika.Name = "dtpDakika";
            this.dtpDakika.Size = new System.Drawing.Size(99, 80);
            this.dtpDakika.TabIndex = 13;
            // 
            // dtpSaat
            // 
            this.dtpSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaat.Location = new System.Drawing.Point(278, 82);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.Size = new System.Drawing.Size(99, 80);
            this.dtpSaat.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(372, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 102);
            this.label1.TabIndex = 14;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAlarmAdi
            // 
            this.txtAlarmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlarmAdi.Location = new System.Drawing.Point(404, 192);
            this.txtAlarmAdi.Name = "txtAlarmAdi";
            this.txtAlarmAdi.Size = new System.Drawing.Size(99, 26);
            this.txtAlarmAdi.TabIndex = 22;
            // 
            // lblAlarmAdi
            // 
            this.lblAlarmAdi.AutoSize = true;
            this.lblAlarmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlarmAdi.Location = new System.Drawing.Point(274, 195);
            this.lblAlarmAdi.Name = "lblAlarmAdi";
            this.lblAlarmAdi.Size = new System.Drawing.Size(85, 20);
            this.lblAlarmAdi.TabIndex = 23;
            this.lblAlarmAdi.Text = "Alarm Adı: ";
            // 
            // pnlGunler
            // 
            this.pnlGunler.Location = new System.Drawing.Point(73, 32);
            this.pnlGunler.Name = "pnlGunler";
            this.pnlGunler.Size = new System.Drawing.Size(330, 50);
            this.pnlGunler.TabIndex = 24;
            // 
            // txtYoutube
            // 
            this.txtYoutube.Enabled = false;
            this.txtYoutube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoutube.Location = new System.Drawing.Point(106, 87);
            this.txtYoutube.Name = "txtYoutube";
            this.txtYoutube.Size = new System.Drawing.Size(363, 26);
            this.txtYoutube.TabIndex = 25;
            this.txtYoutube.Text = "https://www.youtube.com/watch?v=vx2u5uUu3DE";
            // 
            // cbYoutube
            // 
            this.cbYoutube.AutoSize = true;
            this.cbYoutube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbYoutube.Location = new System.Drawing.Point(11, 89);
            this.cbYoutube.Name = "cbYoutube";
            this.cbYoutube.Size = new System.Drawing.Size(89, 24);
            this.cbYoutube.TabIndex = 26;
            this.cbYoutube.Text = "Youtube";
            this.cbYoutube.UseVisualStyleBackColor = true;
            this.cbYoutube.CheckedChanged += new System.EventHandler(this.cbYoutube_CheckedChanged);
            // 
            // gbAlarmSecimi
            // 
            this.gbAlarmSecimi.Controls.Add(this.lblMesaj);
            this.gbAlarmSecimi.Controls.Add(this.cbbAlarmlar);
            this.gbAlarmSecimi.Controls.Add(this.cbYoutube);
            this.gbAlarmSecimi.Controls.Add(this.txtYoutube);
            this.gbAlarmSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbAlarmSecimi.Location = new System.Drawing.Point(167, 368);
            this.gbAlarmSecimi.Name = "gbAlarmSecimi";
            this.gbAlarmSecimi.Size = new System.Drawing.Size(481, 195);
            this.gbAlarmSecimi.TabIndex = 27;
            this.gbAlarmSecimi.TabStop = false;
            this.gbAlarmSecimi.Text = "Alarm Seçimi";
            // 
            // cbbAlarmlar
            // 
            this.cbbAlarmlar.FormattingEnabled = true;
            this.cbbAlarmlar.Location = new System.Drawing.Point(11, 26);
            this.cbbAlarmlar.Name = "cbbAlarmlar";
            this.cbbAlarmlar.Size = new System.Drawing.Size(458, 28);
            this.cbbAlarmlar.TabIndex = 27;
            // 
            // gbTekrarSecimi
            // 
            this.gbTekrarSecimi.Controls.Add(this.pnlGunler);
            this.gbTekrarSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbTekrarSecimi.Location = new System.Drawing.Point(167, 249);
            this.gbTekrarSecimi.Name = "gbTekrarSecimi";
            this.gbTekrarSecimi.Size = new System.Drawing.Size(481, 102);
            this.gbTekrarSecimi.TabIndex = 28;
            this.gbTekrarSecimi.TabStop = false;
            this.gbTekrarSecimi.Text = "Tekrar Seçimi";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(167, 576);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(481, 45);
            this.btnKaydet.TabIndex = 29;
            this.btnKaydet.Text = "Alarmı Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.Enabled = false;
            this.lblMesaj.Location = new System.Drawing.Point(7, 135);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(462, 41);
            this.lblMesaj.TabIndex = 28;
            this.lblMesaj.Text = "Mesaj";
            // 
            // lblSaat
            // 
            this.lblSaat.BackColor = System.Drawing.Color.White;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(275, 9);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(228, 44);
            this.lblSaat.TabIndex = 30;
            this.lblSaat.Text = "23:44:00";
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrZaman
            // 
            this.tmrZaman.Enabled = true;
            this.tmrZaman.Interval = 10;
            this.tmrZaman.Tick += new System.EventHandler(this.tmrZaman_Tick);
            // 
            // FrmAlarmKur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gbTekrarSecimi);
            this.Controls.Add(this.gbAlarmSecimi);
            this.Controls.Add(this.lblAlarmAdi);
            this.Controls.Add(this.txtAlarmAdi);
            this.Controls.Add(this.dtpDakika);
            this.Controls.Add(this.dtpSaat);
            this.Controls.Add(this.label1);
            this.Name = "FrmAlarmKur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Kur";
            this.gbAlarmSecimi.ResumeLayout(false);
            this.gbAlarmSecimi.PerformLayout();
            this.gbTekrarSecimi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDakika;
        private System.Windows.Forms.DateTimePicker dtpSaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtAlarmAdi;
        private System.Windows.Forms.Label lblAlarmAdi;
        private System.Windows.Forms.Panel pnlGunler;
        private System.Windows.Forms.TextBox txtYoutube;
        private System.Windows.Forms.CheckBox cbYoutube;
        private System.Windows.Forms.GroupBox gbAlarmSecimi;
        private System.Windows.Forms.GroupBox gbTekrarSecimi;
        private System.Windows.Forms.ComboBox cbbAlarmlar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer tmrZaman;
    }
}