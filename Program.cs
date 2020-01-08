using System;


namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Müşteri oluştur.
            Customer ab = new Customer("1", 1.0);
            Customer ac = new Customer("2", 2.0);
            Customer ad = new Customer("3", 3.0);
            Customer ae = new Customer("4", 4.0);
            Customer af = new Customer("5", 5.0);
            Customer ag = new Customer("4Y", 4.0);
            Customer ah = new Customer("3Y", 3.0);




            System.Console.WriteLine("---------");
            Queue<Customer> q = new Queue<Customer>();
            q.enQueue(ab);
            q.enQueue(ac);
            q.enQueue(ad);
            q.enQueue(ae);
            q.enQueue(af);
            System.Console.WriteLine(q);
            q.enQueue(ag);
            System.Console.WriteLine(q);
            q.enQueue(ah);
            System.Console.WriteLine(q);
            //Kuyruktan en öndekini çıkar
            q.deQueue();
            System.Console.WriteLine(q);



        }
    }
}
