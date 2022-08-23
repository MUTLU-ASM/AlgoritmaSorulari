using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgortimaCalısmaları
{
    class Program
    {
        static void Main(string[] args)
        {
            questions soru = new questions();
            soru.CiftOlanlariYazdir();
            //soru.BolunenleriYazdir();
            //soru.SondanBasaYazdir();
            soru.Kelimeharfsayisi();
            Console.ReadLine();
        }
    }
    class questions
    {
        public void CiftOlanlariYazdir()
        {
            //1.soru
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. 

            Console.WriteLine("Lütfen pozitif bir sayı giriniz : ");
            int diziUzunlugu = int.Parse(Console.ReadLine());

            if (diziUzunlugu < 1) //Girilen Dizi uzunluğu pozitif değer değilse hata ver.Tekrar girmesini sağla.
            {
                Console.WriteLine("Hatalı sayı girdiniz Lütfen pozitif bir sayı giriniz : ");
                diziUzunlugu = int.Parse(Console.ReadLine());
            }

            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen pozitif olan {0}. sayıyı giriniz : ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("girmiş olduğunuz sayılardan çift olanlar = ");

            for (int i = 0; i < diziUzunlugu; i++)
            {
                if (sayiDizisi[i] % 2 == 0)
                {
                    Console.Write(sayiDizisi[i] + " ");
                }
            }

        }

        public void BolunenleriYazdir()
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            int[] sayilar = new int[2];

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Lütfen pozitif olan {0}. sayıyı giriniz : ", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            int n, m;

            n = sayilar[0];
            m = sayilar[1];

            int[] sayiDizisi = new int[n];
            Console.WriteLine(n + " tane sayi girmelisiniz!");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen pozitif olan {0}. sayıyı giriniz : ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            Console.Write(m + "Sayısına tam bölünenler");
            for (int i = 0; i < n; i++)
            {
                if (sayiDizisi[i] % m == 0)
                {
                    Console.Write(sayiDizisi[i] + " ");
                }
            }
        }

        public void SondanBasaYazdir()
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.Write("Lütfen pozitif bir sayı giriniz : ");
            int diziUzunlugu = int.Parse(Console.ReadLine());

            if (diziUzunlugu < 1) //Girilen Dizi uzunluğu pozitif değer değilse hata ver.Tekrar girmesini sağla.
            {
                Console.WriteLine("Hatalı sayı girdiniz Lütfen pozitif bir sayı giriniz : ");
                diziUzunlugu = int.Parse(Console.ReadLine());
            }
            string[] kelimeDizisi = new string[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen pozitif olan {0}. kelimeyi giriniz : ", i + 1);
                kelimeDizisi[i] = Console.ReadLine();
            }

            for (int i = diziUzunlugu - 1; i >= 0; i--)
            {
                Console.WriteLine(kelimeDizisi[i]);
            }
        }

        public void Kelimeharfsayisi()
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.Write("Cümle Giriniz : ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');
            Console.WriteLine("Kelime Sayisi : {0}", words.Count());

            Console.WriteLine("Harf Sayisi : {0}", sentence.Count());
        }
    }
}
