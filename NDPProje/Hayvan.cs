using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProje
{
    abstract class Hayvan
    {
        public abstract int YemUret();//Kalıtım alan sınıflarda zorunlu olması için abstarct kullanılarak metot yazılır.
        public abstract int YemSat();//Kalıtım alan sınıflarda zorunlu olması için abstarct kullanılarak metot yazılır.
        public abstract void SesVer();//Kalıtım alan sınıflarda zorunlu olması için abstarct kullanılarak metot yazılır.


        private int kasa;//Diğer sınıflarda kullanılmak üzere Property olarak yazılır.
        public int Kasa
        {
            get
            {
                return kasa;
            }
            set
            {
                kasa = value;
            }
        }

        private int saniye;//Diğer sınıflarda kullanılmak üzere Property olarak yazılır.
        protected int Saniye
        {
            get
            {
                return saniye;
            }
            set
            {
                saniye = value;
            }
        }

        private string durumu;//Diğer sınıflarda kullanılmak üzere Property olarak yazılır.
        public  string Durumu
        {
            get
            {
                return durumu;
            }
            set
            {
                durumu = value;
            }
        }


        public void Durum()//Hayvanın öldüğünü belirtmek ve YEMVER butonun kullanılmaması için yazılır.
        {
            Saniye = 0;
            durumu = "ÖLDÜ";

        }

    }
}
