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
        CheckBox cb;
        Label saat = new Label();
        public AlarmKart(int x, int y)
        {
            this.BackColor = Color.White;
            this.Size = new Size(x, y);
            cb = new CheckBox();
            cb.Location = new Point(x-30, 0);
            this.Controls.Add(cb);
            cb.Click += Cb_Click;
            IcerigiHazirla();
        }

        private void Cb_Click(object sender, EventArgs e)
        {
            if(cb.Checked)
            {
                saat.ForeColor = Color.Black;
            } else
            {
                saat.ForeColor = Color.FromArgb(224,224,224);
            }
        }

        private void IcerigiHazirla()
        {
            if (cb.Checked)
            {
                saat.ForeColor = Color.Black;
            }
            else
            {
                saat.ForeColor = Color.FromArgb(224, 224, 224);
            }
            saat.AutoSize = true;
            saat.Text = "07:00";
            saat.Font = new Font(saat.Font.FontFamily, 32f);
            this.Controls.Add(saat);
        }
    }
}
