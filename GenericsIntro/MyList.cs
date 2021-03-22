using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        //constructor = class ile aynı ismi aldığından anlayabiliriz,ilk olarak o array'in çalıştırılmasını sağlar.
        public MyList()
        {
            items = new T[0]; //items adında bir constructor oluşturuyoruz.Sıfır elemanlı ve ilk çalışacak olan.
        }

        T[] items;
        public void Add(T item) //item'a bir eleman ekleme kısmına geçiş yapıyoruz 
        {
            T[] tempArray = items; //items'ın değerleri geçici olarak tempArray'e aktarılıyor...

            items = new T[items.Length + 1]; //items'ın eleman sayısı arttırılıyor ve items yeni referansa geçiyor

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //geçici olarak verdiğimiz değerleri(tempArray) items'a geri veriyoruz
            }

            items[items.Length - 1] = item; //item'e eklemek istediğimiz eleman şimdi eklendi 

        }


    }
}
