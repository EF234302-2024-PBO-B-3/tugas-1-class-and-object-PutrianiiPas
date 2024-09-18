using System;

namespace ClassAndObject.OperasiMatematika
{
    public class Kalkulator
    {
        // Operasi Penjumlahan
        public double Tambah(double a, double b)
        {
            double hasil = a + b;
            TampilkanHasil("Penjumlahan", hasil);
            return hasil;
        }

        // Operasi Pengurangan
        public double Kurang(double a, double b)
        {
            double hasil = a - b;
            TampilkanHasil("Pengurangan", hasil);
            return hasil;
        }

        // Operasi Perkalian
        public double Kali(double a, double b)
        {
            double hasil = a * b;
            TampilkanHasil("Perkalian", hasil);
            return hasil;
        }

        // Operasi Pembagian
        public double Bagi(double a, double b)
        {
            if (b == 0)
            {
                if (a > 0)
                {
                    return double.PositiveInfinity;
                }
                else if (a < 0)
                {
                    return double.NegativeInfinity;
                }
                else
                {
                    return double.NaN;
                }
            }
            else
            {
                double hasil = a / b;
                TampilkanHasil("Pembagian", hasil);
                return hasil;
            }
        }

        // Metode untuk cetak hasil operasi matematika
        private void TampilkanHasil(string operasi, double hasil)
        {
            Console.WriteLine($"Hasil operasi {operasi}: {hasil}");
        }
    }
}