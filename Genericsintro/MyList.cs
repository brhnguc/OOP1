using System;
using System.Collections.Generic;
using System.Text;
//çok önemli bir konuya hoş geldin 
//Burada List'in arkasında çalışan array mantığını kendi elimizle kodladık
//Kilidi açılan bilgiler Constructer
namespace Genericsintro
{
    class MyList<T>
    {
        T[] items; //class içinde metod dışında T tipinde bir dizi tanımladık
       
        //constructor (ctor tab tab)
        public MyList() //MyList classını bir yerde new'lersek burası direk çalışıcak
        {
            items = new T[0];
        }

       
        public void Add(T item) //burdaki T yani tipi(string,int vs) kullanıcı belirlesin diyor. İtem öyle genel isim
        {
            T[] tempArray = items; // aşşağıdaki satırda newlediğimiz için bizim elemanlar kaybolacak bunu önlemek için dizimizdeki elemanları tutacak geçici bir dizi (tempArray) tanımladık ve buraya atadık elemanlarımız
            items = new T[items.Length + 1];    //dizimiz 0 elemanlı başta yeni eleman eklemek için eleman sayımızı arttırmamız gerek o yüzden böyle bir şey yapıyoruz

            //şimdi tempArray eski elemanlarımızı tutu,
            //bizim arrayımıza bu eski elemanları atayalım :

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //tamamdırrr eski elemanları kurtardık şimdi son elemanı da ekledik mi tamam bizim iş

            items[items.Length - 1] = item; //bu kadaaarrrr ^^

        }

    }
}
