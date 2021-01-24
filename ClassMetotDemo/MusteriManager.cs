using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi biligler aşağıda");
            Console.WriteLine("-----------------");
            Console.WriteLine(musteri.Name);
            Console.WriteLine(musteri.LastName);
            Console.WriteLine(musteri.Id);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri yol aldı");
            Console.WriteLine("------------");
            Console.WriteLine(musteri.Name);
            Console.WriteLine(musteri.LastName);
            Console.WriteLine(musteri.Id);
        }

        public void List(Musteri[] musteri)
        {
            Console.WriteLine("müşterilerin listesi");
            Console.WriteLine("-------------");

            foreach (Musteri liste in musteri)
            {
                Console.WriteLine("---------------");
                Console.WriteLine(liste.Id);
                Console.WriteLine(liste.Name);
                Console.WriteLine(liste.LastName);
                

            }


        }
       
    }
}
