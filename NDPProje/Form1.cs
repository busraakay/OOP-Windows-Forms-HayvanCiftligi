using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NDPProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saniye = 0; //Timer'da kullanılmak üzere tanımlanır.

        Keci keci = new Keci();//Nesne oluşturulur.
        Inek inek = new Inek();//Nesne oluşturulur.
        Ordek ordek = new Ordek();//Nesne oluşturulur.
        Tavuk tavuk = new Tavuk();//Nesne oluşturulur.

        Hayvan hayvan;//Çok biçimlilik kullanmak için yazılır.



        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;//Saniye artırılır.

            lblZaman.Text = Convert.ToString(saniye + " SN");//Zaman label'ına yazdırılır.


            pbTavuk.Increment(-2);//Progress Bar -2 olarak azaltılır.
            pbOrdek.Increment(-3);//Progress Bar -3 olarak azaltılır.
            pbInek.Increment(-8);//Progress Bar -8 olarak azaltılır.
            pbKeci.Increment(-6);//Progress Bar -6 olarak azaltılır.

            hayvan = tavuk;//Hayvan tavuğa dönüştürülür.
            lblTavukAdet.Text = (hayvan.YemUret() + " ADET").ToString();// Oluşan yumurta label'a eklenir.
            if (pbTavuk.Value == 0)//Progress Bar 0 olduğunda durum label'ında ÖLDÜ yazar ve Progress Bar değeri 0 olarak kalır.
            {
                lblTavukDurum.Text = hayvan.Durumu;
                hayvan.Durum();

            }
            if (pbTavuk.Value == 2)//Progress Bar 2 olduğunda ses çıkarır.
            {
                tavuk.SesVer();
            }

            hayvan = inek;//Hayvan ineğe dönüştürülür.
            lblInekAdet.Text = (inek.YemUret() + " KG").ToString();//Oluşan süt label'a eklenir.
            if (pbInek.Value == 4)//Progress Bar 4 olduğunda ses çıkarır.
            {
                hayvan.SesVer();
            }
            if (pbInek.Value == 0)//Progress Bar 0 olduğunda durum label'ında ÖLDÜ yazar ve Progress Bar değeri 0 olarak kalır.
            {
                lblInekDurum.Text = hayvan.Durumu;
                hayvan.Durum();
            }

            hayvan = keci;//Hayvan keçiye dönüştürülür.
            lblKeciAdet.Text = (hayvan.YemUret() + " KG").ToString();//Oluşan süt label'a eklenir.
            if (pbKeci.Value == 4)//Progress Bar 4 olduğunda ses çıkarır.
            {
                hayvan.SesVer();
            }
            if (pbKeci.Value == 0)//Progress Bar 0 olduğunda durum label'ında ÖLDÜ yazar ve Progress Bar değeri 0 olarak kalır.
            {
                lblKeciDurum.Text = hayvan.Durumu;
                hayvan.Durum();

            }

            hayvan = ordek;//Hayvan ördeğe dönüştürülür.
            lblOrdekAdet.Text = (ordek.YemUret() + " ADET").ToString();// Oluşan yumurta labela eklenir.
            if (pbOrdek.Value == 1)//Progress Bar 1 olduğunda ses çıkarır.
            {
                hayvan.SesVer();
            }
            if (pbOrdek.Value == 0)//Progress Bar 0 olduğunda durum label'ında ÖLDÜ yazar ve Progress Bar değeri 0 olarak kalır.
            {
                lblOrdekDurum.Text = hayvan.Durumu;
                hayvan.Durum();
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;//Timer'ın saniye cinsinden olması için kullanılır.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pbTavuk.Value > 0)//Progress Bar 0'dan büyük olduğunda value değerini 100 yapar ve durum label'ında CANLI yazar.
            {
                pbTavuk.Value = 100;
                lblTavukDurum.Text = "CANLI";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {


            if (pbInek.Value > 0)//Progress Bar 0'dan büyük olduğunda value değerini 100 yapar ve durum label'ında CANLI yazar.
            {
                pbInek.Value = 100;
                lblInekDurum.Text = "CANLI";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pbOrdek.Value > 0)//Progress Bar 0'dan büyük olduğunda value değerini 100 yapar ve durum label'ında CANLI yazar.
            {
                pbOrdek.Value = 100;
                lblOrdekDurum.Text = "CANLI";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pbKeci.Value > 0)//Progress Bar 0'dan büyük olduğunda value değerini 100 yapar ve durum label'ında CANLI yazar.
            {
                pbKeci.Value = 100;
                lblKeciDurum.Text = "CANLI";
            }


        }

        private void btnTavukSat_Click(object sender, EventArgs e)
        {
            hayvan = tavuk;//Hayvan tavuğa dönüştürülür.
            hayvan.YemSat();//Gereklli işlem yapılarak Kasaya aktarılır.
            lblKasa.Text = ((tavuk.Kasa + inek.Kasa + ordek.Kasa + keci.Kasa) + " TL").ToString();//Tüm kasalardaki paralar toplanıp kasa label'ına aktarılır. 
        }

        private void btnOrdekSat_Click(object sender, EventArgs e)
        {
            hayvan = ordek;//Hayvan ördeğe dönüştürülür.
            hayvan.YemSat();//Gereklli işlem yapılarak Kasaya aktarılır.
            lblKasa.Text = ((tavuk.Kasa + inek.Kasa + ordek.Kasa + keci.Kasa) + " TL").ToString();//Tüm kasalardaki paralar toplanıp kasa label'ına aktarılır. 
        }

        private void btnInekSat_Click(object sender, EventArgs e)
        {
            hayvan = inek;//Hayvan ineğe dönüştürülür.
            hayvan.YemSat();//Gereklli işlem yapılarak Kasaya aktarılır.
            lblKasa.Text = ((tavuk.Kasa + inek.Kasa + ordek.Kasa + keci.Kasa) + " TL").ToString();//Tüm kasalardaki paralar toplanıp kasa label'ına aktarılır. 
        }

        private void btnKeciSat_Click(object sender, EventArgs e)
        {
            hayvan = keci;//Hayvan keçiye dönüştürülür.
            hayvan.YemSat();//Gereklli işlem yapılarak Kasaya aktarılır.
            lblKasa.Text = ((tavuk.Kasa + inek.Kasa + ordek.Kasa + keci.Kasa) + " TL").ToString();//Tüm kasalardaki paralar toplanıp kasa label'ına aktarılır. 
        }

    }
}
