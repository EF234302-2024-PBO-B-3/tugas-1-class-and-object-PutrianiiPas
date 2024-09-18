using System;

namespace ClassAndObject.Kendaraan
{
	// Representasi informasi mobil
	public class Mobil
	{
		public string Merk { get; set; }
		public string Model { get; set; }
		public int TahunProduksi { get; set; }

		// Konstruktor untuk inisialisasi
		public Mobil(string merkMobil, string model, int tahunProduksi)
		{
			Merk = merkMobil;
			Model = model;
			TahunProduksi = tahunProduksi;
		}

		// Metode untuk cetak spesifikasi mobil
		public void TampilkanSpesifikasi()
		{
			Console.WriteLine($"Merk: {Merk}, Model: {Model}, Tahun Produksi: {TahunProduksi}");
		}
	}
}