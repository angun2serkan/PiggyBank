using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marathon2.siniflar
{
    class UyariKutuphanesi
    {
        public static string KumbaraKirik()
        {
            return "Kumbara kırık yapıştırmadan para atılamaz";
        }
        public static string KumbaraDoldu()
        {
            return "Kumbarada yer yok!";
        }
        
        public static string KumbaraKirildi()
        {
            return "Kumbara kırıldı!";
        }
        public static string KumbaraYapistirildi()
        {
            return "Kumbara yapıştırıldı";
        }
        public static string YapistirmaUyarisi()
        {
            return "Kumbara 1 kere yapıştırıldı, 2.defa yapıştırılamaz!";
        }
        public static string HacimGenisletildi()
        {
            return "Kumabara sallanarak hacim genişletildi.";
        }
        
        public static string SecimYapilmadi()
        {
            return "Seçim yapmadınız!";
        }
        public static string KumbaraSuanSallanamaz()
        {
            return "Kumbara dolu değilken sallanmaz!";
        }
    }
}
