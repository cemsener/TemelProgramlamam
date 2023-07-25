using SinemaBiletOtomasyon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletOtomasyon
{
    public class Database
    {
        private static Database instance;

        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }

        public List<Musteri> Musteriler { get; private set; }
        public List<Personel> Personeller { get; private set; }

        public List<Kullanici> MyProperty
        {
            get
            {
                var list = new List<Kullanici>();
                list.AddRange(Musteriler);
                list.AddRange(Personeller);
                return list;
            }

        }

        public Database()
        {
            IlkMusterileriDoldur();
            IlkPersonelleriYukle();
        }

        private void IlkPersonelleriYukle()
        {
            if (Personeller is null)
            {
                Personeller = new List<Personel>();

                #region 1.Personel
                {
                    var yeniPersonel = new Personel();
                    yeniPersonel.KullaniciAdi = "cemsener";
                    yeniPersonel.Sifre = "1234";
                    Personeller.Add(yeniPersonel);
                }
                #endregion

                #region 2.Personel
                {
                    var yeniPersonel = new Personel();
                    yeniPersonel.KullaniciAdi = "cemresener";
                    yeniPersonel.Sifre = "1234";
                    Personeller.Add(yeniPersonel);
                }
                #endregion

            }
        }

        public void IlkMusterileriDoldur()
        {
            if (Musteriler is null)
            {
                Musteriler = new List<Musteri>();

                #region 1.Musteri
                {
                    var yeniMusteri = new Musteri();
                    yeniMusteri.KullaniciAdi = "cemsener";
                    yeniMusteri.Sifre = "1234";
                    Musteriler.Add(yeniMusteri);
                }
                #endregion

                #region 2.Musteri
                {
                    var yeniMusteri = new Musteri();
                    yeniMusteri.KullaniciAdi = "cemresener";
                    yeniMusteri.Sifre = "1234";
                    Musteriler.Add(yeniMusteri);
                }
                #endregion


            }
        }

    }
}
