using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MehmetOcguder_Odev_SayisalLoto
{
    
   static internal class Loto
    {
              

        static public int[] Tahmin()
        {
            
            int[] tahmin = new int[6];
            for (int i = 0; i < 6; i++)
            {
                
                Console.WriteLine($"\n{i+1}. Tahmininizi Giriniz: ");
                tahmin[i]=Convert.ToInt32(Console.ReadLine());
            }
            return tahmin;
        }
       static public  int[] SayiUret()
        {
            Random  rnd = new Random(); 
            int[] randomSayilar = new int[6];
            for (int i = 0; i < 6; i++)
            {
                randomSayilar[i] = rnd.Next(1, 50);
            }
            Array.Sort(randomSayilar);
            return randomSayilar;
            
        }
        
    }
}
