using SinemaBiletOtomasyon.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletOtomasyon.Model
{
    public abstract class Kullanici
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public KullacisiRol Rol { get; set; }
    }
}
