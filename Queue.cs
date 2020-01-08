using System;
using System.Collections.Generic;


namespace bank
{


    // Kuyruk
    public class Queue<T> where T : IComparable<T>
    {
        private List<T> list;

        // Queue objesi oluşturunca bir liste oluştur
        public Queue() => this.list = new List<T>();

        // 
        public void enQueue(T item)
        {

            list.Add(item);

            // kuyruktaki kişi sayısı length'te tutar
            int length = list.Count;

            // Kuyrukta önceliği daha düşük kaç kişi var
            // onun sayısını tutar
            int count = 0;

            // sondan başa doğru tek tek öncelikleri karşılaştırır
            for (int i = (length - 2); i >= 0; i--)
            {
                // Önceliği daha düşükse count'ı arttır
                if (item.CompareTo(list[i]) > 0)
                {
                    count++;
                    // Yeni gelen kişi listedeki herkesten daha yüksek
                    // öncelikliyse
                    if (count == list.Count - 1)
                    {
                        int new_place = (count / 2);
                        list.Insert(new_place, item);
                        list.RemoveAt(list.Count - 1);
                    }
                }
                // Önceliği daha yüksek ya da eşit bir item bulunca onun
                // o zamana kadar önceliği daha düşük kaç kişiyi geçtiyse
                // 2ye böl ve o kadar kişi sağa kaydır.
                else
                {
                    int place = (count / 2) + 1;
                    list.Insert(i + place, item);
                    list.RemoveAt(list.Count - 1);
                    break;
                }
            }
        }

        // Kuyruktaki en öndeki kişiyi kaldırır.
        public void deQueue()
        {
            list.RemoveAt(0);
        }
        // kuyrukdaki ilk müşteriyi döndür
        public T getFirst()
        {
            return list[0];
        }

        //kuyruktaki müşteri sayısını döndür 
        public int getCount()
        {
            return list.Count;
        }

        // toString override
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < list.Count; i++)
            {
                s += list[i].ToString() + " ";

            }
            return s;
        }
    }
}