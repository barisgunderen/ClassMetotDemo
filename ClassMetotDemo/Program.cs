using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123;
            musteri1.Name = "Barış";
            musteri1.LastName = "Gunderen";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 123333;
            musteri2.Name = "mero";
            musteri2.LastName = "konar";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 9995588;
            musteri3.Name = "jilet";
            musteri3.LastName = "çehov";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 331131331;
            musteri4.Name = "felfena";
            musteri4.LastName = "fenasal";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager MusteriBilgileri = new MusteriManager();
            MusteriBilgileri.Add(musteri2);
            Console.WriteLine("---------------------");
            MusteriBilgileri.Delete(musteri3);
            Console.WriteLine("-------------");
            MusteriBilgileri.List(musteriler);


            //foreach (Musteri kokonat in musteriler)
            //{
            //    Console.WriteLine(kokonat.Name +" "+ kokonat.LastName +" "+ kokonat.Id);

            //}



        }
    }
}
