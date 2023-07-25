using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletOtomasyon.Model
{
    public class Personel:Kullanici
    {
        public Personel()
        {
            Rol = Enum.KullacisiRol.Personel;
        }
    }
}
