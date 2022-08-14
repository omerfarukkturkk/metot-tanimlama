using System;
using System.IO;

namespace diziler
{
    class Program
    {
       public static void Main(string[] args)
       {
           //erisim_belirteci geri_donuctipi metot_adi(parametreListesi/arguman)
           //{
                ///komutlar;
                ///return;
           //}

           int a=2;
           int b=3;
           int sonuc =Topla(a,b); 
           System.Console.WriteLine(sonuc);

           Metotlar ornek= new Metotlar();
           ornek.EkranaYazdir(Convert.ToString(sonuc));

           int sonuc2=ornek.ArttirveTopla(ref a,ref b);
           ornek.EkranaYazdir(Convert.ToString(sonuc2));
           ornek.EkranaYazdir(Convert.ToString(a+b));
                           
       }

       static int Topla(int deger1, int deger2)
       {
           return(deger1+deger2);
       }

    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine(veri);
        }

        public int ArttirveTopla(ref int deger1, ref int deger2)
        {
        deger1+=1;
        deger2+=1;
        return deger1+deger2;
        }

    }

    

}
