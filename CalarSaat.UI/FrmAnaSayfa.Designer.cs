﻿
namespace CalarSaat.UI
{
    partial class FrmAnaSayfa
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
            this.pnlAlarmKartlari = new System.Windows.Forms.Panel();
            this.btnAlarmEkle = new System.Windows.Forms.Button();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblAlarmDurumu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlAlarmKartlari
            // 
            this.pnlAlarmKartlari.Location = new System.Drawing.Point(12, 242);
            this.pnlAlarmKartlari.Name = "pnlAlarmKartlari";
            this.pnlAlarmKartlari.Size = new System.Drawing.Size(776, 254);
            this.pnlAlarmKartlari.TabIndex = 1;
            // 
            // btnAlarmEkle
            // 
            this.btnAlarmEkle.Location = new System.Drawing.Point(623, 200);
            this.btnAlarmEkle.Name = "btnAlarmEkle";
            this.btnAlarmEkle.Size = new System.Drawing.Size(165, 36);
            this.btnAlarmEkle.TabIndex = 2;
            this.btnAlarmEkle.Text = "Alarm Ekle";
            this.btnAlarmEkle.UseVisualStyleBackColor = true;
            this.btnAlarmEkle.Click += new System.EventHandler(this.btnAlarmEkle_Click);
            // 
            // tmrZaman
            // 
            this.tmrZaman.Enabled = true;
            this.tmrZaman.Interval = 10;
            this.tmrZaman.Tick += new System.EventHandler(this.tmrZaman_Tick);
            // 
            // lblSaat
            // 
            this.lblSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(285, 9);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(225, 52);
            this.lblSaat.TabIndex = 31;
            this.lblSaat.Text = "23:44:00";
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlarmDurumu
            // 
            this.lblAlarmDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlarmDurumu.Location = new System.Drawing.Point(12, 101);
            this.lblAlarmDurumu.Name = "lblAlarmDurumu";
            this.lblAlarmDurumu.Size = new System.Drawing.Size(776, 23);
            this.lblAlarmDurumu.TabIndex = 32;
            this.lblAlarmDurumu.Text = "AlarmDurumu";
            this.lblAlarmDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.lblAlarmDurumu);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.btnAlarmEkle);
            this.Controls.Add(this.pnlAlarmKartlari);
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarmlarım";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAlarmKartlari;
        private System.Windows.Forms.Button btnAlarmEkle;
        private System.Windows.Forms.Timer tmrZaman;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblAlarmDurumu;
    }
}

