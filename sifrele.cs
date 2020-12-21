using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sifre_olusturucu
{
    class sifrele
    {
        //şifremizde bulunacak harfleri değişkenlerde tanımlıyorum
        private static String [] kucukHarf = { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z" };
        private static String[] buyuhHarf = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "G", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
        private static String[] sayilar = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        private static String[] ozelHarfler = { "*", "/", "+", "-","-","_","!" };

        private static bool sayi, ozelKarakter, buyukharf, kucukharf;

        //bizim tüm işi gören fonksiyonumuz
        //parametre olarak şifremizi nasıl istediğimizi giriyoruz.
        //rastgele harfleri birleştirerek şifre oluşturuyor
        //rastgele olduğundan saçma sapan şifreler çıkabiliyor
        static public String hazirla(int uzunluk , bool sayip, bool ozelKarakterp ,bool buyukharfp,bool kucukharfp)
        {
            sayi = sayip; ozelKarakter = ozelKarakterp; buyukharf = buyukharfp; kucukharf = kucukharfp;

            String[] harfYigini = birlestir();
            String sifre = "";
            Random rnd = new Random();

            for (int i = 0; i < uzunluk && harfYigini.Length != 0; i++)
            {
                sifre += harfYigini[rnd.Next(0, harfYigini.Length)];
            }

            
            return sifre;
        }

        //bu kısım ise seçtiğimiz parametreleri tek dizi haline getirerek rastgele seçmemizi kolaylaştırıyor.
        static public String[] birlestir()
        {
            List<String> liste = new List<string>();

            if (kucukharf)
            {
                foreach (String a in kucukHarf) { liste.Add(a); }
            }
            if (sayi)
            {
                foreach (String a in sayilar) { liste.Add(a); }
            }
            if(ozelKarakter)
            {
                foreach (String a in ozelHarfler) { liste.Add(a); }
            }
            if(buyukharf)
            {
                foreach (String a in buyuhHarf) { liste.Add(a); }
            }

            return liste.ToArray();
        }


    }
}
