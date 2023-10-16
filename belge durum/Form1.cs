using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belge_durum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDurumGoster_Click(object sender, EventArgs e)
        {
            double notOrtalama, devamsizliksayi;
            int ZayifSayi;

            
            notOrtalama = Convert .ToDouble(txtOrtalama.Text);
            devamsizliksayi = Convert.ToDouble(txtDevamsızlık.Text);
            ZayifSayi = Convert.ToInt32(txtZayif.Text);
            if(notOrtalama >= 70 && notOrtalama <85&& devamsizliksayi <5&& ZayifSayi == 0)
            {
                lblDurum.Text = "TEŞŞEKÜR BELGESİ ALACAKSINIZ...";
            }
            else if ( notOrtalama >= 85 && notOrtalama <=100 &&devamsizliksayi <5&& ZayifSayi == 0)
            {
                lblDurum.Text = "TAKDİR BELGESİ ALACAKSINIZ...";
            }else if(devamsizliksayi < 5)
            {
                lblDurum.Text = "DEVAMSIZLIGIN FAZLA...";
            }
            else if (ZayifSayi != 0)
            {
                lblDurum.Text = "ZAYIF VAR";
            }
            else
            {
                lblDurum.Text = "ÜZGÜNÜM BELGE YOK...";
            }

            

        }
    }
}
