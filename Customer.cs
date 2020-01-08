using System;

namespace bank
{
    // Banka Müşterileri
    public class Customer : IComparable<Customer>
    {
        // Müşteri ismi
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Öncelik sırası küçükten büyüğe doğru
        // Bireysel müşteri=0 ve ticari müşteri=1 ...
        // ya da bakiyesi ne kadar fazlaysa 
        // o kadar fazla öncelik puanı.
        private double priority;

        public Customer(string name, double priority)
        {
            this.name = name;
            this.priority = priority;
        }

        // Anlamlı obj isimleri için toString override
        public override string ToString()
        {
            return "name: " + this.Name + " priority: " + this.priority;
        }

        // Comparable interface implementasyonu.
        // obj'nin önceliği karşılaştırılan obj'den:
        // küçükse -1 büyükse 1 aynıysa 0 döndür.
        public int CompareTo(Customer next)
        {

            if (this.priority < next.priority)
            {
                return -1;
            }
            else if (this.priority > next.priority)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }

}

