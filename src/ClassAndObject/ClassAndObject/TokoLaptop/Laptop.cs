using System;

namespace ClassAndObject.TokoLaptop
{
	// Representasi informasi mobil
	public class Laptop
	{
		public string Merk { get; set; }
		public string Prosesor { get; set; }
		public int Ram { get; set; }
		public int Penyimpanan { get; set; }

		// Konstruktor untuk inisialisasi
		public Laptop(string merkLaptop, string prosesor, int ram, int penyimpanan)
		{
			Merk = merkLaptop;
			Prosesor = prosesor;
			Ram = ram;
			Penyimpanan = penyimpanan;
		}

		// Metode untuk cetak spesifikasi mobil
		public void TampilkanSpesifikasi()
		{
			Console.WriteLine($"Merk: {Merk}, Prosesor: {Prosesor}, RAM: {Ram} GB, Penyimpanan: {Penyimpanan} GB");
		}
	}
}