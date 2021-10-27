
namespace CalarSaat.UI
{
    partial class FrmAlarmGuncelle
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
            this.lblAlarmAdi = new System.Windows.Forms.Label();
            this.txtAlarmAdi = new System.Windows.Forms.MaskedTextBox();
            this.dtpDakika = new System.Windows.Forms.DateTimePicker();
            this.dtpSaat = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGunler = new System.Windows.Forms.Panel();
            this.cbYoutube = new System.Windows.Forms.CheckBox();
            this.txtYoutube = new System.Windows.Forms.TextBox();
            this.gbAlarmSecimi = new System.Windows.Forms.GroupBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.cbbAlarmlar = new System.Windows.Forms.ComboBox();
            this.lblSaat = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.gbTekrarSecimi = new System.Windows.Forms.GroupBox();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.btnSil = new System.Windows.Forms.Button();
            this.gbAlarmSecimi.SuspendLayout();
            this.gbTekrarSecimi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAlarmAdi
            // 
            this.lblAlarmAdi.AutoSize = true;
            this.lblAlarmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlarmAdi.Location = new System.Drawing.Point(267, 193);
            this.lblAlarmAdi.Name = "lblAlarmAdi";
            this.lblAlarmAdi.Size = new System.Drawing.Size(85, 20);
            this.lblAlarmAdi.TabIndex = 35;
            this.lblAlarmAdi.Text = "Alarm Adı: ";
            // 
            // txtAlarmAdi
            // 
            this.txtAlarmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlarmAdi.Location = new System.Drawing.Point(397, 190);
            this.txtAlarmAdi.Name = "txtAlarmAdi";
            this.txtAlarmAdi.Size = new System.Drawing.Size(99, 26);
            this.txtAlarmAdi.TabIndex = 34;
            // 
            // dtpDakika
            // 
            this.dtpDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDakika.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDakika.Location = new System.Drawing.Point(397, 75);
            this.dtpDakika.Name = "dtpDakika";
            this.dtpDakika.Size = new System.Drawing.Size(99, 80);
            this.dtpDakika.TabIndex = 32;
            // 
            // dtpSaat
            // 
            this.dtpSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaat.Location = new System.Drawing.Point(271, 75);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.Size = new System.Drawing.Size(99, 80);
            this.dtpSaat.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(365, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 102);
            this.label1.TabIndex = 33;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGunler
            // 
            this.pnlGunler.Location = new System.Drawing.Point(73, 32);
            this.pnlGunler.Name = "pnlGunler";
            this.pnlGunler.Size = new System.Drawing.Size(330, 50);
            this.pnlGunler.TabIndex = 24;
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
            this.cbYoutube.CheckedChanged += new System.EventHandler(this.CbYoutube_CheckedChanged);
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
            // gbAlarmSecimi
            // 
            this.gbAlarmSecimi.Controls.Add(this.lblMesaj);
            this.gbAlarmSecimi.Controls.Add(this.cbbAlarmlar);
            this.gbAlarmSecimi.Controls.Add(this.cbYoutube);
            this.gbAlarmSecimi.Controls.Add(this.txtYoutube);
            this.gbAlarmSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbAlarmSecimi.Location = new System.Drawing.Point(160, 361);
            this.gbAlarmSecimi.Name = "gbAlarmSecimi";
            this.gbAlarmSecimi.Size = new System.Drawing.Size(481, 188);
            this.gbAlarmSecimi.TabIndex = 36;
            this.gbAlarmSecimi.TabStop = false;
            this.gbAlarmSecimi.Text = "Alarm Seçimi";
            // 
            // lblMesaj
            // 
            this.lblMesaj.Enabled = false;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(7, 135);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(462, 42);
            this.lblMesaj.TabIndex = 28;
            this.lblMesaj.Text = "Mesaj";
            // 
            // cbbAlarmlar
            // 
            this.cbbAlarmlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAlarmlar.FormattingEnabled = true;
            this.cbbAlarmlar.Location = new System.Drawing.Point(11, 26);
            this.cbbAlarmlar.Name = "cbbAlarmlar";
            this.cbbAlarmlar.Size = new System.Drawing.Size(458, 28);
            this.cbbAlarmlar.TabIndex = 27;
            // 
            // lblSaat
            // 
            this.lblSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(271, 2);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(225, 52);
            this.lblSaat.TabIndex = 39;
            this.lblSaat.Text = "23:44:00";
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(160, 555);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(481, 45);
            this.btnGüncelle.TabIndex = 38;
            this.btnGüncelle.Text = "Alarmı Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // gbTekrarSecimi
            // 
            this.gbTekrarSecimi.Controls.Add(this.pnlGunler);
            this.gbTekrarSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbTekrarSecimi.Location = new System.Drawing.Point(160, 242);
            this.gbTekrarSecimi.Name = "gbTekrarSecimi";
            this.gbTekrarSecimi.Size = new System.Drawing.Size(481, 102);
            this.gbTekrarSecimi.TabIndex = 37;
            this.gbTekrarSecimi.TabStop = false;
            this.gbTekrarSecimi.Text = "Tekrar Seçimi";
            // 
            // tmrZaman
            // 
            this.tmrZaman.Enabled = true;
            this.tmrZaman.Interval = 10;
            this.tmrZaman.Tick += new System.EventHandler(this.TmrZaman_Tick);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(160, 612);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(481, 45);
            this.btnSil.TabIndex = 40;
            this.btnSil.Text = "Alarmı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // FrmAlarmGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 676);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblAlarmAdi);
            this.Controls.Add(this.txtAlarmAdi);
            this.Controls.Add(this.dtpDakika);
            this.Controls.Add(this.dtpSaat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbAlarmSecimi);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.gbTekrarSecimi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlarmGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alarm Güncelle";
            this.gbAlarmSecimi.ResumeLayout(false);
            this.gbAlarmSecimi.PerformLayout();
            this.gbTekrarSecimi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlarmAdi;
        private System.Windows.Forms.MaskedTextBox txtAlarmAdi;
        private System.Windows.Forms.DateTimePicker dtpDakika;
        private System.Windows.Forms.DateTimePicker dtpSaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlGunler;
        private System.Windows.Forms.CheckBox cbYoutube;
        private System.Windows.Forms.TextBox txtYoutube;
        private System.Windows.Forms.GroupBox gbAlarmSecimi;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.ComboBox cbbAlarmlar;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.GroupBox gbTekrarSecimi;
        private System.Windows.Forms.Timer tmrZaman;
        private System.Windows.Forms.Button btnSil;
    }
}