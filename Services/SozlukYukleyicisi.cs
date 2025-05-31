using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using KelimeEzberleme.Models;

namespace KelimeEzberleme.Services
{
    public class SozlukYukleyici
    { 
        
        public static List<Kelime> Yukle(string dosyaYolu)
        {
            var Kelimeler = new List<Kelime>();

            try
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                foreach (string satir in satirlar) 
                           
                {
                    if (string.IsNullOrWhiteSpace(satir)) continue;

                    string[] parcalar = satir.Split('\t');

                    if (parcalar.Length >= 2)
                    {
                        string ingilizce = parcalar[0].Trim();
                        string turkce = parcalar[1].Trim();

                        Kelimeler.Add(new Kelime(ingilizce, turkce));


                    }

                
                }
            }
            
            catch (Exception ex )
            { 
                Console.WriteLine("Hata oluştu: " + ex.Message); 
            }

            return Kelimeler;
        }


    }
}
