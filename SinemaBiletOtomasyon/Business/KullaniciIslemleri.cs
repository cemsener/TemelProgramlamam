using SinemaBiletOtomasyon.Exceptions;
using SinemaBiletOtomasyon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletOtomasyon.Business
{
    public class KullaniciIslemleri
    {
        public Kullanici Login (string kullaniciAdi, string sifre)
        {
            var arananKullanici = Database.Instance.Kullanicilar.Find(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == sifre);
            if (arananKullanici == null)
                throw new KullaniciBulunamadiException();
            return arananKullanici;
        }
    }
}
