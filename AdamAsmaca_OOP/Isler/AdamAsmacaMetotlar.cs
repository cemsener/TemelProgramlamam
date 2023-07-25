using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca_OOP.Isler
{
    public class AdamAsmacaMetotlar
    {

        public static string[] Sehirler { get; } = SehirleriYukle();

        private static string secilenSehir;
        public static string SecilenSehir
        {
            get { return secilenSehir; }
            private set { secilenSehir = value.ToUpper(); }
        }

        public static string EkranMetni { get; private set; }

        public static string[] SehirleriYukle()
        {
            return new string [] { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };
        }

        public static void RastgeleSehirSec()
        {
            Random rnd = new Random();
            SecilenSehir = Sehirler[rnd.Next(0, 81)];
            EkranMetni = Sifrele(secilenSehir);
        }
        public static string Sifrele(string metin)
        {
            string sifreliMetin = "";
            for (int i = 0; i < metin.Length; i++)
            {
                sifreliMetin += "_ ";
            }
            return sifreliMetin;
        }

        public static string ArayaBoslukEkle(string metin)
        {
            string boslukluMetin = "";
            for (int i = 0; i < metin.Length; i++)
            {
                boslukluMetin += metin[i] + " ";
            }
            return boslukluMetin;
        }

        public static Button[] GetirHarfButonlari()
        {
            char[] charharfler = new char[] { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };

            Button[] btnHarfler = new Button[charharfler.Length];

            int xkoord = 10, ykoord = 90;

            for (int i = 0; i < charharfler.Length; i++)
            {
                
                btnHarfler[i] = new Button();
                btnHarfler[i].Text = charharfler[i].ToString();
                btnHarfler[i].Size = new Size(35, 35); //piksel cinsinden değerler
                btnHarfler[i].Location = new Point(xkoord, ykoord);
                xkoord += btnHarfler[i].Width+5;
                if ((i+1)%10 == 0)
                {
                    ykoord += btnHarfler[i].Width + 5;
                    xkoord = 10;
                }
                btnHarfler[i].Click += HarfeBasildiginda;
            }

            return btnHarfler;
        }

        private static void HarfeBasildiginda(object sender, EventArgs e)
        {
            var buton = ((Button)sender);
            char basilanHarf = buton.Text[0];
            if(secilenSehir.Contains(basilanHarf.ToString()))
            {
                var dizi = secilenSehir.ToCharArray();
                var diziEkran = EkranMetni.ToCharArray();
                for (int i = 0; i < dizi.Length; i++)
                {
                    if (dizi[0] == basilanHarf)
                    {
                        diziEkran[i] = basilanHarf;
                    }
                }

                EkranMetni = new string (diziEkran);
            }      
        }
    }
}
