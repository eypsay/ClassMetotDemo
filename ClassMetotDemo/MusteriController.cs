using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriController
    {
        public void musteriEkle(Musteri[] musteriler)
        {
            int mustSayi = 0;
            Console.WriteLine("Kac Musteri eklemek istersiniz?");
            mustSayi = UInt16.Parse(Console.ReadLine());
            if (mustSayi == 0) { mustSayi = 1; }
            

            for (int i = 0; i < mustSayi; i++)
            {
                Musteri mus = new Musteri();
                mus.musID = i;
                Console.WriteLine("Musteri Adı:");
                mus.musAd = Console.ReadLine();
                Console.WriteLine("Musteri SoyAdı:");
                mus.musSoyad = Console.ReadLine();
                mus.musBakiye = 0.0;

                Console.WriteLine("\n"+mus.musAd +
                " Musterisi Eklendi!\n");

                musteriler[i] = mus;
            }
            Console.WriteLine("Devam etmek için bir tuşa basınız!!!");
            Console.ReadLine();
        }
        public void musteriSil(Musteri[] musteriler)
        {
            byte  classIndex = 0;
            Musteri mus = new Musteri();
            Console.WriteLine("Musteri No giriniz:");
            uint musNo = uint.Parse(Console.ReadLine());
            musteriListele(musteriler, musNo);
            Console.WriteLine("Bu Müşteri SİLİNECEK");
            //double yatan = double.Parse(Console.ReadLine());
            foreach (var item in musteriler)
            {
                
               
                if (item == null) { break; }
                else
                {
                    if (item.musID == musNo)
                    {

                        musteriler[classIndex] = mus;
                        
                    }
                    Console.WriteLine("Müşteri SİLİNDİ!!!.Devam etmek için bir tuşa basınız!!!");
                    Console.ReadLine();
                }
                classIndex++;
            }
        }
        public void musteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                if (musteri == null) { break; } 
                else { 
                Console.WriteLine("Musteri No:" + musteri.musID);
                Console.WriteLine("Musteri Adı:" + musteri.musAd);
                Console.WriteLine("Musteri SoyAdı:" + musteri.musSoyad); 
                Console.WriteLine("Musteri Bakiye:" + musteri.musBakiye);
                Console.WriteLine("------------------------------------------\n");
            }
            }
            Console.WriteLine("Devam etmek için bir tuşa basınız!!!");
            Console.ReadLine();
        }
        public void musteriListele(Musteri[] musteriler, uint musno)
        {
            foreach (var musteri in musteriler)
            {
                if (musteri == null) { break; }
                else
                {
                    if (musteri.musID == musno)
                    {
                        Console.WriteLine("Musteri No:" + musteri.musID);
                        Console.WriteLine("Musteri Adı:" + musteri.musAd);
                        Console.WriteLine("Musteri SoyAdı:" + musteri.musSoyad);
                        Console.WriteLine("Musteri Bakiye:" + musteri.musBakiye);
                        Console.WriteLine("------------------------------------------\n");
                    }
                }
            }
            //Console.WriteLine("Devam etmek için bir tuşa basınız!!!");
            //Console.ReadLine();
        }
        public void paraYatır(Musteri[] musteri)
        {

            Console.WriteLine("Musteri No giriniz:");
            uint musNo = uint.Parse(Console.ReadLine());
            musteriListele(musteri, musNo);
            Console.WriteLine("Yatırılacak Bakiye giriniz:");
            double yatan = double.Parse(Console.ReadLine());
            foreach (var item in musteri)
            {
                if (item == null) { break; }
                else
                {
                    if (item.musID == musNo)
                    {
                        item.musBakiye += yatan;
                        Console.WriteLine("Yeni Bakiye: " + item.musBakiye);
                    }
                }
            }
            Console.WriteLine("Devam etmek için bir tuşa basınız!!!");
            Console.ReadLine();
        }
    }
}
