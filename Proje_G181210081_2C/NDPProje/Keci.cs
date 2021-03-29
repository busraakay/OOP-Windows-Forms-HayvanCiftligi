using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NDPProje
{
    class Keci : Hayvan //Hayvan sınıfından kalıtım aldırılır.
    {
        SoundPlayer ses = new SoundPlayer();//Ses için oluşturulur.

        private int keciSutu;   //Süt litresi için.
        string keciSes = Application.StartupPath + "\\sesler\\keci.wav";//Ses dosyasının seçmek için.



        public override int YemSat()// Yemi gerekli işlem yaparak kasaya aktarır.
        {
            Kasa += keciSutu * 8;
            return keciSutu = 0;
        }

        public override int YemUret()// Gerekli işlem yapılarak saniyeye göre süt artırılır.
        {
            Saniye++;
            if(Saniye%7==0)
            {
                keciSutu++;
            }
            return keciSutu;
        }

        public override void SesVer()//Sesin konumu belli edilerek ses çaldırılır.
        {
            ses.SoundLocation = keciSes;
            ses.Play();
        }

    }
}
