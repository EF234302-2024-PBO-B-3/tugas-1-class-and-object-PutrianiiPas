using System;

namespace ClassAndObject.Perpustakaan
{
	public class Buku
	{
		// Representasi informasi buku
		public string Judul { get; set; }
		public string Penulis { get; set; }
        public int TahunTerbit { get; set; }

        // Konstruktor untuk inisialisasi
        public Buku(string judul, string penulis, int tahunTerbit)
		{
			Judul = judul;
			Penulis = penulis;
			TahunTerbit = tahunTerbit;
		}

        // Metode untuk cetak spesifikasi mobil
        public void TampilkanInfo()
		{
			Console.WriteLine($"Judul: {Judul}, Penulis: {Penulis}, Tahun Terbit: {TahunTerbit}");
		}
	}
}