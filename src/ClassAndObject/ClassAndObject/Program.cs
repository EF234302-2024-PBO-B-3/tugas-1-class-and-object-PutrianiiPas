using ClassAndObject.Perpustakaan;
using ClassAndObject.Kendaraan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;
using ClassAndObject.OperasiMatematika;
using System;

namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BUKU
            Console.WriteLine("========== INFORMASI BUKU ==========");
            Console.WriteLine();

            Console.Write("Masukkan judul buku: ");
            string judul = Console.ReadLine();

            Console.Write("Masukkan nama penulis: ");
            string penulis = Console.ReadLine();

            Console.Write("Masukkan tahun terbit: ");
            int tahunTerbit;

            // Validasi input
            while (!int.TryParse(Console.ReadLine(), out tahunTerbit))
            {
                Console.Write("Input salah. Masukkan tahun terbit yang valid (angka): ");
            }

            Buku buku = new Buku(judul, penulis, tahunTerbit);
            buku.TampilkanInfo();
            Console.ReadKey();

            Console.WriteLine();

            // KENDARAAN
            Console.WriteLine("========== SPESIFIKASI MOBIL ==========");
            Console.WriteLine();

            Console.Write("Masukkan merk mobil: ");
            string merkMobil = Console.ReadLine();

            Console.Write("Masukkan model mobil: ");
            string model = Console.ReadLine();

            Console.Write("Masukkan tahun produksi: ");
            int tahunProduksi;

            // Validasi input
            while (!int.TryParse(Console.ReadLine(), out tahunProduksi))
            {
                Console.Write("Input salah. Masukkan tahun produksi yang valid (angka): ");
            }

            Mobil mobil = new Mobil(merkMobil, model, tahunProduksi);
            mobil.TampilkanSpesifikasi();
            Console.ReadKey();

            Console.WriteLine();

            // LAPTOP
            Console.WriteLine("========== SPESIFIKASI LAPTOP ==========");
            Console.WriteLine();

            Console.Write("Masukkan merk laptop: ");
            string merkLaptop = Console.ReadLine();

            Console.Write("Masukkan prosesor: ");
            string prosesor = Console.ReadLine();

            Console.Write("Masukkan RAM: ");
            int ram;

            // Validasi input
            while (!int.TryParse(Console.ReadLine(),out ram))
            {
                Console.Write("Input salah. Masukkan RAM yang valid (angka): ");
            }

            Console.Write("Masukkan penyimpanan (dalam GB): ");
            int penyimpanan;

            // Validasi input
            while (!int.TryParse(Console.ReadLine(), out penyimpanan))
            {
                Console.Write("Input salah. Masukkan penyimpanan yang valid (dalam GB): ");
            }

            Laptop laptop = new Laptop(merkLaptop, prosesor, ram, penyimpanan);
            laptop.TampilkanSpesifikasi();
            Console.ReadKey();

            Console.WriteLine();

            // SEPEDA
            Console.WriteLine("========== INFORMASI SEPEDA ==========");
            Console.WriteLine();

            Console.Write("Masukkan merk sepeda: ");
            string merkSepeda = Console.ReadLine();

            Console.Write("Masukkan tipe sepeda: ");
            string tipe = Console.ReadLine();

            Console.Write("Masukkan berat (dalam kilogram, ex: 20,3): ");
            double berat;

            // Validasi input
            while (!double.TryParse(Console.ReadLine(), out berat))
            {
                Console.WriteLine("Input salah. Masukkan berat yang valid (dalam kilogram): ");
            }

            Sepeda sepeda = new Sepeda(merkSepeda, tipe, berat);
            sepeda.TampilkanInformasi();
            Console.ReadKey();

            Console.WriteLine();

            // KALKULATOR
            Console.WriteLine("========== KALKULATOR SEDERHANA ==========");
            Console.WriteLine();

            Kalkulator kalkulator = new Kalkulator();
            string input = "";

            while (input != "exit")
            {
                Console.Write("Masukkan angka pertama: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan angka kedua: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Pilih operasi (Tambah, Kurang, Kali, Bagi): ");
                string operasi = Console.ReadLine();

                switch (operasi.ToLower())
                {
                    case "tambah":
                        kalkulator.Tambah(a, b);
                        break;
                    case "kurang":
                        kalkulator.Kurang(a, b);
                        break;
                    case "kali":
                        kalkulator.Kali(a, b);
                        break;
                    case "bagi":
                        kalkulator.Bagi(a, b);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Operasi tidak valid. Silahkan pilih Tambah, Kurang, Kali, atau Bagi");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Ketik 'exit' untuk keluar, atau tekan Enter untuk melanjutkan.");
                input = Console.ReadLine();

                if (input != "exit")
                {
                    Console.WriteLine("=============== LANJUT BERHITUNG ===============");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("==========  --  ===== SELESAI =====  --  ==========");
                }
            }
        }
    }
}