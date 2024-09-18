using System;
using System.Globalization;

namespace ClassAndObject.TokoSepeda
{
	// Representasi informasi sepeda
	public class Sepeda
	{
		public string Merk { get; set; }
		public string Tipe { get; set; }
		public double Berat { get; set; }

		// Konstruktor untuk inisialisasi
		public Sepeda(string merkSepeda, string tipe, double berat)
		{
			Merk = merkSepeda;
			Tipe = tipe;
			Berat = berat;
		}

		// Metode untuk cetak spesifikasi sepeda
		public void TampilkanInformasi()
		{
			Console.WriteLine($"Merek: {Merk}, Tipe: {Tipe}, Berat: {Berat.ToString("F1", CultureInfo.InvariantCulture)} kg");
		}
	}
}