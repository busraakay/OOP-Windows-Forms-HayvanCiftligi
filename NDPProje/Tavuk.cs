using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NDPProje
{
    class Tavuk : Hayvan  //Hayvan sınıfından kalıtım aldırılır.
    {
        SoundPlayer ses = new SoundPlayer();    //Ses için oluşturulur.

        private int tavukYumurtası = 0;        //Yumurta adeti için.
        private string tavukSes = Application.StartupPath + "\\sesler\\tavuk.wav"; //Ses dosyasının seçmek için.


        public override int YemSat()// Yemi gerekli işlem yaparak kasaya aktarır.
        {
            Kasa += tavukYumurtası * 1;
            return tavukYumurtası = 0;
        }

        
        
        public override int YemUret()// Gerekli işlem yapılarak saniyeye göre yumurta artırılır.
        {
            Saniye++;
            if (Saniye % 3 == 0)
            {
                tavukYumurtası++;
            }

            return tavukYumurtası;

        }
        public override void SesVer()//Sesin konumu belli edilerek ses çaldırılır.
        {
            ses.SoundLocation = tavukSes;
            ses.Play();
        }


    }
}
