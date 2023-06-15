namespace MehmetOcguder_Odev_SayisalLoto
{


    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Sayısal Loto Oyununa Hoşgeldiniz.");
            Console.WriteLine("6 Adet tahmin hakkınız ile sayıları tahmin etmeye çalışacaksınız.");
            
            int dogru = 0;
            bool kontrol = false;
            

            Console.WriteLine("Tahminlerinizi giriniz.");
            Console.WriteLine("***********************************");
            int[] randomSayilar = Loto.SayiUret();  //Hile kısmı
            foreach (int i in randomSayilar)
            {
                
                Console.Write($"{i}\t ");
                Console.WriteLine("***HİLE***");
            }
            int[] girilenSayilar = Loto.Tahmin();
            foreach (var random in randomSayilar)
            {
                foreach (var tahmin in girilenSayilar)
                {

                    if (random == tahmin)
                    {
                        Console.WriteLine($"Bildiğiniz Sayı : {random}");
                        dogru += 1;
                        kontrol = true;

                    }
                }
            }
            if (kontrol)
            {
                Console.WriteLine($"{dogru} tane bildiniz.");
            }
            else
            {
                Console.WriteLine("Malesef doğru tahminde bulunmadınız.");
            }
            foreach (var random in randomSayilar)
            {
                Console.WriteLine();
                Console.WriteLine($"{random}");
            }

        }
    }
}