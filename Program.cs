using System;

namespace while_foreach // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            // 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program.
            Console.Write("Lütfen bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            //'a' dan 'z' ye kadar bütün harfleri sırayla yazan program
            char karakter = 'a';
            while (karakter<='z')
            {
                Console.Write(karakter);
                karakter++;
            }
            Console.WriteLine("**** Foreach ****");
            string[] arabalar = {"Bmw", "Ford", "Toyota", "Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}