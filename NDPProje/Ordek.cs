using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NDPProje
{
    class Ordek : Hayvan  //Hayvan sınıfından kalıtım aldırılır.
    {
        SoundPlayer ses = new SoundPlayer();//Ses için oluşturulur.

        private int ordekYumurtası;  //Yumurta adeti için.
        string ordekSes = Application.StartupPath + "\\sesler\\ordek.wav";//Ses dosyasının seçmek için.

        public override int YemSat()// Yemi gerekli işlem yaparak kasaya aktarır.
        {
          
             Kasa += ordekYumurtası * 3;
            return ordekYumurtası = 0;
        }

        public override int YemUret()// Gerekli işlem yapılarak saniyeye göre yumurta artırılır.
        {
            Saniye++;
            if(Saniye%5==0)
            {
                ordekYumurtası++;
            }
            return ordekYumurtası;
        }

        public override void SesVer()//Sesin konumu belli edilerek ses çaldırılır.
        {
            ses.SoundLocation = ordekSes;
            ses.Play();
        }

    }
}
