
namespace CalarSaat.UI
{
    partial class FrmAlarm
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
            this.btnErtele = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblAlarmAd = new System.Windows.Forms.Label();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnErtele
            // 
            this.btnErtele.Location = new System.Drawing.Point(12, 197);
            this.btnErtele.Name = "btnErtele";
            this.btnErtele.Size = new System.Drawing.Size(172, 43);
            this.btnErtele.TabIndex = 1;
            this.btnErtele.Text = "Ertele";
            this.btnErtele.UseVisualStyleBackColor = true;
            this.btnErtele.Click += new System.EventHandler(this.btnErtele_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(195, 197);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(172, 43);
            this.btnDurdur.TabIndex = 2;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblSaat
            // 
            this.lblSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(76, 9);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(225, 52);
            this.lblSaat.TabIndex = 31;
            this.lblSaat.Text = "23:44:00";
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlarmAd
            // 
            this.lblAlarmAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlarmAd.Location = new System.Drawing.Point(12, 95);
            this.lblAlarmAd.Name = "lblAlarmAd";
            this.lblAlarmAd.Size = new System.Drawing.Size(355, 23);
            this.lblAlarmAd.TabIndex = 32;
            this.lblAlarmAd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrZaman
            // 
            this.tmrZaman.Enabled = true;
            this.tmrZaman.Interval = 10;
            this.tmrZaman.Tick += new System.EventHandler(this.tmrZaman_Tick);
            // 
            // FrmAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 262);
            this.Controls.Add(this.lblAlarmAd);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnErtele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAlarm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnErtele;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblAlarmAd;
        private System.Windows.Forms.Timer tmrZaman;
    }
}