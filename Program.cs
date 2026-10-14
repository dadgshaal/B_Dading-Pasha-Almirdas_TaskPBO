using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;


namespace taskPbo
{
    class Item
    {
        protected string judul;
        public int tahun;
        public Item(string judul, int tahun)
        {
            this.judul = judul;
            this.tahun = tahun;
        }
        public virtual void Deskripsi()
        {
            Console.WriteLine($"Item: {judul} ({tahun})");
        }
        public void InfoItem()
        {
            Console.WriteLine($"Info: {judul} ({tahun})");
        }
    }

    class Buku : Item
    {
        public string penulis;
        public Buku(string judul, int tahun, string penulis) : base(judul, tahun)
        {
            this.penulis = penulis;
        }
        public void CekPenulis()
        {
            Console.WriteLine($"Penulis: {penulis}");
        }
        public override void Deskripsi()
        {
            Console.WriteLine("DESKRIPSI BUKU:");
            Console.WriteLine($"{judul}  oleh {penulis}  ({tahun}) ");
            Console.WriteLine();
        }
    }
    class Majalah : Item
    {
        public string edisi;
        public Majalah(string judul, int tahun, string edisi) : base(judul, tahun)
        {
            this.edisi = edisi;
        }
        public void InfoEdisi()
        {
            Console.WriteLine($"Edisi: {edisi}");
        }
        public override void Deskripsi()
        {
            Console.WriteLine("DESKRIPSI MAJALAH:");
            Console.WriteLine($"{judul} ({tahun}) {edisi}");
            Console.WriteLine();
        }
    }

    class Novel : Buku
    {
        public Novel(string judul, int tahun, string penulis) : base(judul, tahun, penulis)
        {

        }
        public void BacaSinopsis()
        {
            Console.WriteLine($"Sinopsis {judul} bercerita tentang... ");
        }
        public override void Deskripsi()
        {
            Console.WriteLine("DESKRIPSI NOVEL:");
            Console.WriteLine($"{judul}  {tahun}  {penulis}");
            Console.WriteLine();
        }
    }
    class Komik : Buku
    {
        public Komik(string judul, int tahun, string penulis) : base(judul, tahun, penulis)
        {

        }
        public void TampilkanIlustrasi()
        {
            Console.WriteLine("Ilustrasi ditampilkan: ");
        }
        public override void Deskripsi()
        {
            Console.WriteLine("DESKRIPSI KOMIK: ");
            Console.WriteLine($"{judul}  oleh {penulis}  ({tahun})");
            Console.WriteLine();
        }
    }

    class MajalahAnak : Majalah
    {
        public MajalahAnak(string judul, int tahun, string edisi) : base(judul, tahun, edisi) { }
        public void KategoriAnak()
        {
            Console.WriteLine($"Majalah {judul} untuk anak-anak");
        }
        public override void Deskripsi()
        {
            Console.WriteLine("DESKRIPSI  MAJALAH ANAK:");
            Console.WriteLine($"{judul} {tahun}  {edisi}");
            Console.WriteLine();
        }

    }
    class MajalahTeknologi : Majalah
    {
        public MajalahTeknologi(string judul, int tahun, string edisi) : base(judul, tahun, edisi) { }
        public void TopikTeknologi()
        {
            Console.WriteLine($"MAJALAH {judul} TENTANG TEKNOLOGI");
        }
        public override void Deskripsi()
        {
            Console.WriteLine("DESKRIPSI MAJALAH TEKNOLOGI:");
            Console.WriteLine($"{judul}  {tahun}  {edisi}");
            Console.WriteLine();
        }
    }
    class Perpustakaan
    {
        List<Item> daftarItem = new List<Item>();
        public void TambahItem(Item item)
        {
            daftarItem.Add(item);
        }
        public void DaftarItem()
        {
            foreach (Item item in daftarItem)
            {
                item.Deskripsi();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Perpustakaan perpus = new Perpustakaan();
            perpus.TambahItem(new Buku("Bumi Manusia", 1980, "Pramoedya Ananta Toer"));
            perpus.TambahItem(new Buku("Meneroka Sapardi", 2021, "FIB UI"));
            perpus.TambahItem(new Buku("Filosofi Teras", 2018, "Henry Manampiring"));
            perpus.TambahItem(new Majalah("Djawa Baroe", 1943, "63"));
            perpus.TambahItem(new MajalahTeknologi("How to be a perfect human", 2026, "999"));
            perpus.TambahItem(new MajalahAnak("Akar Kontroversi Salafi Wahabi", 2020, "162"));
            perpus.TambahItem(new Novel("Dia Adalah Kakakku", 2018, "Tere Liye"));
            perpus.TambahItem(new Novel("Hati Suhita", 2019, "Khilma Anis"));
            perpus.TambahItem(new Novel("Harga Sebuah Percaya", 2017, "Tere Liye"));
            perpus.TambahItem(new Komik("Agent Kim Reactivated", 2026, "Nam Dae-joong"));
            perpus.TambahItem(new Komik("Killer Peter", 2023, "Kim Junghyun"));
            perpus.TambahItem(new Komik("Wind Breaker", 2025, "Yongseok Jo"));
            perpus.DaftarItem();

            Item item1 = new Buku("Madilog", 1943, "Pramoedya Ananta Toer");
            Item item2 = new Novel("Cantik Itu Luka", 2002, "Eka Kurniawan");

            item1.Deskripsi();
            Console.WriteLine();
            item2.Deskripsi();
            Console.WriteLine();

            Buku buku1 = new Buku("Islam Ala Prabowo", 2026, "Abdur Rahim Hasan");
            Novel novel1 = new Novel("Laskar Pelangi", 2005, "Andrea Hirata");
            Komik komik1 = new Komik("Lookism", 2014, "Park Tae-Joon");
            Majalah majalah1 = new Majalah("Madjalah Tempoe Doeloe", 2022, "23");
            MajalahAnak majalahanak = new MajalahAnak("Meminta Uang pada Ibu", 0921, "029");
            MajalahTeknologi majalahteknologi = new MajalahTeknologi("vibe coder 2026 sukses", 2066, "92492");

            buku1.CekPenulis();
            Console.WriteLine();
            novel1.BacaSinopsis();
            Console.WriteLine();
            komik1.TampilkanIlustrasi();
            Console.WriteLine();
            majalah1.InfoEdisi();
            Console.WriteLine();
            majalahanak.KategoriAnak();
            Console.WriteLine();
            majalahteknologi.TopikTeknologi();

            // untuk soal nomer 5
            Item itemkomik = new Komik("judulnya nanti, setelah semua selesai", 2025, "dading");
            itemkomik.Deskripsi();
        }
    }
}
