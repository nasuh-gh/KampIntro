using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //Constructor-Class'ı new'lersen burası çalışıyor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//geçici olarak referans numarasını burada tutturuyoruz
            items = new T[items.Length + 1];//yukarıdakini yapmasaydık önceki verilerim kaybolacaktı
            for (int i = 0; i < tempArray.Length; i++)//geçici emanet olarak verdiğim elemanları geri alacağım
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;//burada add'le gelen yeni elemanı boş kısma ekliyoruz(getiriyoruz)
            //length -1 toplam eleman sayısından 1 eksik yani index değeri

        }
    }
}
