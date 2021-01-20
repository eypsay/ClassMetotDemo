using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim = 0,mustSayisi=0;

            MusteriController contr = new MusteriController();   
            
            Musteri musteri = new Musteri();
            Musteri[] musteriler = new Musteri[5];
         

            

           
            
            do
            {
                menu();
                Console.WriteLine("Seçiminiz Yapınız:");
                secim = Int16.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        contr.musteriEkle(musteriler);
                        break;
                    case 2:
                        { 
                        if ( (musteriler[0]!=null))
                        contr.musteriListele(musteriler);
                        else
                                Console.WriteLine("Liste Boş");       
                        }
                        break;
                    case 3:
                        contr.paraYatır(musteriler);
                        break;
                    case 4:
                        contr.musteriSil(musteriler);
                        break;

                    case 9: break;
                    default:
                        break;
                }
            } while (secim != 9);




        }
         public static void menu()
        {
            Console.Clear();
            Console.WriteLine("1- Musteri Ekle");
            Console.WriteLine("2-Musteri Listele");
            Console.WriteLine("4-Musteri Sil");
            Console.WriteLine("3-Müşteri İşlemleri(Para Yatır)");
            Console.WriteLine("9-Çıkış");
        }
    }
    
}
