using AdamAsmaca_OOP.Isler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca_OOP
{
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
            AdamAsmacaMetotlar.RastgeleSehirSec();
            var butonlar = AdamAsmacaMetotlar.GetirHarfButonlari();
            this.Controls.AddRange(butonlar);

            lblSecilenSehir.Text = AdamAsmacaMetotlar.EkranMetni;
        }

        

        

    }
}
