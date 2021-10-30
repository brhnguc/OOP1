using System;
using System.Collections.Generic; //list sınıfını kullanmak için

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            ////Bu diziye başka bir eleman eklemek sitiyoruz diyelim

            //isimler = new string[5];    // şunu yazdığın an üstteki dizi silinir 5 elemanlı ayrı bir dizi oluşturulur
            //isimler[4] = "İlker";       //ve burda 5. elemana ilkeri eklersin ama 1,2,3,4. yerler boş olacaktır

            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            //yani eklemeyi başaramadık!!

            //peki nasıl yapabiliriz? Koleksiyonlar ile
            //Koleksiyonlar artık dizilerin yerini almıştır sonradan gelmiş bir özellik
            //artk projelerde diziler değil "koleksiyonlar" kullanılıyor.


            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");

            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            // Listin fonkisyonlarına bak sitediki ödevde vermiş zaten
            // ama internetim yok right now 






        }
    }
}
