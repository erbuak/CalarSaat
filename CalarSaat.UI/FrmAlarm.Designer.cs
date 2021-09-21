
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
            this.btnErtele = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnErtele
            // 
            this.btnErtele.Location = new System.Drawing.Point(12, 508);
            this.btnErtele.Name = "btnErtele";
            this.btnErtele.Size = new System.Drawing.Size(370, 43);
            this.btnErtele.TabIndex = 1;
            this.btnErtele.Text = "Ertele";
            this.btnErtele.UseVisualStyleBackColor = true;
            this.btnErtele.Click += new System.EventHandler(this.btnErtele_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(495, 508);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(370, 43);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // FrmAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 563);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnErtele);
            this.Name = "FrmAlarm";
            this.Text = "Alarm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAlarm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnErtele;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label1;
    }
}