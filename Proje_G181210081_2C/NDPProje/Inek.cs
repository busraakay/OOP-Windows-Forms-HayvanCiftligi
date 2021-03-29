using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NDPProje
{
    class Inek : Hayvan  //Hayvan sınıfından kalıtım aldırılır.
    {
        SoundPlayer ses = new SoundPlayer();//Ses için oluşturulur.

        private int inekSutu;  //Süt litresi için.
        string inekSes = Application.StartupPath + "\\sesler\\inek.wav";//Ses dosyasının seçmek için.

        public override int YemSat()// Yemi gerekli işlem yaparak kasaya aktarır.
        {
            Kasa += inekSutu * 5;
            return inekSutu = 0;
            
        }

        public override int YemUret()// Gerekli işlem yapılarak saniyeye göre süt artırılır.
        {
            Saniye++;
            if(Saniye%8==0)
            {
                inekSutu++;
            }

            return inekSutu;
        }

        public override void SesVer()//Sesin konumu belli edilerek ses çaldırılır.
        {
            ses.SoundLocation = inekSes;
            ses.Play();
        }



    }
}
